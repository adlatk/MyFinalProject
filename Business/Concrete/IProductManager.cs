using Business.Abstract;
using DataAcces.Abstract;
using DataAcces.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{

    public class ProductManager : IProductService
    {
        IProductDal _IProductDal;

        public ProductManager()
        {
        }

        public ProductManager(IProductDal ıProductDal)
        {
            _IProductDal = ıProductDal;
        }

        public List<Product> GetAll()
        {
            return _IProductDal.GetAll();
        }

        List<Product> IProductService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
