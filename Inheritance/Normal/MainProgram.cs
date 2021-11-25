using System;

namespace CsStudy1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(170, 60, 21, "syunich");

            // base <- sub   is ok. but base -> sub will make error.
            Person person2 = new Worker(170, 60, 21, "worker_syunichy" , 1);
            Worker worker1 = new Worker(170, 60, 21, "worker_unknown", 2);

            person1.IntroduceSelf();
            person2.IntroduceSelf();

            Console.WriteLine(person2.age);
            Console.WriteLine(worker1.workernumber);
        }
    }
}
