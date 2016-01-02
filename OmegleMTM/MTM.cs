using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dotOmegle;
using System.Threading.Tasks;

namespace OmegleMTM
{
    /// <summary>
    /// The Core instance that drives the program
    /// </summary>
    public class MTM
    {
        public enum Strangers
        {
            Stranger1,
            Stranger2
        }
        /// <summary>
        /// Used for byte wise operations
        /// [stranger2Typing][Stranger1Typing]
        /// </summary>
        private static int StatusEvent;
        public class StatusEventArgs : System.EventArgs
        {
            public StatusEventArgs(bool Stranger1Typing, bool Stranger2Typing)
            {
                this.Stranger1IsTyping = Stranger1Typing;
                this.Stranger2IsTyping = Stranger2Typing;
            }
            public bool Stranger1IsTyping { get; private set; }
            public bool Stranger2IsTyping { get; private set; }
        }

        public delegate void StatusChangedHandler(object sender, StatusEventArgs e);
        public event StatusChangedHandler StatusChanged;

        private Queue<string> stranger1backlog = new Queue<string>();//Messages recieved from Stranger2
        private Queue<string> stranger2backlog = new Queue<string>();//Messages recieved from Stranger1
        private Omegle Stranger1 = new Omegle();
        private Omegle Stranger2 = new Omegle();
        private List<string> tags = new List<string>();
        public List<string> Tags {
            get
{
                return tags;
            }
            set
            {
                tags = value;
                ChatBrowser.SetTags(tags);
                Stranger1.Interests = tags;
                Stranger2.Interests = tags;
            }
        }
       public Chatbox ChatBrowser = new Chatbox();
        /// <summary>
        /// Creates new instance of the Man-In-The-Middle class
        /// </summary>
        /// <param name="Tags">Tags to use</param>
        public MTM(string[] tags)
        {
            this.tags = tags.ToList();
            ChatBrowser.SetTags(this.tags);
            //Send messages between strangers
            Stranger1.MessageReceived += Stranger1_MessageReceived;
            Stranger2.MessageReceived += Stranger2_MessageReceived;
            //Notify on connect / disconnect; Also Send/clear backlogged messages
            Stranger1.Connected += Stranger1_Connected;
            Stranger2.Connected += Stranger2_Connected;
            Stranger2.StrangerDisconnected += Stranger2_StrangerDisconnected;
            Stranger1.StrangerDisconnected += Stranger1_StrangerDisconnected;
            //Send typing status over
            Stranger1.StrangerTyping += (s, e) => {
                TypingStatusChanged(Strangers.Stranger1, true);
            };
            Stranger1.StrangerStoppedTyping += (s, e) => {
                TypingStatusChanged(Strangers.Stranger1, false);
            };
            Stranger2.StrangerTyping += (s, e) => {
                TypingStatusChanged(Strangers.Stranger2, true);
            };
            Stranger2.StrangerStoppedTyping += (s,e)=> {
                TypingStatusChanged(Strangers.Stranger2, false);
            };
            //Captcha Requests
            Stranger1.CaptchaRequired += CaptchaRequired;
            Stranger2.CaptchaRequired += CaptchaRequired;
            //various exceptions
            Stranger1.WebException += Stranger1_WebException;
            Stranger2.WebException += Stranger2_WebException;
            Stranger1.UnhandledResponse += Stranger1_UnhandledResponse;
            Stranger2.UnhandledResponse += Stranger2_UnhandledResponse;
        }

        private void Stranger2_UnhandledResponse(object sender, UnhandledResponseEventArgs e)
        {
            ChatBrowser.PrintMessage("OmegleMTM", "Stranger2 UnhandledResponse", System.Drawing.Color.DarkGreen);
        }

        private void Stranger1_UnhandledResponse(object sender, UnhandledResponseEventArgs e)
        {
            ChatBrowser.PrintMessage("OmegleMTM", "Stranger1 UnhandledResponse", System.Drawing.Color.DarkGreen);
        }

        private void Stranger2_WebException(object sender, WebExceptionEventArgs e)
        {
            ChatBrowser.PrintMessage("OmegleMTM", "Stranger2 WebException", System.Drawing.Color.DarkGreen);
            Console.Write(e.Exception.ToString());
        }

        private void Stranger1_WebException(object sender, WebExceptionEventArgs e)
        {
            ChatBrowser.PrintMessage("OmegleMTM", "Stranger1 WebException", System.Drawing.Color.DarkGreen);
            Console.Write(e.Exception.ToString());
        }

        private void CaptchaRequired(object sender, CaptchaRequiredArgs e)
        {
            ChatBrowser.PrintMessage("OmegleMTM", "Captcha Required!!", System.Drawing.Color.DarkGreen);
        }

