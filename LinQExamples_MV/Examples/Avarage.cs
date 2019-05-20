using LinQExamples_MV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples_MV.Examples
{
    class Avarage
    {
        public void Linq1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            double averageNum = numbers.Average();

            Console.WriteLine("The average number is {0}.", averageNum);
        }

        public void Linq2()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            double averageLength = words.Average(w => w.Length);

            Console.WriteLine("The average word length is {0} characters.", averageLength);
        }
        public void Linq3()
        {
            var categories =
                from p in ProductList.productionList
                group p by p.Category into g
                select new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) };

            foreach (var item in categories)
            {
                Console.WriteLine("Category " + item.Category + " - " + "AveragePrice " + item.AveragePrice);
            }
        }
       
    }
}
