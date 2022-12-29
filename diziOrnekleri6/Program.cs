using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziOrnekleri6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Ahmet", "Mehmet", "Ali", "Veli", "Hasan" };
            int son = (isimler.Length-1);
            for(int i = son; i >= 0; i--)
            {
                Console.WriteLine(isimler[i]);
            }
            Console.ReadLine();
        }
    }
}
