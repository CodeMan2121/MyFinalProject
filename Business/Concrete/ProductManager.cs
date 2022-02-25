using Business.Abstract;
using DataAccess.Abstract;
using Entities.Contcrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        //Injection
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }


        public List<Product> GetAll()
        {
            //İş(business) kodları
            return _productDal.GetAll();
        }
    }
}
