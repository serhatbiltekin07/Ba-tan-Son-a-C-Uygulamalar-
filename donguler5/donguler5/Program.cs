using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dışarıdan girilen 10 sayının çift olanlarının toplamını bul

            int toplam = 0;
            for(int i =1; i<=10; i++)
            {
                Console.WriteLine(i +". sayı :");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if(sayi % 2 == 0)
                {
                    toplam += sayi;
                    Console.WriteLine("Sayı çift sayı!");
                }
                else
                {
                    Console.WriteLine("sayı çift değil");
                }
            }
            Console.WriteLine("çift sayıların toplamı :" + toplam);
            Console.ReadLine();
        }
    }
}
