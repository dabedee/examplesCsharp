using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziOrnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, sayi, i;
            Console.Write("Sınıf mevcudunu giriniz = ");
            n = int.Parse(Console.ReadLine());
            string[] myArr = new string[55];
            for (i = 0; i < n; i++)
            {
                Console.Write("ogrenci adını giriniz = ");
                myArr[i] = Console.ReadLine();
            }
            Console.ReadLine();

        }
    }
}
