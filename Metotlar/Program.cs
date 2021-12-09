using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();

            urun1.Id = 1001;
            urun1.UrunAdi = "Elma";
            urun1.Fiyati = 15.5;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();

            urun2.Id = 1002;
            urun2.UrunAdi = "Kiraz";
            urun2.Fiyati = 9.5;
            urun2.Aciklama = "Afyon Kirazı";
            urun2.StokAdedi = 15;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Id + "-" + urun.UrunAdi + "-" + urun.Fiyati + "-" + urun.Aciklama + " " +urun.StokAdedi);
            }

            Console.WriteLine("---------------------METOTLAR---------------------------");
            // instance oluşturuyoruz...class örneği
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("Armut" , "Ankara Armudu" , 12 , 12);
            sepetmanager.Ekle2("Karpuz" , "Adana Karpuzu" , 15 , 18);
            sepetmanager.Ekle2("Çilek", "Emiralem Çileği" , 19 , 15);

        }
    }
}
