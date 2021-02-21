using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategpryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategpryId = 5,
                UnitsInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 35
            };

            //PascalCase //camelCase
            //case senitive
            ProductManager productManager = new ProductManager();//101
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            

            // int , double,bool...değer tip
            //diziler,class, abstract class,interface... referans tip
            //ref out 
        }
    }
}
