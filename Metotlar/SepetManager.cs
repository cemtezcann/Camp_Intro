using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Ürün Sepete Eklendi :" + urun.UrunAdi);
        }

        public void Ekle2(string urunAdi , string aciklama , double fiyat , int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Ürün Sepete Eklendi : " + urunAdi +" " + aciklama + " " + " " + fiyat + " " + stokAdedi);
        }
    }
}
