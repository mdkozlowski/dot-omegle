using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using dotOmegle;

namespace SampleOmegle
{
    class Program
    {
        public static Omegle OmegleObj = new Omegle();
        static void Main(string[] args)
        {
            OmegleObj.Connected += new EventHandler(omegle_Connected);
            //OmegleObj.CaptchaRefused += new EventHandler(omegle_CaptchaRefused);
            //OmegleObj.CaptchaRequired += new CaptchaRequiredEvent(omegle_CaptchaRequired);
            OmegleObj.MessageReceived += new MessageReceivedEvent(omegle_MessageReceived);
            OmegleObj.StrangerDisconnected += new EventHandler(omegle_StrangerDisconnected);
            OmegleObj.StrangerTyping += new EventHandler(omegle_StrangerTyping);
            OmegleObj.StrangerStoppedTyping += new EventHandler(omegle_StrangerStoppedTyping);
            OmegleObj.WaitingForPartner += new EventHandler(omegle_WaitingForPartner);

            OmegleObj.Connect();
            
            Console.ReadLine();
        }



        private static void omegle_WaitingForPartner(object sender, EventArgs e)
        {
            Console.WriteLine("Still waiting to find a partner.");
        }

        private static void omegle_StrangerDisconnected(object sender, EventArgs e)
        {
            Console.WriteLine("Stranger disconnected, going to reconnect.");
            OmegleObj.Reconnect(); //be careful with this, omegle bans you eventually if you keep isntantly reconnecting
            //then you have to enter annoying captchas
        }

        private static void omegle_StrangerTyping(object sender, EventArgs e)
        {
            Console.WriteLine("Stranger is typing...");
        }

        private static void omegle_StrangerStoppedTyping(object sender, EventArgs e)
        {
            Console.WriteLine("Stranger stopped typing...");
        }

        private static void omegle_MessageReceived(object sender, MessageReceivedArgs e)
        {
            Console.WriteLine("Stranger: " + e.message); //we received a message, lets echo it back
            OmegleObj.SendMessage(e.message + " to you too, buddy.");
            Console.WriteLine("You: " + e.message + " to you too, buddy.");
        }

        private static void omegle_Connected(object sender, EventArgs e)
        {
            Console.WriteLine("Connected to someone.");
        }


    }
}
