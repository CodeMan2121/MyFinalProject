using DataAccess.Abstract;
using Entities.Contcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{//InMemoryProductDal - Bellekteki Ürünleri alabileceğimiz veri erişim katmanı.
 //Yani bu klasör sahte veri tabanı gibi bir görev görür.Bellekteki veriyi kullanarak veri tabanı işlemi görür.
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;//global değişkenleri alt çizgi ile gösteririz.
                                //Constructor bellekten referans aldığı zaman çalışacak olan blok.
        public InMemoryProductDal()
        {//Burayı bir veri tabanından geliyormuş gibi simüle ediyoruz.
            _products = new List<Product> {//Fake Veri Tabanı Burası.
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15 },
                new Product{ProductId=1, CategoryId=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3 },
                new Product{ProductId=1, CategoryId=1, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2 },
                new Product{ProductId=1, CategoryId=1, ProductName="Klavye", UnitPrice=150, UnitsInStock=65 },
                new Product{ProductId=1, CategoryId=1, ProductName="Fare", UnitPrice=85, UnitsInStock=1 }
            };
        }

        public void Add(Product product)
        {//Business'dan gelen ürünü bu şekilde ekliyoruz.
            _products.Add(product);
        }

        public void Delete(Product product)
        {//Linq ile remove işlemi
            //Buradaki p bir takma ad. Tıpkı foreach'taki gibi değişkene verilen bir takma ad.
            //P takma adıyla tüm veri tabanını dolaş. Eğer productId'si veri tabanındaki productId'ye eşit bir ürün görürsen onu sil.
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {//Veri tabanındaki yani List<Product>'daki verileri business'a vermek için GetAll() metodunu kullanıyoruz.
            return _products;//Direkt List<Product>'ı verebilmek için sadece return ediyoruz.
        }

        public List<Product> GetAllByCategory(int categoryId)
        {//Veri tabanını CategoryId'ye göre listeliyor.
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {//Linq ile update işlemi
            //Gönderdiğim ürün id'sine sahip listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            
        }
    }
}
