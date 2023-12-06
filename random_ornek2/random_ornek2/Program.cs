using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program rastgele sayı tutsun (1 ile 20 arasında)
            // kullanıcı sayıyı tahmin etmeye çalışsın
            // kaçıncı kerede tahminin tuttuğunu yazdırın..
            // daha büyük sayı girin veya daha küçük sayı girin şeklinde yönlendirme yapsın..
            //try catch



            Random sayi = new Random();
            int programtahmin = sayi.Next(1, 20);
            int sayac = 0;

            go:
            try
            {
                Console.Write("Sayı Tahmininizi Giriniz :");
                int kullanicitahmin = Convert.ToInt32(Console.ReadLine());
                sayac++;


                if (programtahmin == kullanicitahmin)
                {
                    Console.WriteLine(sayac + ". kerede tahmin tuttu");
                }
                else if (programtahmin > kullanicitahmin)
                {
                    Console.WriteLine("Daha büyük bir sayı giriniz ");
                    goto go;
                }
                else
                {
                    Console.WriteLine("Daha küçük bir sayı giriniz");
                    goto go;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Lütfen sayısal bir değer giriniz ");
                goto go;
            }
            
            Console.ReadLine();
        }
    }
}
