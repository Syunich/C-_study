using System;

namespace Code1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            //called class
            Example example = new Example(3 , "hello");
            Console.WriteLine(example.name);
        }
    }
}
