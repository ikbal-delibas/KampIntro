using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitePrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product()
            {
                Id = 1,
                CategoryId = 2,
                ProductName = "Masa",
                UnitePrice = 500,
                UnitsInStock = 3
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
