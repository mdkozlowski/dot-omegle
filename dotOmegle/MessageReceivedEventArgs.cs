using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotOmegle
{
    public class MessageReceivedArgs : EventArgs
    {
        public string message;

        public MessageReceivedArgs(string message)
        {
            this.message = message;
        }
    }

    public delegate void MessageReceivedEvent(object sender, MessageReceivedArgs e);
}