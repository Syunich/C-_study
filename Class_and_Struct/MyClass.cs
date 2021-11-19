using System;
using System.Collections.Generic;
using System.Text;

namespace CsStudy1
{
    public class Myclass
    {
        public int intvalue { get;  set; }
        public string name { get;  set; }

        public Myclass(int intvalue = 0 , string name = "default")
        {
            this.intvalue = intvalue;
            this.name = name;
        }
    }
}
