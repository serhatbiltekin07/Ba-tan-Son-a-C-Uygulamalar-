using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            insan insan1 = new insan();
            insan1.adsoyad = "Biltekin Kurtuluş";
            insan1.sehir = "İstanbul";
            insan1.adres = "Kartal";
            insan1.kilo = 50;

            Console.WriteLine("Ad Soyad :" + insan1.adsoyad);
            Console.WriteLine("Şehir:" + insan1.sehir);

            Console.ReadLine();

        }
    }
}
