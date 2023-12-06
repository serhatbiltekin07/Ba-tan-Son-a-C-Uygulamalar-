using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodÖdev
{
    internal class Program
    {

        private static void züccaciye()
        {
            Console.WriteLine("Lütfen iki seçenekten birini seçiniz...");
            Console.WriteLine("Mutfak Gereçleri ise 1' e tıklayın:");
            Console.WriteLine("Oda Gereçleri ise 2' ye tıklayın:");
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                Console.WriteLine("Tencere Takımı");
            }
            else if (secim == 2)
            {
                Console.WriteLine("Yemek Takımı");
            }
            else
            {
                Console.WriteLine("Yanlış seçim");
            }
           
        }
        public static void vergiHesaplama(int fiyat, int adet)
        {
            double kdvOrani = 0.18;
            double vergi = fiyat * adet * kdvOrani;
            double toplamFiyat = fiyat * adet + vergi;
            Hediye(toplamFiyat);
        }

        public static void Hediye(double toplamFiyat)
        {
            if(toplamFiyat >= 100 && toplamFiyat < 1000)
            {
                Console.WriteLine("Hediye : % 10 indirim + ütü kazanıldı!");
            }
            else if (toplamFiyat >= 1000 && toplamFiyat <= 7800)
            {
                Console.WriteLine("Hediye : % 15 indirim + airfry kazanıldı!");
            }
            else if(toplamFiyat > 7800)
            {
                Console.WriteLine("Hediye : % 20 indirim + Dyson kazanıldı!");
            }
            else
            {
                Console.WriteLine("Hediye: İndirim veya hediye kazanılmadı.");
            }
        }

        static void Main(string[] args)
        {
            züccaciye();
            Console.WriteLine("Fiyat giriniz:");
            int fiyat = int.Parse(Console.ReadLine());

            Console.WriteLine("Adeti giriniz:");
            int adet = int.Parse(Console.ReadLine());

            vergiHesaplama(fiyat, adet);
            Console.ReadLine();
        }
    }
}
