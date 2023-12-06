using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 ile 30 arasındaki  sayıların toplamı

            int toplam = 0;
            for(int i=5; i<=30; i++)
            {
                Console.WriteLine("sayılar :" + i );
                 toplam += i; //toplam = toplam + i;
            }
             
            Console.WriteLine("Sayıların Toplamı :" + toplam );
            Console.ReadLine();
        }
    }
}
