//This is by "rakker" from "The Life and Times of a Dev".URL: http://geekswithblogs.net/rakker/archive/2006/04/21/76044.aspx

using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace dotOmegle
{
    /// <summary>
    /// Submits post data to a url.
    /// </summary>
    public class PostSubmitter
    {
        /// <summary>
        /// determines what type of post to perform.
        /// </summary>
        public enum PostTypeEnum
        {
            /// <summary>
            /// Does a GET against the source.
            /// </summary>
            Get,
            /// <summary>
            /// Does a POST against the source.
            /// </summary>
            Post
        }

        /// <summary>Occurs when a web exception event is encountered.</summary>
        public event WebExceptionEvent WebExceptionEvent;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public PostSubmitter()
        {
            PostItems = new NameValueCollection();
            Type = PostTypeEnum.Get;
        }

        /// <summary>
        /// Constructor that accepts a url as a parameter
        /// </summary>
        /// <param name="url">The url where the post will be submitted to.</param>
        public PostSubmitter(string url)
            : this()
        {
            Url = url;
        }

        /// <summary>
        /// Constructor allowing the setting of the url and items to post.
        /// </summary>
        /// <param name="url">the url for the post.</param>
        /// <param name="values">The values for the post.</param>
        public PostSubmitter(string url, NameValueCollection values)
            : this(url)
        {
            PostItems = values;
        }

        /// <summary>
        /// Gets or sets the url to submit the post to.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the name value collection of items to post.
        /// </summary>
        public NameValueCollection PostItems { get; set; }

        /// <summary>
        /// Gets or sets the type of action to perform against the url.
        /// </summary>
        public PostTypeEnum Type { get; set; }

        /// <summary>If set, specifies the cookie container associated with this object.</summary>
        /// <value>An instance of the <see cref="CookieContainer"/> class.</value>
        public CookieContainer CookieContainer { get; set; }

        /// <summary>
        /// Posts the supplied data to specified url.
        /// </summary>
        /// <returns>a string containing the result of the post.</returns>
        public string Post()
        {
            StringBuilder parameters = new StringBuilder();
            for (int i = 0; i < PostItems.Count; i++)
            {
                EncodeAndAddItem(ref parameters, PostItems.GetKey(i), PostItems[i]);
            }
            string result = PostData(Url, parameters.ToString());
            return result;
        }

        /// <summary>
        /// Posts the supplied data to specified url.
        /// </summary>
        /// <param name="url">The url to post to.</param>
        /// <returns>a string containing the result of the post.</returns>
        public string Post(string url)
        {
            Url = url;
            return this.Post();
        }

        /// <summary>
        /// Posts the supplied data to specified url.
        /// </summary>
        /// <param name="url">The url to post to.</param>
        /// <param name="values">The values to post.</param>
        /// <returns>a string containing the result of the post.</returns>
        public string Post(string url, NameValueCollection values)
        {
            PostItems = values;
            return this.Post(url);
        }

        /// <summary>
        /// Posts data to a specified url. Note that this assumes that you have already url encoded the post data.
        /// </summary>
        /// <param name="postData">The data to post.</param>
        /// <param name="url">the url to post to.</param>
        /// <returns>Returns the result of the post.</returns>
        private string PostData(string url, string postData, int retries = 1)
        {
            HttpWebRequest request = null;
            if (Type == PostTypeEnum.Post)
            {
                Uri uri = new Uri(url);
                request = (HttpWebRequest)WebRequest.Create(uri);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = postData.Length;
                using (Stream writeStream = request.GetRequestStream())
                {
                    UTF8Encoding encoding = new UTF8Encoding();
                    byte[] bytes = encoding.GetBytes(postData);
                    writeStream.Write(bytes, 0, bytes.Length);
                }
            }
            else
            {
                UriBuilder uri = new UriBuilder(url);
                if (uri.Query.Length == 0)
                    uri.Query = postData;

                request = (HttpWebRequest)WebRequest.Create(uri.Uri);
                request.Method = "GET";
            }

            request.CookieContainer = CookieContainer;

            string result = null;

            //Thanks to supersnail11 for this block here (http://www.facepunch.com/threads/1144771?p=33818537&viewfull=1#post33818537)

            while (result == null && retries-- > 0) try
                {
                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    using (Stream responseStream = response.GetResponseStream())
                    using (StreamReader readStream = new StreamReader(responseStream, Encoding.UTF8))
                        result = readStream.ReadToEnd();
                }
                catch (WebException e)
                {
                    if (this.WebExceptionEvent != null)
                        this.WebExceptionEvent(this, new WebExceptionEventArgs(e, url, postData, Type));
                    else
                    {
                        //throw (e);
                    }
                }

            return result;
        }

        /// <summary>
        /// Encodes an item and adds an item to the string.
        /// </summary>
        /// <param name="baseRequest">The previously encoded data.</param>
        /// <param name="dataItem">The data to encode.</param>
        /// <returns>A string containing the old data and the previously encoded data.</returns>
        private void EncodeAndAddItem(ref StringBuilder baseRequest, string key, string dataItem)
        {
            if (baseRequest == null)
                baseRequest = new StringBuilder();

            if (baseRequest.Length != 0)
                baseRequest.Append("&");

            baseRequest.Append(key);
            baseRequest.Append("=");
            baseRequest.Append(HttpUtility.UrlEncode(dataItem));
        }
    }
}