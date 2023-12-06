using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar5
{
    internal class Program
    {
        private static void buyukSayi(int sayi1,int sayi2)
        {
         
            if(sayi1 > sayi2 )
            {
                Console.WriteLine("Birinci sayı büyük");
            }else
            {
                Console.WriteLine("İkinci sayı büyük.");
            }
        }
        static void Main(string[] args)
        {
            //BuyukSayi method adı
            //kullanıcıdan girdiği iki sayıdan büyük olanı ekrana yazdırsın 
            Console.WriteLine("1. Sayıyı giriniz:");
            int ilksayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. Sayıyı giriniz:");
            int ikincisayi = Convert.ToInt32(Console.ReadLine());

            buyukSayi(ilksayi, ikincisayi);
            Console.ReadLine();
        }
    }
}
