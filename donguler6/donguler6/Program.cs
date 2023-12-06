using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dışarıdan girilen 20 adet sayının çiftlerin adetini, teklerinde çapımını buldurun.
            int ciftAdet = 0;
            int tekCarpim = 1;
            for(int i = 1; i <=20; i++)
            {
                Console.Write(i +".sayı giriniz :");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if(sayi % 2 == 0)
                {
                    ciftAdet++;
                }
                else
                {
                    tekCarpim *= sayi;
                }
            }
            Console.WriteLine("Çift :" + ciftAdet);
            Console.WriteLine("Tek :" + tekCarpim);
            Console.ReadLine();

        }
    }
}
