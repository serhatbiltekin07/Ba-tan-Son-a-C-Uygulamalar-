using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetgodÖDEV2
{
    internal class Program
    {
       private static void Konaklama()
        {
            int gunSayisi = 0;
            double fiyat = 0;
        }
        private static void GunSayisinaGoreHesapla()
        {
            if(GunSayisi < 10)
            {

            }
        }
        static void Main(string[] args)
        {
            Konaklama konaklama = new Konaklama();

            Console.WriteLine("***** KONAKLAMA *****");
            Console.Write("Gün Sayısı:");
            konaklama.gunSayisi = int.Parse(Console.ReadLine());

            Console.WriteLine("Fiyat:");
            konaklama.Fiyat = double.Parse(Console.ReadLine());

            //konaklama.TutarHesapla

        }
    }
}
