using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //anneadi,babaadi,uyesayisi,memleket,toplamkazanc

            String anneadi = "Fatma";
            string babaadi = "Ahmet";
            int uyeSayisi = 4;
            string memleket = "İstanbul";
            String meslek = "Yazılım";
            double toplamKazanc = 30000d;

            Console.WriteLine("*********AİLE BİLGİSİ************");
            Console.WriteLine();

            Console.WriteLine("Anne Adı :" + anneadi);
            Console.WriteLine("Baba Adı : "  + babaadi);
            Console.WriteLine("Üye Sayısı :" + uyeSayisi);
            Console.WriteLine("Memleket :" + memleket);
            Console.WriteLine("Meslek:" + meslek);
            Console.WriteLine("Toplam Kazanç :" + toplamKazanc);

            Console.ReadLine();

        }
    }
}
