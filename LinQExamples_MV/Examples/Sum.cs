using LinQExamples_MV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples_MV.Examples
{
    class Sum
    {
        public void Linq1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            double numSum = numbers.Sum();

            Console.WriteLine("The sum of the numbers is {0}.", numSum);
        }
        public void Linq2()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            double totalChars = words.Sum(w => w.Length);

            Console.WriteLine("There are a total of {0} characters in these words.", totalChars);
        }

        public void Linq3()
        {

            var categories =
                from p in ProductList.productionList
                group p by p.Category into g
                select new { Category = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock) };

            foreach (var item in categories)
            {
                Console.WriteLine("Category " + item.Category + " - " + "TotalUnitsInStock " + item.TotalUnitsInStock);
            }
        }
    }
}
