using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace CsStudy1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            //使う側
            var testab = new Abbreviations("TextFile1.txt");
            testab.Add("IEEE", "アイトリプルイー");
            var in_O = testab.FindAll("機構");
            foreach(var item in in_O)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}

