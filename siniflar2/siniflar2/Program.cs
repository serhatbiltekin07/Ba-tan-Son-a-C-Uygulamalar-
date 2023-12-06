using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siniflar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Araba adlı clasta arabano, arabaadi, motorgucu, vitesdr, fiyat, otv alanları tanımla
            //arabano 6 haneli,  motorgucu 1000 - 2000 arasında değer alacak, vitesdr manuel
            // ya da otomatik , arabanın fiyatı 300000- 1000000 arasında olacak otv oranı 10-60
            //OtvHesapla metod fiyat ve otv parametreleri kullanılacak
            //Kasko metod - kosko istenirse kasko fiyatı 15000 değilse 10000 sgk ödemesi yapmanız gerekiyor

            Console.WriteLine("Seçiminizi yapınız \n1-Otomobil\n2- Servis Araçları");
            int secim = Convert.ToInt32(Console.ReadLine());
            if(secim == 1)
            {
                Araba arb1 = new Araba();
                Console.WriteLine("Araç Nosu Giriniz:");
                arb1.ArabaNo= Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Araç Adı Giriniz:");
                arb1.Arabaadi =Console.ReadLine();

                Console.WriteLine("Motor Gücü Giriniz:");
                arb1.ArabaNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Vites Türünü Giriniz:");
                arb1.VitesDr= Console.ReadLine();

                Console.WriteLine("Fiyat Giriniz:");
                arb1.Fiyat = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Otv oranını Giriniz:");
                arb1.OTV = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("Araç no :" + arb1.ArabaNo);
                Console.WriteLine("Araç Adı :" + arb1.Arabaadi);
                Console.WriteLine("Motor Gücü :" + arb1.Motorgucu);
                Console.WriteLine("Vites Türü :" + arb1.VitesDr);
                Console.WriteLine("Araba Fiyatı:" + arb1.Fiyat);

                int otvlifiyat = arb1.OtvHesapla(arb1.Fiyat, arb1.OTV);
                Console.WriteLine("Vergili Fiyat = " + arb1.Vergi(otvlifiyat)); 
            }
        }
    }
}
