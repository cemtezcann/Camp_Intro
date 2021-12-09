using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Ali";
            kurs1.IzlenmeOrani = 56;

            Kurs kurs2 = new Kurs();

            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Berkay Veli";
            kurs2.IzlenmeOrani = 72;

            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Komidin Bahattin";
            kurs3.IzlenmeOrani = 76;

            Console.WriteLine(kurs1.KursAdi + "-" + kurs1.Egitmen + "-" +kurs1.IzlenmeOrani);
            Console.WriteLine(kurs2.KursAdi + "-" + kurs2.Egitmen + "-" + kurs2.IzlenmeOrani);
            Console.WriteLine(kurs3.KursAdi + "-" + kurs3.Egitmen + "-" + kurs3.IzlenmeOrani);


            Kurs[] kurslar = new Kurs[] { kurs1 , kurs2 , kurs3};

            foreach (var kurs in kurslar)
            { 
                Console.WriteLine(kurs.KursAdi+ " " + kurs.Egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
