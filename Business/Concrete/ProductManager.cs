using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

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
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult();
            }

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), true,"Ürünler listelendi");
        }

        public List<Product> GetAlllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryID == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new System.NotImplementedException();
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

        public Product GetById(int productId)
        {
            return _productDal.Get(p=>p.ProductID == productId);
        }

        IDataResult<List<Product>> IProductService.GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}