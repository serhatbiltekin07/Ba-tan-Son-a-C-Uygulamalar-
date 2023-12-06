using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen değerin bir fazlasına kadar olan sayıyla çarpım tablosu gösterin.

            Console.Write("Bir sayı giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int islem = 0;

            for(int i = 1; i<= sayi; i++)
            {
                islem = i * (i + 1);
                Console.WriteLine(i + "x" +(i+1) + "=" + islem );
            }
            Console.ReadLine();
        }
    }
}
