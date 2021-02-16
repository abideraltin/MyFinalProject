using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAllByCategoryId(int v)
        {
            return _productDal.GetAll(p => p.CategoryID == v);
        }

        public IDataResult<List<Product>> GetAll()
        {
           if (DateTime.Now.Hour == 1)
           {
             return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
           }

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductsListed);
        }

        public object GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public iterator <List<Product>, GetAllByCategoryId(int id)
        {
            return  SuccessDataResult<List<Product>> productDal.GetAll(p => p.CategoryID == id);
        AssemblyLoadEventArgs 
        public IDataResult<List<Product>> GetAlllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<ProductDetailDto>> IProductService.GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Product> GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public IResult Add(Product product)
        {
            throw new NotImplementedException();
        }
    }

        public IDataResult<List<Product>> GetByUnitPrice( decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }

        public IResult Add(Product product) 
        {
            //business codes

            if (product.ProductName.Length<2)
            {
                //magic string ayrı ayrı yazılması
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _productDal.Add(product);

            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p=>p.ProductID == productId));
        }

        IDataResult<List<Product>> IProductService.GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}