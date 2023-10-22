namespace Task6
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<ItemProduct> products = new List<ItemProduct>();

            products.Add(new ItemProduct("Product 1", 49.99));
            products.Add(new ItemProduct("Product 2", 39.99));

            Console.WriteLine("Products:");
            foreach (var product in products)
            {
                Console.WriteLine(product.GetInfo());
            }

            Console.WriteLine($"Total number of products: {products.Count}");
        }
    }
}