using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Test
    {
        internal int Demo { get; set; }
    }

    internal class Demo
    {
        public void Print()
        {
            Test t = new Test();
            t.Demo = 10;

            Message m = new Message();
            m.Attachment = "Image";
            //m.Subject = "";
            m.Text = "";
        }
    }
        
    internal class Email : Message
    {
        public void Print()
        {
            Subject = "";
        }
    }
}
