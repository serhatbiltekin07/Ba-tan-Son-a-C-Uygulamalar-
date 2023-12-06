using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10 ie 30 arasınadi sayıların ortalamasını bulun 
            int toplam = 0;
            int adet = 0;
            float ortalama = 0;
            for(int i=10; i<30; i++)
            {
                adet++;
                toplam += i;
                ortalama = toplam / adet;
            }
            Console.WriteLine("Toplam : " + toplam);
            Console.WriteLine("Ortalama : " + ortalama);


            //dışarından girilen sayıların toplamı 10 olacak
            Console.ReadLine();
        }
    }
}
