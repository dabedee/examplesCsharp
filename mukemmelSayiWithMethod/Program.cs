using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mukemmelSayiWithMethod
{
    internal class Program
    {
        static bool MukemmelSayıMı(int sayi)
        {
            int i, toplam = 0;
            for (i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }

            return toplam == sayi;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("sayi giriniz");
            int sayi = int.Parse(Console.ReadLine());
            if (MukemmelSayıMı(sayi))
            {
                Console.WriteLine("girilen sayı mükemmel sayıdır");
            }
            else
            {
                Console.WriteLine("girilen sayı mükemmel sayı değildir");
            }
            Console.ReadLine();

        }
    }
}
