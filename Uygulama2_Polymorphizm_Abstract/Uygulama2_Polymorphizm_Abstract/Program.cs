
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2_Polymorphizm_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Polymorphizm: Çok biçimlilik, çok şekillilik
            //Bir sınıfa aynı isimde farklı uygulamalar yapabilme özelliği sağlar
            // Ana classta gövdesi yazılır
            //yavru classlarada var olan method ezilerek kendi işlemleri yapılabilir


            //Abstract: Soyutlama
            //Nesne yönelimli programlamada nesnesi oluşturulmayan sınıflara denir
            //Abstract olarak tanımlanan sınıf temel sınıftır.
            //Bu sınıftan new anahtar kelimesi kullanılarak bir nesne oluşturulamaz.
            // Sadece soyut sınıflar içerisinde kullanılabilir
            //mirasçı sınıflarda ovveride edilmek zorundadırlar.


            Turk turk = new Turk();
            turk.Selamver();

            Ingilizler ing = new Ingilizler();
            ing.Selamver();

            Console.ReadLine();


        }
    }
}
