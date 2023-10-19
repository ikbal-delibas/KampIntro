using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductName = "Elma";
            product1.ProductPrice = 15;
            product1.ProductComment = "Amasya Elması";

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.ProductName = "Çilek";
            product2.ProductPrice = 10;
            product2.ProductComment = "Çilek";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName);
            }
            Console.ReadLine();
        }
    }
}
