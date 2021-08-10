using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public partial class Message
    {
        private protected string Subject { get; set; }
        internal string Text { get; set; }

        protected internal string Attachment { get; set; }

        public Message()
        {
            Print();
        }
    }

    public partial class Message
    {
        public void Print()
        {
            Text = "";
        }
    }
}
