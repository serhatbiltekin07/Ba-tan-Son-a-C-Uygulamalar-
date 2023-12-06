using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // klavyeden girilen 10 sayıdan çiftlerin karelerin toplamı , teklerin ise küplerinin toplamını bulunuz
            int cift = 0;
            int tek = 1;
            for (int i = 1; i <=10; i++)
            {
                Console.Write(i + ". sayıyı giriniz :");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if(sayi  % 2 ==0)
                {
                    cift += sayi *sayi;
                }
                else
                {
                    tek += sayi * sayi * sayi;
                }
            }
            Console.WriteLine("Girilen çift sayıların kareleri toplamı : "+cift);
            Console.WriteLine("Girilen tek sayıların küplerin toplamı : "+tek);
            Console.ReadLine();
        }
    }
}
