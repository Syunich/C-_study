using System;
using System.Collections.Generic;
using System.Text;

namespace CsStudy1
{
    public sealed class Worker : Person
    {
        public int workernumber { get; set; }
        public Worker(int height , int weight , int age , string name , int workernumber) : base(height , weight , age , name)
        {
            this.workernumber = workernumber;
        }
    }
}
