using LinQExamples_MV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples_MV.Examples
{
    class Intersect
    {
        public void Linq1()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var commonNumbers = numbersA.Intersect(numbersB);

            Console.WriteLine("Common numbers shared by both arrays:");
            foreach (var n in commonNumbers)
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

            var commonFirstChars = productFirstChars.Intersect(wordFirstChars);

            Console.WriteLine("Common first letters from Product names and words:");
            foreach (var ch in commonFirstChars)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
