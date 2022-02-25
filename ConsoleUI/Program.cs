using Business.Concrete;
using DataAccess.Concrete.EntityFamework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {//InMemoryProductDal ile bellekteki veri tabanını baz alırız.EfProduct ise bir veri tabanıdır.Bu sistem ile tek bir işlemde
        // veri tabanı için farklı alternatifler kullanabiliyoruz.

            //ProductManager productManager = new ProductManager(new EfProductDal());

            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

        }
    }

    
}
