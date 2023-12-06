using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cokBicimlilikOrnek1
{
    internal class Islemler
   
    {

      
        public virtual void Islem() 
        {
          int sayi1, sayi2;

            Console.WriteLine("1. sayı:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayı:");
            sayi2 = Convert.ToInt32(Console.ReadLine());

        }
    }
}
