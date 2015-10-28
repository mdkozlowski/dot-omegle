using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OmegleMTM
{
    /// <summary>
    /// The chat where this all takes place
    /// </summary>
    public class Chatbox
    {

        public WebBrowser ChatBrowser = new WebBrowser();
        
        private List<string> Tags = new List<string>();
        /// <summary>
        /// Creates a new chatbox instance
        /// </summary>
        public Chatbox()
        {
            Reset();
        }
        /// <summary>
        /// Creates a new chatbox instance
        /// </summary>
        /// <param name="tags">List of tags</param>
        public Chatbox(List<string> tags)
        {
            this.Tags = tags;
            Reset();
        }
        /// <summary>
        /// Add Message
        /// </summary>
        /// <param name="Name">Name of Person</param>
        /// <param name="Message">Message contents</param>
        /// <param name="TextColor">Text color</param>
        public void PrintMessage(string Name, string Message,Color TextColor)
        {
            if (ChatBrowser.InvokeRequired)
            {
                ChatBrowser.Invoke((MethodInvoker)delegate
                {
                    PrintMessage(Name, Message, TextColor);
                });
                return;
            }
            string clr = ColorTranslator.ToHtml(TextColor);
            string write = "";
            write += "<p style=\"color:" + clr + "\">";
            write += Name + " (" + DateTime.Now.ToShortDateString() + "): " + Message;
            write += "</p>";
            ChatBrowser.Document.Write(write);
        }
        public void Reset()
        {
            ChatBrowser.Navigate("about:blank");
            ChatBrowser.Document.Write("<h1 style=\"color: green\"> Omegle MTM Chat </h1><br>");
            ChatBrowser.Document.Write("<h1 style=\"color: blue\">");
            foreach (string item in Tags)
            {
                ChatBrowser.Document.Write(item + " ");
            }
            ChatBrowser.Document.Write("</h1><br>");
            ChatBrowser.Document.Write("<h1>------------------------</h1><br>");
        }
        /// <summary>
        /// Set's the tags
        /// </summary>
        /// <param name="Tags"></param>
        public void SetTags(List<string> Tags)
        {
            this.Tags = Tags;
        }
        /// <summary>
        /// Prints a message directly to the browser
        /// </summary>
        /// <param name="message"></param>
        public void PrintMessage(string message)
        {
            ChatBrowser.Document.Write(message);
            
        }
    }
}
