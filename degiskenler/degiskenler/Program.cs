using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adsoyad = " Biltekin kurtuluş";
            string il = "İstanbul";
            int yas = 26;
            float fiyat = 100.5f;
            double fiyat2 = 100.5d;
            decimal fiyat3 = 100.5m;
            char cinsiyet = 'E';

            Console.WriteLine("--------BİLGİLER TABLOSU ----------");
            Console.WriteLine();
            Console.WriteLine("Adı Soyadı :" + adsoyad );
            Console.WriteLine( "İl :" + il );
            Console.WriteLine( "Yaş :" + yas );
            Console.WriteLine("Fiyat :" + fiyat);
            Console.WriteLine("Fiyat2 :" + fiyat2);
            Console.WriteLine("Fiyat3 :" + fiyat3);
            Console.WriteLine("Cinsiyet :" + cinsiyet);

            Console.ReadKey();

        }
    }
}
