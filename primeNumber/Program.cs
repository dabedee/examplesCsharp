using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, i, sayac = 0;
            Console.WriteLine("sayı giriniz = ");
            sayi = int.Parse(Console.ReadLine());
            for(i =2; i <= sayi; i++)
            {
                if (sayi%i==0)
                {
                    sayac++;
                }
            }
            if (sayac == 1)
            {
                Console.WriteLine("asal sayıdır");
            }
            else
            {
                Console.WriteLine("asal sayı değildir ");
            }

            Console.ReadLine();
        }
    }
}
