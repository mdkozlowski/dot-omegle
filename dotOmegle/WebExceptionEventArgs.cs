using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace dotOmegle
{
    /// <summary>
    /// Holds arguments for the WebExceptionEvent event.
    /// </summary>
    public class WebExceptionEventArgs : EventArgs
    {
        public PostSubmitter.PostTypeEnum Method { get; protected set; }
        public WebException Exception { get; protected set; }
        public string PostData { get; protected set; }
        public string Url { get; protected set;}        

        public WebExceptionEventArgs(WebException e, string url, string postData, 
            PostSubmitter.PostTypeEnum method)
        {
            this.Exception = e;
            this.Url = url;
            this.PostData = postData;
            this.Method = method;
        }
    }

    public delegate void WebExceptionEvent(object sender, WebExceptionEventArgs e);
}