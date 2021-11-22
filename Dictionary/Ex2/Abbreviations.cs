using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace CsStudy1
{
    /// <summary>
    /// 略語と対応する日本語を管理するクラス
    /// </summary>
    public class Abbreviations
    {
        private Dictionary<string, string> dict = new Dictionary<string, string>();

        public Abbreviations()
        { 
        }

        public Abbreviations(string filepass)
        {
            dict = GetDictFromFile(filepass);
        }

        //要素を追加(Keyがなければうわがき)
        public void Add(string abbr , string japanese)
        {
            dict[abbr] = japanese; 
        }

        public string ToAbbration(string japanese)
        {
            return dict.FirstOrDefault(x => x.Key == japanese).Key;
        }

        /// <summary>
        /// 指定した日本語名が入ってるペアを返す
        /// </summary>
        /// <param name="japanese"></param>
        /// <returns></returns>
        public IEnumerable<KeyValuePair<string, string>> FindAll(string japanese)
        {
            foreach(var item in dict)
            {
                if(item.Value.Contains(japanese))
                {
                    yield return item;
                }
            }
        }

        //インデクサ(添え字でアクセス可能)
        public string this[string abbr]
        {
            get { return dict.ContainsKey(abbr) ? dict[abbr] : null; }
        }

        /// <summary>
        /// ファイルから日本語名と読みの組み合わせ Dictionaryを入手する
        /// </summary>
        /// <param name="filepass">テキストが書いてあるファイル名</param>
        /// <returns></returns>
        private Dictionary<string , string> GetDictFromFile(string filepass)
        {
           string[] lines = File.ReadAllLines(filepass);
           return lines.Select(line => line.Split("=")).ToDictionary(pair => pair[0], pair => pair[1]);
        }



    }
}
