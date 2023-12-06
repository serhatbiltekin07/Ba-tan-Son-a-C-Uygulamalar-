using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TCNO, OgrenciNo, AdSoyad, Not, Burs Değikenlerimiz
            //TC no 11 haneli, OgrenciNo 4 haneli, not girişi için 0-100 arası rakam 
            //girebilsin.
            //burs metodu 80 - 100 arasına +500 burs
            //hediye metodu Total burs >  750 macbook kazandınız değilse asus
            //geriye değer döndürmeyen metod kullanılacak.
            Console.WriteLine("Seçimibizi yapınız:");
            Console.WriteLine("1- İlkokul");
            Console.WriteLine("2- Lise");
            Console.WriteLine("3 Üniversite");

            int secim=Convert.ToInt32(Console.ReadLine());
            if(secim == 1)
            {
                Ogrenciler ogrenciler = new Ogrenciler();
                Console.WriteLine("Tc No giriniz:");
                ogrenciler.TcNo = Console.ReadLine();
                Console.WriteLine("Öğrenci No giriniz:");
                ogrenciler.OgrenciNo = Console.ReadLine();
                Console.WriteLine("Öğrenci Adı Soyadı giriniz:");
                ogrenciler.AdSoyad = Console.ReadLine();
                Console.WriteLine("Öğrenci notu giriniz:");
                ogrenciler.Not = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Öğrenci bursu giriniz:");
                ogrenciler.burs= Convert.ToInt32(Console.ReadLine()); 
                
                Console.Clear();

                Console.WriteLine("Tc No= " + ogrenciler.TcNo);
                Console.WriteLine("Öğrenci no= " + ogrenciler.OgrenciNo);
                Console.WriteLine("Öğreni adı soyadı= " + ogrenciler.AdSoyad);
                Console.WriteLine("Öğrenci not= " + ogrenciler.Not);
                Console.WriteLine("Öğrenci burs= " + ogrenciler.burs);

                int totalburs = ogrenciler.BursVer(ogrenciler.Not, ogrenciler.burs);
                Console.WriteLine("Burs =" + totalburs);
                ogrenciler.Hediye(totalburs);


            }
            else if (secim == 2)
            {
                Ogrenciler ogrenciler = new Ogrenciler();
                Console.WriteLine("Tc No giriniz:");
                ogrenciler.TcNo = Console.ReadLine();
                Console.WriteLine("Öğrenci No giriniz:");
                ogrenciler.OgrenciNo = Console.ReadLine();
                Console.WriteLine("Öğrenci Adı Soyadı giriniz:");
                ogrenciler.AdSoyad = Console.ReadLine();
                Console.WriteLine("Öğrenci notu giriniz:");
                ogrenciler.Not = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Öğrenci bursu giriniz:");
                ogrenciler.burs = Convert.ToInt32(Console.ReadLine());

                Console.Clear();


                Console.WriteLine("Tc No= " + ogrenciler.TcNo);
                Console.WriteLine("Öğrenci no= " + ogrenciler.OgrenciNo);
                Console.WriteLine("Öğreni adı soyadı= " + ogrenciler.AdSoyad);
                Console.WriteLine("Öğrenci not= " + ogrenciler.Not);
                Console.WriteLine("Öğrenci burs= " + ogrenciler.burs);

                int totalburs = ogrenciler.BursVer(ogrenciler.Not, ogrenciler.burs);
                Console.WriteLine("Burs =" +  totalburs);
                ogrenciler.Hediye(totalburs);


            }

            Console.ReadLine();

        }
    }
}
