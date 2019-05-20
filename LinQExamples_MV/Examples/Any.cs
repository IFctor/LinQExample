using LinQExamples_MV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples_MV.Examples
{
    class Any
    {
        public void Linq1()
        {
            string[] words = { "believe", "relief", "receipt", "field" };

            bool iAfterE = words.Any(w => w.Contains("ei"));

            Console.WriteLine("There is a word that contains in the list that contains 'ei': {0}", iAfterE);
        }
        public void Linq2()
        {
            var productGroups =
                from p in ProductList.productionList
                group p by p.Category into g
                where g.Any(p => p.UnitsInStock == 0)
                select new { Category = g.Key, Products = g };

            foreach (var item in productGroups)
            {
                Console.WriteLine("____________________________________");
                Console.WriteLine("Category " + item.Category);
                foreach (var prodItem in item.Products)
                {
                    Console.WriteLine("ProductName " + prodItem.ProductName + " - Stock " + prodItem.UnitsInStock);
                }
            }
        }
    }
}
