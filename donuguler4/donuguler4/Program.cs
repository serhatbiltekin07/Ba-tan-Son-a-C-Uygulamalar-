using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donuguler4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //dışarıdan 10 adet sayı  girilecek ve  sayıları toplanacak sonucu ekrana yaz

            int toplam = 0;
            for(int i = 1; i<=10; i++)
            {
                Console.WriteLine( i +".Sayıyı giriniz :");
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
            }
            Console.WriteLine("********************************");
            Console.WriteLine("Sayıların toplamı :" + toplam);

            Console.ReadLine();
        }
    }
}
