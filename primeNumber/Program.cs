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
            //int sayi, i, sayac = 0;
            //Console.WriteLine("sayı giriniz = ");
            //sayi = int.Parse(Console.ReadLine());
            //for(i =2; i <= sayi; i++)
            //{
            //    if (sayi%i==0)
            //    {
            //        sayac++;
            //    }
            //}
            //if (sayac == 1)
            //{
            //    Console.WriteLine("asal sayıdır");
            //}
            //else
            //{
            //    Console.WriteLine("asal sayı değildir ");
            //}

            // 50 200 ARALIĞINDAKŞ ASALLAR 

            //int i, j;
            //for (i = 50; i <= 200; i++)
            //{
            //    if (i < 2)
            //    {
            //        continue;
            //    }
            //    bool isPrime = true;
            //    for (j = 2; j <= i / 2; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        Console.WriteLine(i + " ");
            //    }
            //}
            //Console.ReadLine();


           // 1 100 arası asal sayılar
            int i, j;
            for (i = 2; i < 100; i++)
            {
                int sayac = 1;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sayac = 0;
                        break;
                    }

                }
                if (sayac == 1)
                {
                    Console.WriteLine(i);
                }

            }

            //Console.WriteLine("bir sayı giriniz");
            //int sayi = int.Parse(Console.ReadLine());
            //bool asal = true;
            //for(int i = 2; i < sayi; i++)
            //{
            //    if (sayi%i==0)
            //    {
            //        asal = false;

            //    }
            //}
            //if (asal)
            //{
            //    Console.WriteLine("asal");
            //}
            //else
            //{
            //    Console.WriteLine("değil");
            //}














            Console.ReadLine();




        }
    }
}
