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
        static void Main(string[] args)
        {
            //キー(任意型)と値(任意型)をセットで扱うクラス。キーから呼び出せる
            var SampleDict = new Dictionary<string, int>()
            {
                ["sunflower"] = 400,
                ["pansy"] = 300,
                ["tulip"] = 350,
                ["rose"] = 500,
                ["dahlia"] = 450,
            };

            //値を追加する方法① (キーが重複した場合は上書き)
            SampleDict["tanpopo"] = 200;

            //値を追加する方法② (キーが重複した場合はArgument Exeption発生)
            SampleDict.Add("cheryblossum", 390);

            //値を取得する方法 (キーが存在しなければKeyNotFoundExeptionが返るため、確認してから)
            if (SampleDict.ContainsKey("sunflower"))
            {
                int sunvalue = SampleDict["sunflower"];
            }

            //値を削除する方法 Removeは対応するキーとその値を削除する。キーが見つかった場合true,そうでなければfalseが返る
            SampleDict.Remove("cheryblossum");

            //Dictionaryでforeachを使う 各要素はKeyValuePair構造体で返ってくる
            //順番は登録した順ではないことに注意
            foreach (KeyValuePair<string, int> flower in SampleDict)
            {
                Console.WriteLine($"{flower.Key} : {flower.Value}");
            }

            //LINQも使用できる。ラムダ式の引数はforeachと同様にKeyValuePair型であり
            //チェインはIEnumerable<KeyValuePair<Key,Value>>で扱う
            double priceAv = SampleDict.Average(n => n.Value);

            //Ienumerable型からDictionaryに変換(要System.Linq)
            //この場合、n.nameがKeyとなりValueとしてSample型のnが入る
            //※別にkeyはstringに限らなくて良いし、そのクラスに依存しなくても良い
            //Dictionaryに変換
            var Samplelist = new List<Sample>()
            {
                new Sample("apple" , 100),
                new Sample("orange" , 60),
                new Sample("lemon" , 40)
            };

            var SampleDict2 = Samplelist.ToDictionary(n => n.name);
            foreach (var sample in SampleDict2)
            {
                Console.WriteLine($"{sample.Key} : {sample.Value.name}");
            }

            //Dictionaryから新しいDictionaryを作成
            var FromSampledict = SampleDict.ToDictionary(n => n.Key, n => n.Value);

            //自作クラスをキーとして扱う。キー側のクラスには以下2つのメソッドをoverrideする必要がある．
            //①Equals 参照型なので同値性で判断するために必要
            //②GetHascode
            var SampleasKeyDict = new Dictionary<Sample, string>()
            {
                [Samplelist[0]] = "APPLE",
                [Samplelist[1]] = "ORANGE",
                [Samplelist[2]] = "LEMON"
            };
            var point = new Sample("apple", 100);
            Console.WriteLine(SampleasKeyDict[point]);


        }
    }
}

