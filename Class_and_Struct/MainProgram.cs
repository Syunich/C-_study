using System;

namespace CsStudy1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            //struct is a value type. and class is a reference type.
            //show deference between two.

            Myclass myclass1 = new Myclass(1 , "Hello");
            Mystruct mystruct1 = new Mystruct(1, "Hello");

            Myclass myclass2 = myclass1;
            myclass2.intvalue = 2;

            Mystruct mystruct2 = mystruct1;
            mystruct2.intvalue = 2;

            //myclass2 has a myclass1's adress. so myclass1 and myclass2 has "intvalue" which value is 2.
            Console.WriteLine($"{myclass1.intvalue},{myclass2.intvalue}");

            //mystruct2 has a only value of myclass1. so these "intvalue" returns defferent value.
            Console.WriteLine($"{mystruct1.intvalue},{mystruct2.intvalue}");
        }
    }
}
