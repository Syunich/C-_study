using System;
using System.Collections.Generic;
using System.Text;

namespace CsStudy1
{
    public class Sample
    {
        public int price { get; private set; }
        public string name { get; private set; }

        public Sample(string name = "Default" , int price = 0)
        {
            this.price = price;
            this.name = name;
        }

        //Dictionaryでキー側にするために必要なoverride

        public override bool Equals(object obj)
        {
            var other = obj as Sample;
            if(other == null)
            {
                throw new ArgumentException();
            }
            return this.price == other.price && this.name == other.name;

        }

        //hashxodeには31をかけるのが定石
        public override int GetHashCode()
        {
            return price.GetHashCode() * 31 + name.GetHashCode();
        }
    }
}
