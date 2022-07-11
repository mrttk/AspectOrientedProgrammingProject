using Business.Concrete;
using ConsoleTables;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            var products = productManager.GetAll();

            ConsoleTable.From(products).Write();

            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine($"Product Id: {product.ProductId} | Product Name: {product.ProductName} | Unit Price: {product.UnitPrice} | Units In Stock: {product.UnitsInStock}");
            //}
        }
    }
}
