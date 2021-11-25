using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CsStudy1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            var GreetList1 = new List<IGreeting>() { new GreetingMorning() , new GreetingAfternoon() , new GreetingEvening() };
            foreach(var greet in GreetList1)
            {
                greet.Greeting();
            }
        }
    }
}