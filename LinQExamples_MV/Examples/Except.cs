using LinQExamples_MV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples_MV.Examples
{
    class Except
    {
        public void Linq1()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            IEnumerable<int> aOnlyNumbers = numbersA.Except(numbersB);

            Console.WriteLine("Numbers in first array but not second array:");
            foreach (var n in aOnlyNumbers)
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

            var productOnlyFirstChars = productFirstChars.Except(wordFirstChars);

            Console.WriteLine("First letters from Product names, but not from words:");
            foreach (var ch in productOnlyFirstChars)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
