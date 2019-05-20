using LinQExamples_MV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples_MV.Examples
{
    class Concat
    {

        public void Linq1()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var allNumbers = numbersA.Concat(numbersB);

            Console.WriteLine("All numbers from both arrays:");
            foreach (var n in allNumbers)
            {
                Console.WriteLine(n);
            }
        }
        public void Linq2()
        {
            string[] otherList = {
                "oLitem0",
                "oLitem1",
                "oLitem2",
                "oLitem3",
                "oLitem4",
                "oLitem5",
                "oLitem6",
                "oLitem7",
                "oLitem8",
                "oLitem9" };
            
            var productNames =
                from p in ProductList.productionList
                select p.ProductName;

            var allNames = otherList.Concat(productNames);

            Console.WriteLine("otherList and product names:");
            foreach (var n in allNames)
            {
                Console.WriteLine(n);
            }
        }
    }
}
