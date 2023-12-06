using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            
            
            

            Console.WriteLine("********* BİLGİ EKRANI");
            Console.WriteLine("Ad :" );
            String ad = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Mezuniyet notunuzu giriniz : ");
            float not = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Tecrüb Yılınızı Giriniz : ");
            int tyil = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cinsiyet :");
            char cinsiyet = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(" Ödeme tutarını giriniz :");
            int tutar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kdv tutarı giriniz :");
            int kdv = Convert.ToInt32(Console.ReadLine());

            decimal sonuc = tutar + (tutar * kdv) / 100;

            Console.WriteLine("KDV'li tutar :" + sonuc);

            
            

            Console.ReadLine();


           

        }
    }
}
