using System;
using System.Collections.Generic;
using System.Text;

namespace CsStudy1
{
    class GreetingMorning : IGreeting
    { 
        public string GetMessage()
        {
            return "Good Morning";
        }

        public void Greeting()
        {
            Console.WriteLine(GetMessage());
        }
    }

    class GreetingAfternoon : IGreeting
    {
        public string GetMessage()
        {
            return "Good Afternoon";
        }
        public void Greeting()
        {
            Console.WriteLine(GetMessage());
        }
    }

    class GreetingEvening : IGreeting
    {
        public string GetMessage()
        {
            return "Good Evening";
        }
        public void Greeting()
        {
            Console.WriteLine(GetMessage());
        }
    }

    //インターフェース。ロジックはかけない
    interface IGreeting
    {
        public string GetMessage();
        public void Greeting();

    }

}
