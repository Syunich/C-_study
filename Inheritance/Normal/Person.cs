using System;
using System.Collections.Generic;
using System.Text;

namespace CsStudy1
{
    public class Person
    {
        public int height { get; private set; }
        public int weight { get; private set; }
        public int age { get; private set; }
        public string name { get; private set; }

        public Person(int height , int weight , int age , string name )
        {
            this.height = height;
            this.weight = weight;
            this.age = age;
            this.name = name;
        }

        public void IntroduceSelf()
        {
            Console.WriteLine($"Hello, my name is {this.name}");
        }
    }
}
