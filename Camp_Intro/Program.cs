using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camp_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "matematik\n", "fizik\n", "kimya\n", "biyoloji\n" , "bilgisayar\n" };

            for ( int i = 0 ; i < kurslar.Length ; ++i )
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("sayfa sonu - footer");

            Console.WriteLine("for bitti hacı\n\n");
            Console.WriteLine("***************************************");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
        
    }
}
