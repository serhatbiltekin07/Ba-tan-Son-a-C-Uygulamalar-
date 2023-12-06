using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siniflar2
{
    internal class Araba
    {
        int arabano;
        string arabaadi;
        int motorgucu;
        string vitesdr;
        int fiyat;
        int otv;


        public int ArabaNo
        {
            get { return arabano; }
            set
            {
                if(value.ToString().Length == 6)
                {
                    arabano = value;
                }  
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız!");
                    Console.WriteLine("Araç no giriniz = ");
                    arabano = Convert.ToInt32(Console.ReadLine());
                }
            }

        }

        public string Arabaadi
        {
            get; set;
        }

        public int Motorgucu
        {
            get { return motorgucu; }
            set
            {
                if(value > 1000 && value< 2000)
                {
                    motorgucu = value;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız 1000 ile 2000 arasında değer girilmeli");

                    Console.WriteLine("Motor Gücünü giriniz:");
                    motorgucu = Convert.ToInt32(Console.ReadLine());    

                }
            }
        }

        public string VitesDr
        {
            get { return vitesdr; }
            set
            {
                if (value == "Manuel" || value == "Otomatik" || value == "MANUEL" || value == "OTOMATİK")
                {
                    vitesdr = value;
                }
                else 
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız!");
                    Console.WriteLine("Vites Türü Giriniz:");
                    vitesdr = Console.ReadLine();
                        
                 }
            }
        }

        public int Fiyat
        {
            get { return fiyat; }
            set
            {
                if(value >=300000 &&  value <= 1000000)
                {
                    fiyat = value;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız!");
                    Console.WriteLine("fiyat Türü Giriniz:");
                    fiyat = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public int OTV
        {
            get { return otv; }
            set
            {
                if ((value > 10 && value < 60))
                {
                    fiyat = value;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız! 10 ile 60 arasında girilmeli:");
                    Console.WriteLine("fiyat Türü Giriniz:");
                    otv = Convert.ToInt32(Console.ReadLine());
                }

            }
        }
        public int OtvHesapla(int fiyat, int otv)
        {
            fiyat += fiyat * otv / 100;
            return fiyat;
        }
        public int Vergi(int fiyat)
        {
            fiyat += fiyat * 5 / 100;
            return fiyat;
        }
        public void Kasko()
        {
            Console.WriteLine("Kasko İster misiniz?");
            char secim = Convert.ToChar(Console.ReadLine());    
            if (secim == 'e' || secim 'E'){
                Console.WriteLine("");
            }
            else { 
            Console.WriteLine("10000 sgk ödemesi yapmanız gerekiyor");
            }

        }
    }
}
