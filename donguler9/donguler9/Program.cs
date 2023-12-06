using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 75 den 300 e kadar olan sayılardan dışarıdan girilen sayıya bölünenlerin adedini bulsun
            Console.Write("Bir sayı girin :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int adet = 0;
           
                for(int i = 75; i<=300; i++)
                {
                    if(i % sayi == 0)
                    {
                     adet++;
                    }

                }
            Console.WriteLine("Bölenlerin sayı adedi :" + adet);


            Console.ReadLine();


        }

    }
    
}
