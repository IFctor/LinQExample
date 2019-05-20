using LinQExamples_MV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples_MV.Examples
{
    class Join
    {
        public void Linq1()
        {

            string[] categories = new string[]{
        "Beverages",
        "Condiments",
        "Vegetables",
        "Dairy Products",
        "Seafood" };


            var q =
                from c in categories
                join p in ProductList.productionList on c equals p.Category
                select new { Category = c, p.ProductName };

            foreach (var v in q)
            {
                Console.WriteLine(v.ProductName + ": " + v.Category);
            }
        }
        public void Linq2()
        {
            string[] categories = new string[]{
        "Beverages",
        "Condiments",
        "Vegetables",
        "Dairy Products",
        "Seafood" };


            var q =
                from c in categories
                join p in ProductList.productionList on c equals p.Category into ps
                select new { Category = c, Products = ps };

            foreach (var v in q)
            {
                Console.WriteLine("____________________________________________");
                Console.WriteLine(v.Category + ":");
                foreach (var p in v.Products)
                {
                    Console.WriteLine("   " + p.ProductName);
                }
            }
        }
        public void Linq3()
        {
            string[] categories = new string[]{
        "Beverages",
        "Condiments",
        "Vegetables",
        "Dairy Products",
        "Seafood" };


            var q =
                from c in categories
                join p in ProductList.productionList on c equals p.Category into ps
                from p in ps.DefaultIfEmpty()
                select new { Category = c, ProductName = p == null ? "(No products)" : p.ProductName };

            foreach (var v in q)
            {
                Console.WriteLine(v.ProductName + ": " + v.Category);
            }
        }
        
    }
}
