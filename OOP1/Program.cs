using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.ProductPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem",     ProductPrice = 60 };
            
            ProductManager productManager = new ProductManager(); // instance creation yapıldı
            productManager.Add(product1);
            product1.ProductName = "Kamera";
            Console.WriteLine(product1.ProductName);

            productManager.Topla2(3, 6);

            int toplamSonucu = productManager.Topla(3, 6); // Topla2 yazsak hata alırız çünkü o metot void değer döndürmüyor.

            Console.WriteLine(toplamSonucu * 2);


        }
    }
}
