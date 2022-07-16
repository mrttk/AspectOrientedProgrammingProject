using Business.Concrete;
using ConsoleTables;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CategoryTest();
            ProductTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            var categories = categoryManager.GetAll();

            if (categories.Success)
                ConsoleTable.From(categories.Data).Write();
            else
                Console.WriteLine(categories.Message);
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));
            var products = productManager.GetProductDetails();

            if (products.Success)
                ConsoleTable.From(products.Data).Write();
            else
                Console.WriteLine(products.Message);
        }
    }
}
