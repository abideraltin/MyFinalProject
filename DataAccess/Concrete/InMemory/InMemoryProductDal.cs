﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        private List<Product> _products;

        public InMemoryProductDal()
        {
            //Oracle, Sql Server, Postgres, MongoDb
            _products = new List<Product> {
                new Product{ProductID=1, CategoryID=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductID=2, CategoryID=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
                new Product{ProductID=3, CategoryID=2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductID=4, CategoryID=2, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
                new Product{ProductID=5, CategoryID=2, ProductName="Fare", UnitPrice=85, UnitsInStock=1},
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query
            //Lambda-> p=>
            Product productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID);

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün ıd'sine sahip olan ürün listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public List<Product> GetAllCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryID == categoryId).ToList();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}