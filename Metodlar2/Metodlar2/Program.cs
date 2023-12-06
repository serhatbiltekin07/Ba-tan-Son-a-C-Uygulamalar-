using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar2
{
    internal class Program
    {
        private static void yazdir(string bilgi) 
        {
            for (int i = 0; i<10; i++)
            {
                Console.WriteLine(bilgi);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Metni Giriniz:");
            string metin = Console.ReadLine();
            yazdir(metin);
            Console.ReadLine();
        }
    }
}
