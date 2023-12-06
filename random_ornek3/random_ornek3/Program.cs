using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //üretilen 10 random sayının toplamını bulun
            //10 ile 50 aralığında random sayı üretsin
            Random sayi = new Random();
            int toplam = 0;

            for(int i= 0; i < 10; i++)
            {
                int rastgele = sayi.Next(10, 51);
                Console.WriteLine("Rastgele sayı " + (i + 1) + " :" + rastgele);
                toplam += rastgele;
            }
            Console.WriteLine("Toplam :" + toplam);
            Console.ReadLine();

        }
    }
}