        private void TypingStatusChanged(Strangers s, bool TypingStatus)
        {
            if (s == Strangers.Stranger1)
            {
                if (TypingStatus)
                    StatusEvent = StatusEvent | 1; //either 1 or 3
                else
                    StatusEvent = StatusEvent & (StatusEvent & 2); //either 0 or 2
            }
            else
            {
                if (TypingStatus)
                    StatusEvent = StatusEvent | 2; //either 1 or 3
                else
                    StatusEvent = StatusEvent & (StatusEvent & 1); //either 0 or 1
            }
            StatusEventArgs se = new StatusEventArgs(((StatusEvent & 1) == 1), ((StatusEvent & 2) == 2));
            //Set Status's
            switch (StatusEvent){
                case 0:
                    Stranger1.StopTyping();
                    Stranger2.StopTyping();
                    break;
                case 1:
                    Stranger1.StartTyping();
                    Stranger2.StopTyping();
                    break;
                case 2:
                    Stranger1.StopTyping();
                    Stranger2.StartTyping();
                    break;
                default:
                    Stranger1.StartTyping();
                    Stranger2.StartTyping();
                    break;
            }
            //throw new NotImplementedException();
            OnStatusChanged(se);
        }

        /// <summary>
        /// When stranger1 disconnects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stranger1_StrangerDisconnected(object sender, EventArgs e)
        {
            ChatBrowser.PrintMessage("OmegleMTM", "Stranger1 Disconnected", System.Drawing.Color.DarkGreen);
            stranger2backlog.Clear();
        }
        /// <summary>
        /// When stranger 2 disconnects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stranger2_StrangerDisconnected(object sender, EventArgs e)
        {
            ChatBrowser.PrintMessage("OmegleMTM", "Stranger2 Disconnected", System.Drawing.Color.DarkGreen);
            stranger2backlog.Clear();
        }

        //On connect, send backlog to Stranger2
        private void Stranger2_Connected(object sender, EventArgs e)
        {
            ChatBrowser.PrintMessage("OmegleMTM", "Stranger2 connected", System.Drawing.Color.DarkGreen);
            while (stranger1backlog.Count > 0)
                Stranger1.SendMessage(stranger1backlog.Dequeue());
        }
        //On connect, send backlong to stranger2
        private void Stranger1_Connected(object sender, EventArgs e)
        {
            ChatBrowser.PrintMessage("OmegleMTM", "Stranger1 connected", System.Drawing.Color.DarkGreen);
            while (stranger2backlog.Count > 0)
                Stranger2.SendMessage(stranger1backlog.Dequeue());
        }

        //When Stranger 1 send a message, send it to stranger 2
        private void Stranger1_MessageReceived(object sender, MessageReceivedArgs e)
        {
            ChatBrowser.PrintMessage("Stranger 1", e.message, System.Drawing.Color.Blue);
            if (Stranger2.IsConnected)
                Stranger2.SendMessage(e.message);
            else
            {
                stranger2backlog.Enqueue(e.message);
            }
        }
        //When Stranger 2 sends a message, send it to stranger 1
        private void Stranger2_MessageReceived(object sender, MessageReceivedArgs e)
        {
            ChatBrowser.PrintMessage("Stranger 2", e.message, System.Drawing.Color.Red);
            if (Stranger1.IsConnected)
                Stranger1.SendMessage(e.message);
            else
            {
                stranger1backlog.Enqueue(e.message);
            }
        }

        /// <summary>
        /// Connects the strangers
        /// </summary>
        public void ConnectStrangers()
        {
            Stranger1.Connect();
            Stranger2.Connect();
        }
        /// <summary>
        /// Sends a message as stranger s to the other stranger
        /// </summary>
        /// <param name="s">Stranger your sending as</param>
        /// <param name="message">Message to send</param>
        public void SendMessage(Strangers s, string message)
        {
            if (s == Strangers.Stranger1)
            {
                if (Stranger2.IsConnected)
                    Stranger2.SendMessage(message);
                else
                    stranger2backlog.Enqueue(message);
                ChatBrowser.PrintMessage("Stranger1(You)", message, System.Drawing.Color.DarkBlue);
            }
            else
            {
                if (Stranger1.IsConnected)
                    Stranger1.SendMessage(message);
                else
                    stranger1backlog.Enqueue(message);
                ChatBrowser.PrintMessage("Stranger2(You)", message, System.Drawing.Color.DarkRed);
            }
        }
        protected virtual void OnStatusChanged(StatusEventArgs se)
        {
            if (StatusChanged != null)
                StatusChanged(this, se);
        }

        public void Reset()
        {
            if(Stranger1.IsConnected)
                Stranger1.SendDisconnect();
            if(Stranger2.IsConnected)
                Stranger2.SendDisconnect();
            ChatBrowser.Reset();
        }
    }
}
