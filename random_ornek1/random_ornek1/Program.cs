using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random skor = new Random();
            int bjk = skor.Next(0, 5);
            int gs = skor.Next(0,5);

            if(bjk == gs)
            {
                Console.WriteLine("Berabere kaldınız");
                Console.WriteLine("BJK skor :" + bjk);
                Console.WriteLine("gs skor :" + gs);
            }
            else if (bjk > gs)
            {
                Console.WriteLine("BJK kazandı!!!");
                Console.WriteLine("BJK skor :" + bjk);
                Console.WriteLine("gs skor :" + gs);
            }
            else
            {
                Console.WriteLine("Hakem ile kazandı gs kazandı!!!");
                Console.WriteLine("BJK skor :" + bjk);
                Console.WriteLine("gs skor :" + gs);
            }

            Console.ReadLine();



        }
    }
}
