using LinQExamples_MV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples_MV.Examples
{
    class Min
    {
        public void Linq1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int minNum = numbers.Min();

            Console.WriteLine("The minimum number is {0}.", minNum);
        }

        public void Linq2()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            int shortestWord = words.Min(w => w.Length);

            Console.WriteLine("The shortest word is {0} characters long.", shortestWord);
        }

        public void Linq3()
        {

            var categories =
                from p in ProductList.productionList
                group p by p.Category into g
                select new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice)};

            foreach (var item in categories)
            {
                Console.WriteLine("Category " + item.Category + " - " + "CheapestPrice " + item.CheapestPrice);
            }
        }
        public void Linq4()
        {

            var categories =
                from p in ProductList.productionList
                group p by p.Category into g
                let minPrice = g.Min(p => p.UnitPrice)
                select new { Category = g.Key, CheapestProducts = g.Where(p => p.UnitPrice == minPrice)};


            foreach (var item in categories)
            {
                Console.WriteLine("Category " + item.Category + " - " + "CheapestProducts " + item.CheapestProducts.First().ProductName + " - " + "Price " + item.CheapestProducts.First().UnitPrice);
            }
        }
    }
}
