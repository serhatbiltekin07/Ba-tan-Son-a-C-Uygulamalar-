using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genel_uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bir komisyoncu sattığı mallardan fiyatı 50 tl ye kadar olanlardan %3,
            // daha fazla olanlardan %2 komisyon almaktadır.,
            //klavyeden girilen 5 malın komisyonlarını bulup ekrana yazdıran ve en sonunda TOPLAM KOMİSYONUN
            //yazan program.
             double dusukFiyat = 0.03;
             double yuksekFiyat = 0.02;
            double toplamKomisyon = 0;

            for (int i = 1; i <= 5; i++)
                {
                    Console.Write("Mal " + i + " Fiyatını girin: ");
                    double fiyat = Convert.ToDouble(Console.ReadLine());
                    double komisyon = 0;

                if (fiyat <= 50)
                    {
                        komisyon = fiyat * dusukFiyat;
                    }
                    else
                    {
                        komisyon = fiyat * yuksekFiyat;
                    }                  
                    toplamKomisyon += komisyon;
                Console.WriteLine("Mal " + i + " Komisyonu: " + komisyon);
            }
            Console.WriteLine("Toplam Komisyon : "  + toplamKomisyon);





            Console.ReadLine();
        }
    }
}
