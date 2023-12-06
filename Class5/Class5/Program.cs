using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //araba adında class
            //renk, model , vites(oto,manuel), fiyat alanları tanımlansın
            //
            Araba araba1= new Araba();

                araba1.ARenk = "Kırmızı";
                araba1.AModel = "Reanult";
                araba1.AVites = "Otomatik";
                araba1.AFiyat = 50000;
            araba1.Plaka = "25";
        Console.WriteLine("Arabanın Rengi:"+ araba1.ARenk);
        Console.WriteLine("Arabanın Modeli:"+ araba1.AModel);
        Console.WriteLine("Arabanın Vites:"+ araba1.AVites);
        Console.WriteLine("Arabanın Fiyat:"+ araba1.AFiyat);
        Console.WriteLine("Arabanın Plakası:"+ araba1.Plaka);
            Console.ReadLine();
        }
    }
}
