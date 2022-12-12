using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialOfANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, i, fak = 1;
            Console.Write("Sayi giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (i = sayi; i > 1; i--)
            {
                fak = fak * i;
            }
            Console.WriteLine("{0} sayisinin faktoriyelii = {1}",sayi,fak);
            Console.ReadLine();


        }
    }
}
