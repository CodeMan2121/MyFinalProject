using Entities.Contcrete;//Entites katmanına erişebilmek için bunu yazdık, Referansını almak için.GetAll() ile Entities'deki verileri getir.
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{//IProductDal = Product - product veri tabanını kullan demek. Dal ise Data Access layer - veri erişim katmanı. I - Interface demek zaten.
    public interface IProductDal
    {
        List<Product> GetAll();//Entities Product.cs'deki verileri getir ve listele anlamına gelir.

        void Add(Product product);

        void Update(Product product);

        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId); 

    }
}
