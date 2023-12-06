using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_ornek4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //random dongu if kullan
            // 7 tane 10 ile 100 arasında random değer üreten ve 
            // üretilen değerlerin  2 ve 7 ye bölünenlerin adedini veren program olsun

            Random tahmin = new Random();
            int adet = 0;

            for(int i = 0; i < 7; i++)
            {
                int sayi = tahmin.Next(10, 100);
                Console.WriteLine(sayi);

                if(sayi % 2 == 0 && sayi % 7 == 0)
                {
                    adet++;
                }
            }
            Console.WriteLine(adet + "tane 2 ve 7  ile  bölünen sayı var!!!");
            Console.ReadLine();
        }
    }
}
