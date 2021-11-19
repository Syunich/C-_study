using System;
using System.Collections.Generic;
using System.Text;

namespace Code1
{

    /// <summary>
    /// this is the class of example, included property , constructor
    /// </summary>
    public class Example
    {
        //these called property, consists of getter and setter. "private set" means that user can set this value only in this class.
        public int intvalue { get; private set; }
        public string name { get; private set; }

        /// <summary>
        /// this called constructer.we use it when we need to create instance.
        /// object has only reference, and we can access to member by using "." .
        /// </summary>
        /// <param name="intvalue"></param>
        /// <param name="name"></param>
        public Example(int intvalue = 0 , string name = "default")
        {
            this.intvalue = intvalue;
            this.name = name;
        }
    }
}
