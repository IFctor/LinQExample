using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExamples_MV.Models
{
    class ProductList
    {
        static Random rnd = new Random();

        /// <summary>
        /// Add product list with random Price and Stock
        /// </summary>
        public static List<Product> productionList = new List<Product>() {
             new Product { ProductName = "Apple", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Fruit" },
                  new Product { ProductName = "Pear", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Fruit" },
                  new Product { ProductName = "Watermelon", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Fruit" },
                  new Product { ProductName = "Pineapple", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Fruit" },
                  new Product {  ProductName = "Nectarine", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Fruit" },
                  new Product { ProductName = "Blueberry", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Fruit" },
                  new Product {  ProductName = "Pomegranate", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Fruit" },
                  new Product {  ProductName = "Grapefruit", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Fruit" },

                  new Product { ProductName = "Cheese", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Dairy Products" },
                  new Product { ProductName = "Cream", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Dairy Products" },
                  new Product { ProductName = "Ice cream", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Dairy Products" },
                  new Product { ProductName = "Kefir", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Dairy Products" },
                  new Product { ProductName = "Milk", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Dairy Products" },
                  new Product { ProductName = "Powdered milk", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Dairy Products" },
                  new Product { ProductName = "Processed cheese", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Dairy Products" },
                  new Product { ProductName = "Quark", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Dairy Products" },
                  new Product { ProductName = "Yogurt", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Dairy Products" },


                  new Product { ProductName = "Peas", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Vegetable" },
                  new Product { ProductName = "Cabbage", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Vegetable" },
                  new Product { ProductName = "Broccoli", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Vegetable" },
                  new Product { ProductName = "Onion", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Vegetable" },
                  new Product { ProductName = "Garlic", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Vegetable" },

                  new Product { ProductName = "Lavender", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Condiments" },
                  new Product { ProductName = "Oregano", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Condiments" },
                  new Product { ProductName = "Parsley", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Condiments" },
                  new Product { ProductName = "Chamomile", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Condiments" },
                  new Product { ProductName = "Cabbage", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Condiments" },
                  new Product { ProductName = "Basil", UnitsInStock = rnd.Next(0,10), UnitPrice = rnd.NextDouble()*rnd.Next(1,10)+1, Category = "Condiments" }
        };
    }
}
