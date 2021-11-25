using System;
using System.Collections.Generic;
using System.Text;

namespace CsStudy1
{
    class GreetingMorning : GreetingBase
    { 
        public override string GetMessage()
        {
            return "Good Morning";
        }
    }

    class GreetingAfternoon : GreetingBase
    {
        public override string GetMessage()
        {
            return "Good Afternoon";
        }
    }

    class GreetingEvening : GreetingBase
    {
        public override string GetMessage()
        {
            return "Good Evening";
        }
    }

    //抽象クラス。ロジックを書くことが可能
    public class GreetingBase
    {
        public virtual string GetMessage()
        {
            return "Good Base";
        }

        public void Greeting()
        {
            Console.WriteLine(GetMessage());
        }
    }

}
