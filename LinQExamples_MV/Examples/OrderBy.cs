using ConsoleTables;
using LinQExamples_MV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples_MV.Examples
{
    class OrderBy
    {

        /// <summary>
        /// Order by ProductName
        /// </summary>
        public void Linq1()
        {
            List<Product> shortedProducts = ProductList.productionList.OrderBy(p => p.ProductName).ToList();
            Console.WriteLine("Order by ProductName");
            var table = new ConsoleTable("Name", "Unit Price", "Unit in stock");

            foreach (var product in shortedProducts)
            {
                table.AddRow(product.ProductName, product.UnitPrice, product.UnitsInStock);
            }
            table.Write();
        }
        public void Linq2()
        {
            //--- original linQ ---
            var shortedProducts = from p in ProductList.productionList orderby p.ProductName.Length select p;

            //--- With labda exp ---
            //List<Product> shortedProducts = db.Products.OrderBy(p => p.ProductName.Length).ToList();
            
            Console.WriteLine("Order by ProductName (by lenght)");
            var table = new ConsoleTable("Name", "Unit Price", "Unit in stock");

            foreach (var product in shortedProducts)
            {
                table.AddRow(product.ProductName, product.UnitPrice, product.UnitsInStock);
            }
            table.Write();
        }


        public void Linq3()
        {
            string[] words = { "aPPLE", "ApPLe", "APple", "apPlE", "apple", "APPLE" };

            var sortedWordsNonCaseSensitive = words.OrderByDescending(a => a, new CaseInsensitiveComparer());
            var sortedWordsCaseSensitive = words.OrderByDescending(a => a);
            
            var ctopt = new ConsoleTableOptions().EnableCount = false;

            var table = new ConsoleTable("Words case Sensitive (desc)");
            foreach (var word in sortedWordsCaseSensitive)
            {
                table.AddRow(word);
            }
            table.Write();

            table = new ConsoleTable("Words non case sensitive (desc) original array (desc)");
            foreach (var word in sortedWordsNonCaseSensitive)
            {
                table.AddRow(word);
            }
            table.Write();
        }

        /// <summary>
        /// This sample uses Reverse to create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
        /// </summary>
        public void Linq4()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var reversedIDigits = (
                from d in digits
                where d[1] == 'i'
                select d)
                .Reverse();

            Console.WriteLine("A backwards list of the digits with a second character of 'i':");
            foreach (var d in reversedIDigits)
            {
                Console.WriteLine(d);
            }

        }

    }
}
