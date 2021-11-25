using System;
using System.Collections.Generic;

namespace CsStudy1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            SalesManager salesmanager = new SalesManager("data1.txt");
            IDictionary<string, int> storesales = salesmanager.GetPerProductSales();

            foreach(var storesale in storesales)
            {
                Console.WriteLine($"{storesale.Key} : {storesale.Value} 円");
            }
        }
    }
}

