using System;
using System.Collections.Generic;
using System.Linq;

namespace CsStudy1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            List<int> testlist = new List<int>() { 1, 2, 3 };

            //where can use class which is inplemented IEnumerable.(need to using System.Linq)
            IEnumerable<int> nume = testlist.Where(n => n >= 2).Select(n => n * 2);
            var numer = nume.GetEnumerator();
            while(numer.MoveNext())
            {
                Console.WriteLine(numer.Current);
            }
        }

    }
}

