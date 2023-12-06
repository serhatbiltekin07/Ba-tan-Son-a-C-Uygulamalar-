using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar4
{
    internal class Program
    {
        private static int hesapla(int x, int y)
        {
            int alan = x * y;
            return alan;
        }
        static void Main(string[] args)
        {
            //hesapla adında method
            //kısa ve uzunkenar girilecek ve alan hesaplanacak
            //buu
            //methodu 2 kez çalışsın.
            Console.WriteLine("Kısa Kenar girin: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzun Kenar girin");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Alan" + hesapla(x, y));
            Console.ReadLine();
        }
    }
}
