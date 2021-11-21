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
            string SampleText = "Jackdaws love my big sphinx of quartz";
            Console.WriteLine($"対象:{SampleText}");
            int spacecount =  SampleText.Count( c => char.IsWhiteSpace(c));
            Console.WriteLine($"空白の数:{spacecount}");

            string replacetect = SampleText.Replace("big", "small");
            Console.WriteLine($"bigからsmall:{replacetect}");

            string[] words = SampleText.Split(" ");
            Console.WriteLine($"単語数:{words.Length}");
            string[] lessthan4words = words.Where(str => str.Length <= 4).ToArray();
            foreach(string str in lessthan4words)
            {
                Console.Write($"{str} ");
                Console.WriteLine();
            }

            var builder = new StringBuilder();
            foreach(string str in words)
            {
                builder.Append($"{str} ");
            }
            string copytext = builder.ToString().TrimEnd();

            Console.Write($"元のテキスト復元：{copytext}");
            Console.WriteLine();
            Console.WriteLine();

            string namae = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            Console.WriteLine(namae);
            string[] koumoku = namae.Split(";");
            foreach(string moku in koumoku)
            {
                int startindex = moku.IndexOf("=");
                string zokusei = moku.Substring(0, startindex);
                Console.WriteLine($"{zokusei}:{moku.Substring(startindex + 1)}");
            }

        }

    }
}

