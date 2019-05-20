using ConsoleTables;
using LinQExamples_MV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples_MV.Examples
{
    class Where
    {
        /// <summary>
        /// In-stock products
        /// </summary>
        public void Linq1()
        {
            List<Product> prodsInStock= ProductList.productionList.Where(p => p.UnitsInStock>0).ToList();
            Console.WriteLine("In-stock products");
            var table = new ConsoleTable("Name", "Unit Price", "Unit in stock");

            foreach (var product in prodsInStock)
            {
                table.AddRow(product.ProductName, product.UnitPrice, product.UnitsInStock);
            }
            table.Write();
        }
    }
}
