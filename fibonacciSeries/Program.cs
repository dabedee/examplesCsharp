using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ilk 12 eleman



            //int i, c;
            //int a = 0;
            //int b = 1;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //for (i = 0; i < 10; i++)
            //{
            //    c = a + b;
            //    Console.WriteLine(c);
            //    a = b;
            //    b = c;
            //}
            //Console.ReadLine();

            // 1 ile 1000 arasındaki fibonacci 
            int a = 0;
            int b = 1;
            int c = 0;
            while (c <= 1000)
            {
                c = a + b;
                if (c > 1000)
                {
                    break; 
                }
                    
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.ReadLine();

        }

    }
}
