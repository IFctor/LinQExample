using LinQExamples_MV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples_MV.Examples
{
    class Max
    {
        public void Linq1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int maxNum = numbers.Max();

            Console.WriteLine("The maximum number is {0}.", maxNum);
        }

        public void Linq2()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            int longestLength = words.Max(w => w.Length);

            Console.WriteLine("The longest word is {0} characters long.", longestLength);
        }

        public void Linq3()
        {
            var categories =
                from p in ProductList.productionList
                group p by p.Category into g
                select new { Category = g.Key, MostExpensivePrice = g.Max(p => p.UnitPrice) };

            foreach (var item in categories)
            {
                Console.WriteLine("Category " + item.Category + " - " + "MostExpensivePrice " + item.MostExpensivePrice);
            }
        }
        public void Linq88()
        {
            var categories =
                from p in ProductList.productionList
                group p by p.Category into g
                let maxPrice = g.Max(p => p.UnitPrice)
                select new { Category = g.Key, MostExpensiveProducts = g.Where(p => p.UnitPrice == maxPrice) };

            foreach (var item in categories)
            {
                Console.WriteLine("Category " + item.Category + " - " + "MostExpensiveProducts " + item.MostExpensiveProducts.First().ProductName + " - " + "Price " + item.MostExpensiveProducts.First().UnitPrice);
            }
        }
    }
}
