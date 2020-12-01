using System;
using System.Collections.Generic;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {

            Product pen = new Product() {price=15,id="1",name="pen" };
            Product pencil = new Product() { price = 19, id = "2", name = "pencil" };
            Product paper = new Product() { price = 25, id = "3", name = "paper" };
            Product mobile = new Product() { price = 5, id = "4", name = "mobile" };
            Product laptop = new Product() { price = 115, id = "5", name = "laptop" };

            List<Product> Products = new List<Product>()
            {
                pen,pencil,paper,mobile,laptop
            };
            Product[] SortedProduct = Products.ToArray();
             SortDotNet<Product>.Sort(SortedProduct, SortType.Quick, SortOrder.Ascending);
            foreach(Product product in SortedProduct)
            {
                Console.WriteLine(product.name);
                Console.WriteLine(product.price);

            }

            Console.ReadLine();
        }
    }
}