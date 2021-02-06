using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADO.NET >> Veri tabanına bağlanmamızı ve kontrol etmemizi sağlayan bir kütüphanedir. Günümüzde kullanımı azalmıştır.
            //Entity Framework --Bir ORM -Object Relational mapping >>Günümüzde daha çok bunlar kullanılmaktadır.
            //NHibernate--Alternatif


            GetProductsByCategory(1);
            //GetAll();
        }

        private static void GetAll()
        {
            NorthwindContext context = new NorthwindContext();

            foreach (var product in context.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetProductsByCategory(int categoryid)
        {
            NorthwindContext context = new NorthwindContext();

            var result = context.Products.Where(p => p.CategoryId == categoryid);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

        }
    }
}
