using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Ali", "Mert" };
                  
            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Ali", "Mert" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Cansu");
            Console.WriteLine(isimler2[4]);

            foreach (string isim in isimler2)
            {
                Console.WriteLine( isim);
            }

        }
    }
}
