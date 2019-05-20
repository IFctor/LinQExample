using LinQExamples_MV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples_MV.Examples
{
    class Count
    {
        /// <summary>
        /// This sample uses Count to get the number of odd ints in the array.
        /// </summary>
        public void Linq1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int oddNumbers = numbers.Count(n => n % 2 == 1);

            Console.WriteLine("There are {0} odd numbers in the list.", oddNumbers);
        }
        public void Linq2()
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };

            int uniqueFactors = factorsOf300.Distinct().Count();

            Console.WriteLine("There are {0} unique factors of 300.", uniqueFactors);
        }
        public void Linq3()
        {
            var categoryCounts =
                from p in ProductList.productionList
                group p by p.Category into g
                select new { Category = g.Key, ProductCount = g.Count() };

            foreach (var item in categoryCounts)
            {
                Console.WriteLine("Category " + item.Category + " - " + "Count " + item.ProductCount);
            }

        }
    }
}
