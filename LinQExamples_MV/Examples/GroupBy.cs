using LinQExamples_MV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples_MV.Examples
{
    class GroupBy
    {
        /// <summary>
        /// This sample uses group by to partition a list of numbers by their remainder when divided by 5.
        /// </summary>
        public void Linq1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numberGroups =
                from n in numbers
                group n by n % 5 into g
                select new { Remainder = g.Key, Numbers = g };

            foreach (var g in numberGroups)
            {
                Console.WriteLine("Numbers with a remainder of {0} when divided by 5:", g.Remainder);
                foreach (var n in g.Numbers)
                {
                    Console.WriteLine(n);
                }
            }
        }
        /// <summary>
        /// This sample uses group by to partition a list of words by their first letter.
        /// </summary>
        public void Linq2()
        {
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

            var wordGroups =
                from w in words
                group w by w[0] into g
                select new { FirstLetter = g.Key, Words = g };

            foreach (var g in wordGroups)
            {
                Console.WriteLine("Words that start with the letter '{0}':", g.FirstLetter);
                foreach (var w in g.Words)
                {
                    Console.WriteLine(w);
                }
            }
        }
        public void Linq3()
        {
            var orderGroups =
                from p in ProductList.productionList
                group p by p.Category into g
                select new { Category = g.Key, Products = g };

            foreach (var p in orderGroups)
            {
                Console.WriteLine("Products in the '{0}' category:", p.Category);
                foreach (var w in p.Products)
                {
                    Console.WriteLine(w.ProductName);
                }
            }
        }
    }
}
