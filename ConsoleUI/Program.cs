﻿using Business.Concrete;
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
            ProductManager productManager = new ProductManager(new EfProductDal());
            var products = productManager.GetByUnitPrice(50,75);

            ConsoleTable.From(products).Write();
        }
    }
}