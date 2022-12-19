using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziOrnekleri2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pozitif = 0, negatif = 0, notr = 0, i;
            Random rnd = new Random();
            int[] myArr = new int[40];
            for (i = 0; i < 40; i++)
            {
                myArr[i] = rnd.Next(-100, 100);
            }
            foreach (int sayi in myArr)
            {
                Console.WriteLine(sayi);
                if (sayi > 0)
                {
                    pozitif++;
                }
                else if (sayi<0)
                {
                    negatif++;

                }
                else
                {
                    notr++;
                }

            }
            Console.WriteLine("{0} tane pozitif sayı vardır",pozitif);
            Console.WriteLine("{0} tane negatif sayı vardır ",negatif);
            Console.WriteLine("{0} tane sıfır vardır ",notr);
            Console.ReadLine();
        }
    }
}
