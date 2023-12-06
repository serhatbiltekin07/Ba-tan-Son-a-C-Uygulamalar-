using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random : rastgele sayı atama
            //Random bir  class

            //Random rasgele = new Random();
            //int sayi = rasgele.Next(10, 100);
            //Console.WriteLine("rastgele seçilen sayı : "+ sayi);
            //Console.Read();

            // 1 ile 10 arasında rastgele sayı üreten program
            Random a = new Random();
            int bjk = a.Next(1 ,11);
            Console.WriteLine("rastgele seçilen sayı : " + bjk);
            Console.Read();

        }
    }
}
