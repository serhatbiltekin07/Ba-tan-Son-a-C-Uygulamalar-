using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genel_uygulama2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //alış fiyatı girilen malın kullanıcının girdiği yüzdelik karla satış fiyatını bulan program
            Console.Write("Alış fiyatını girin :");
            double alisFiyati = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kar yüzdesini girin :");
            double karYuzdesi = Convert.ToDouble(Console.ReadLine());

            double karOrani = karYuzdesi / 100.0;
            double satisFiyati = alisFiyati +(alisFiyati * karOrani);

            Console.WriteLine("Satış Fiyatı :" + satisFiyati);
            Console.ReadLine();
        }
    }
}
