using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziOrnekleri5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;        
            char[] harfler = new char[] { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            Console.WriteLine("metni giriniz");
            string metin = Console.ReadLine();
            for (int i = 0; i < harfler.Length; i++)
            {
                for(int j = 0; j < metin.Length; j++)
                {
                    if (metin[j] == harfler[i])
                    {
                        sayac++;
                    }
                }

            }
            Console.WriteLine(sayac);
            Console.ReadLine();
            

        }
    }
}
