using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kapsülleme(Encapsulation)
            //herhangi bir nesnenin metodlarını, verilerini ve değişkenlerini diğer nesnelerden saklayarak bunlara erişimini
            //sınırlandırarak yanlış kullanımlardan korur.
            //private olan field alanların kontrollü bir şekilde kullanıcıya açılmasını sağlayan ve koruma altına aldığımız sisteme encapsulation denir.
            // iki anahtar kelimesi var
            // get : okunacak ,değerin döndürüldüğü getirildiği bölümdür
            // set: atama, değer ata,yazdır.

            Musteriler musteriler = new Musteriler();

            //bu kısımda property alanında set kısmı çalışır
            //property de gelen her atama değer value olarak gelir kontrol edildikten sonra şartlar sağlanırsa fieldlar atama
            //yapılır . yoksa yapılmaz
            Console.WriteLine("Müşteri Numarası Giriniz:");
            musteriler.Mno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ad Soyad Giriniz:");
            musteriler.MadSoyad = Console.ReadLine();
            Console.WriteLine("Bakiye Giriniz:");
            musteriler.Bakiye = Convert.ToSingle(Console.ReadLine());


            Console.Clear();

            //bu kısımda property get kısmı çalışır.
            Console.WriteLine("Müşteri No:" + musteriler.Mno);
            Console.WriteLine("Müşteri Ad Soyad:" + musteriler.MadSoyad);
            Console.WriteLine("Müşteri Bakiyesi:" + musteriler.Bakiye);

            Console.ReadLine();

        }
    }
}
