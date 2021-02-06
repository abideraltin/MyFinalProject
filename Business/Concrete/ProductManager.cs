using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
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
            return _productDal.GetAll(p => p.CategoryId == v);
        }

        private static void NewMethod()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            //İş Kodları
            //Yetkisi var mı?

            return _productDal.GetAll();
        }

        public List<Product> GetAlllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}
