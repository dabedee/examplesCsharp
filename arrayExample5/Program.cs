using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayExample5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[10];
            
            for(int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine("dizinin {0}. elemanını giriniz",i+1);
                myArr[i] = int.Parse(Console.ReadLine());
                
            }
            int max = myArr[0];
            for(int i = 0; i < myArr.Length; i++)
            {
                if(myArr[i] > max)
                {
                    max = myArr[i];
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();

        }
    }
}
