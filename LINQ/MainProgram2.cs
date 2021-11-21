using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace CsStudy1
{
    //LINQを使ってnumsを操作
    class MainProgram
    {
        static readonly int[] nums = { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
        static void Main(string[] args)
        {
            //配列の最大値を求める
            int maxvalue = nums.Max();

            //最後の2つの要素を取り出す(LINQでかける?)
            var lest2nums = nums.Reverse().Take(2);

            //数列を文字列に変換
            var numsstr = nums.Select(n => n.ToString());

            //昇順に並べて、そこから３つとってくる
            var less3num = nums.OrderBy(n => n).Take(3);

            //重複を削除して、10より大きい値をカウント
            int overten = nums.Distinct().Count(n => n > 10);


            Console.WriteLine(maxvalue);
            lest2nums.ToList().ForEach(Console.WriteLine);
            numsstr.ToList().ForEach(Console.WriteLine);
            less3num.ToList().ForEach(Console.WriteLine);
            Console.WriteLine(overten);
        }

    }
}

