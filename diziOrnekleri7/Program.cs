using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziOrnekleri7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gunler = { "Pazartesi", "Sali", "Carsamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            Console.WriteLine("gün adını giriniz");
            string gunAdi = Console.ReadLine();
            for (int i = 0; i < gunler.Length; i++)
            {
                if (gunAdi == gunler[i])
                {
                    Console.WriteLine(i + 1 + ". gündür");

                }
               
            }
            Console.ReadLine();



        }
    }
}
