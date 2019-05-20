using LinQExamples_MV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples_MV.Examples
{
    class All
    {
        public void Linq1()
        {
            int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };

            bool onlyOdd = numbers.All(n => n % 2 == 1);

            Console.WriteLine("The list contains only odd numbers: {0}", onlyOdd);
        }

        /// <summary>
        /// All in category
        /// </summary>
        public void Linq2()
        {
            var productGroups =
                from p in ProductList.productionList
                group p by p.Category into g
                where g.All(p => p.UnitsInStock > 0)
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
