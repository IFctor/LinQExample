using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples_MV.Examples
{
    class Interestings
    {
        /// <summary>
        /// Deferred Execution
        /// </summary>
        public void Linq1()
        {

            int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int i = 0;
            var q =
                from n in numbers
                select ++i;
            
            foreach (var v in q)
            {
                Console.WriteLine("v = {0}, i = {1}", v, i);
            }
        }
        /// <summary>
        /// Immediate Execution
        /// </summary>
        public void Linq2()
        {
            int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int i = 0;
            var q = (
                from n in numbers
                select ++i)
                .ToList();
            
            foreach (var v in q)
            {
                Console.WriteLine("v = {0}, i = {1}", v, i);
            }
        }
        /// <summary>
        /// The following sample shows how, because of deferred execution, queries can be used again after data changes and will then operate on the new data.
        /// </summary>
        public void Linq3()
        {
            int[] numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var lowNumbers =
                from n in numbers
                where n <= 3
                select n;

            Console.WriteLine("First run numbers <= 3:");
            foreach (int n in lowNumbers)
            {
                Console.WriteLine(n);
            }

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = -numbers[i];
            }
            
            Console.WriteLine("Second run numbers <= 3:");
            foreach (int n in lowNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
