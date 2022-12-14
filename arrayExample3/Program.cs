using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*dizinin boyutunu ve elemanlarını kullanıcıdan alan
             * daha sonra dizinin minimum ve ikinci minimum elemanını bulan program
             */
            int min1, min2, n, i;
            int[] myArr = new int[55];
            Console.WriteLine("Dizinin lenght giriniz = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} adet eleman giriniz ",n);
            for (i = 0; i < n; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
            }
            if (myArr[0] < myArr[1])
            {
                min1= myArr[0];
                min2= myArr[1];
            }
            else
            {
                min1 = myArr[1];
                min2 = myArr[0];
            }
            for (i = 2; i < n; i++)
            {
                if (myArr[i]<min1)
                {
                    min2 = min1;
                    min1= myArr[i];
                }
                else if (myArr[i]<min2)
                {
                    min2 = myArr[i];
                }
            }
            Console.WriteLine("min = "+min1);
            Console.WriteLine("second min = "+min2);
            Console.ReadLine();
        }
    }
}
