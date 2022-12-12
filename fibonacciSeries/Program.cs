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
            int i, c;
            int a = 0;
            int b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (i = 0; i < 10; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.ReadLine();
        }

    }
}
