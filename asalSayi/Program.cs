using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asalSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sayi, sayac = 0;
            Console.Write("Sayi giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;

                }
            }
            if (sayac == 2)
            {
                Console.WriteLine("{0} sayisi asal sayidir ",sayi);
            }
            else
            {
                Console.WriteLine("{0} sayisi asal sayi değildir ",sayi);
            }
            Console.ReadLine();
            
        }
    }
}
