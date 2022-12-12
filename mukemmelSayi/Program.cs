using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mukemmelSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sayi, toplam = 0;
            Console.Write("Sayi giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }
            if (toplam == sayi)
            {
                Console.WriteLine("Girilen sayi bir Mükemmel Sayidir. ");
            }
            else
            {
                Console.WriteLine("Girilen sayi mükemmel sayi değildir. ");
            }
            Console.ReadLine();


        }
    }
}
