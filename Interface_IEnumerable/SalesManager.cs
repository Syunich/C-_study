using System;
using System.Collections.Generic;
using System.IO;

namespace CsStudy1
{

    /// <summary>
    /// セール型配列について扱う。戻り値をinterfaceにすることによって変更に対応できるようにする
    /// </summary>
    class SalesManager
    {
        //saleをIEnumarableとして定義しておけば，このクラス内の関数で一度決まったsalesが書き換えられてしまうことはない
        private IEnumerable<Sale> sales;

        public SalesManager(string path)
        {
            sales = GetSales(path);
        }

        /// <summary>
        /// salesメンバから店名と値段の組み合わせを返す
        /// </summary>
        /// <returns></returns>
        public IDictionary<string , int> GetPerStoreSales()
        {
            Dictionary<string , int> dict = new Dictionary<string, int>();
            foreach(Sale sale in sales)
            {
                if (dict.ContainsKey(sale.shopname))
                {
                    dict[sale.shopname] += sale.amount;
                }
                else
                {
                    dict.Add(sale.shopname, sale.amount);
                }
            }
            return dict;
        }

        /// <summary>
        /// salesメンバから商品名と値段の組み合わせを返す
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, int> GetPerProductSales()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in sales)
            {
                if (dict.ContainsKey(sale.productname))
                {
                    dict[sale.productname] += sale.amount;
                }
                else
                {
                    dict.Add(sale.productname, sale.amount);
                }
            }
            return dict;
        }

        private IEnumerable<Sale> GetSales(string path)
        {
            string[] allLine = File.ReadAllLines(path);
            List<Sale> sales = new List<Sale>();

            foreach (string line in allLine)
            {
                string[] item = line.Split(",");
                Sale sale = new Sale()
                {
                    shopname = item[0],
                    productname = item[1],
                    amount = int.Parse(item[2])
                };
                sales.Add(sale);
            }
            return sales;
        }

    }
}
