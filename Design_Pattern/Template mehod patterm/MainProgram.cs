using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using TextFileProcessor;

namespace CsStudy1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            TextProcessor.Run<LineCountProcessor>("TextFile1.txt");
        }
    }

    //3つのロジックを書けばあとは元クラスがやってくれる。
    class LineCountProcessor : TextProcessor
    {
        private int _count;
        protected override void Initialize(string Filename)
        {
            _count = 0;
        }
        protected override void Execute(string line)
        {
            _count++;
        }

        protected override void Terminate()
        {
            Console.WriteLine("行数:{0}", _count);
        }
    }


}