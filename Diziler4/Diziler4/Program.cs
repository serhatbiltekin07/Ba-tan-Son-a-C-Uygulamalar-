using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dizideki negatif sayıları pozitif sayılara çeviren programı yazınız
            //(eksi değerler girilmesi istensin)

            Console.Write("Dizi botunu girin:");
            int elemanSayisi = Convert.ToInt32(Console.ReadLine());

            int[] sayi = new int[elemanSayisi];

            for(int i =0; i < sayi.Length; i++)
            {
                Console.WriteLine(i + 1 + ".Sayıyı giriniz:");
                sayi[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < sayi.Length; i++)
            {
                Console.WriteLine("Değerler:" + sayi[i] * (-1));
            }
            Console.ReadLine();
        }
    }
}
