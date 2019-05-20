using LinQExamples_MV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples_MV.Examples
{
    class Union
    {

        public void Linq1()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var uniqueNumbers = numbersA.Union(numbersB);

            Console.WriteLine("Unique numbers from both arrays:");
            foreach (var n in uniqueNumbers)
            {
                Console.WriteLine(n);
            }
        }

        public void Linq2()
        {

            var productFirstChars =
                from p in ProductList.productionList
                select p.ProductName[0];
            string[] words = { "Bla-bla", "Things" };
            var wordFirstChars =
                from w in words
                select w[0];

            var uniqueFirstChars = productFirstChars.Union(wordFirstChars);

            Console.WriteLine("Unique first letters from Product names and words:");
            foreach (var ch in uniqueFirstChars)
            {
                Console.WriteLine(ch);
            }
        }

    }
}
