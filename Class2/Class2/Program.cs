using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //öğrenciler adında class oluşturulacak
            //orgno, adsoyad, ortalama, adres
            // Burs adında method oluştur(mühendislik bölümde tübitak 5000 tl burs veriyor)
            ogrenciler ogrenciler1 = new ogrenciler();

            Console.WriteLine("Öğrenci Numarasını Giriniz:");
            ogrenciler1.orgno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ad Soyad:");
            ogrenciler1.adsoyad = 
                (Console.ReadLine());
            Console.WriteLine("Adres Giriniz:");
            ogrenciler1.adres =Console.ReadLine();
            Console.WriteLine("Ortalama Notunu Giriniz:");
            ogrenciler1.ortalama = Convert.ToInt32((Console.ReadLine()));

            Console.Clear();

            Console.WriteLine("-----------Öğrenci Bilgileri--------");
            Console.WriteLine("Öğrenci Numarası :" + ogrenciler1.orgno);
            Console.WriteLine("Ad Soyad :" + ogrenciler1.adsoyad);
            Console.WriteLine("Adres :" + ogrenciler1.adres);
            Console.WriteLine("Öğrenci Ortalaması :" + ogrenciler1.ortalama);

            ogrenciler1.Burs();

            Console.ReadLine();
        }
    }
}
