using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>{
                new Product{ProductId =1, CategoryId =1, ProductName = "Glass", UnitPrice = 15,UnitsInStock=15},
                new Product{ProductId =2, CategoryId =1, ProductName = "Camera", UnitPrice = 500,UnitsInStock=3},
                new Product{ProductId =3, CategoryId =1, ProductName = "Phone", UnitPrice = 1500,UnitsInStock=2},
                new Product{ProductId =4, CategoryId =2, ProductName = "Keyboard", UnitPrice = 150,UnitsInStock=65},
                new Product{ProductId =5, CategoryId =2, ProductName = "Mouse", UnitPrice = 85,UnitsInStock=1}
            };
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> predicate = null)
        {
            //return predicate == null
            //    ? _products
            //    : _products.Where(predicate).ToList();
            return null;
        }

        public Product Get(Expression<Func<Product, bool>> predicate)
        {
            //return _products.SingleOrDefault(predicate);
            return null;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }
    }
}
