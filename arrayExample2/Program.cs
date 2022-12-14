using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan 10 elemanlı BİR DİZİ alan ve  ÇİFT SAYILARIN SAYISINI BULan
            int i, cnt = 0;
            int[] myArr = new int[10];
            Console.WriteLine("sayi giriniz = ");
            for (i = 0; i < 10; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
                if (myArr[i] % 2 == 0)
                {
                    cnt = cnt + 1;
                }
            }
            Console.WriteLine("{0} tane çift sayı vardır",cnt);
            Console.ReadLine();








        }
    }
}
