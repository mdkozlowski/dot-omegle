using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotOmegle
{
    public class CaptchaRequiredArgs : EventArgs
    {
        public string id;
        //public string url;

        public CaptchaRequiredArgs(string id)
        {
            this.id = id;
            //this.url = "http://www.google.com/recaptcha/api/challenge?k=" + id + "&ajax=1&cachestop=0.7569315146943529";
        }
    }

    public delegate void CaptchaRequiredEvent(object sender, CaptchaRequiredArgs e);
}
