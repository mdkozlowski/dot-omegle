using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotOmegle
{
    public class SharedInterestEventArgs : EventArgs
    {
        public readonly string[] SharedInterests;

        public SharedInterestEventArgs(params string[] interests)
        {
            this.SharedInterests = interests;
        }
    }

    public delegate void SharedInterestsFoundEvent(object sender, SharedInterestEventArgs e);
}
