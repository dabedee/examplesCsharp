using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziOrnekleri3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  dizinin içinde girdiğimiz sayıdan kaçtane var
            int kontrol = 0;
            int[] myArr = new int[] { 40, 40, 30, 20, 10, 50,90};
            Console.WriteLine("sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            foreach(var item in myArr)
            {
                if (sayi==item)
                {
                    kontrol++;

                }
            }
            if (kontrol == 0)
            {
                Console.WriteLine("sayı dizi içinde bulunamadı");
            }
            else
            {
                Console.WriteLine("dizide {0} adet  var", kontrol);
            }
            Console.ReadLine();

        }
    }
}
