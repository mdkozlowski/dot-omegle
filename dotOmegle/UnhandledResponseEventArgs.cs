using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotOmegle
{
    public class UnhandledResponseEventArgs : EventArgs
    {
        public string response;

        public UnhandledResponseEventArgs(string response)
        {
            this.response = response;
        }
    }

    public delegate void UnhandledResponseEvent(object sender, UnhandledResponseEventArgs e);
}