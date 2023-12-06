using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Başlangıç ve bitiş sayısını belileyin ve bu sayılar arasındaki 3 ve 5' e tam bölünlerin adetini bulun
            Console.Write("Başlangıç değerini giriniz :");
            int baslangic = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitiş değerini giriniz :");
            int bitis = Convert.ToInt32(Console.ReadLine());

            int adet = 0;

            for(int i = baslangic; i < bitis; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                        Console.WriteLine(i);
                        adet++;
                }
            }
            Console.WriteLine("3 ve 5 e bölünen sayıların adedi:" + adet);
            Console.ReadLine();
        }
    }
}
