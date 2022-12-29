using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziOrnekleri4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            int[]myArr=new int[] { 10, 15, 20, 33, 22, 11, 9, 8, 48, 47, 12, 25, 12, 21 };
            foreach(var item in myArr)
            {
                if (item % 2 == 1)
                {
                    sayac++;
                    Console.WriteLine(item);    
                }
            }
          
            Console.WriteLine("tek sayi adedi = "+sayac);
            Console.ReadLine();

        }
    }
}
