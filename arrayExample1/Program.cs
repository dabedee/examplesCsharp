using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //BİR DİZİDEKİ ANAHTAR ÖĞELERİ ARAMA
            int n, n1, i, flag = 0;
            int[] myArr = new int[55];
            Console.WriteLine("Dizinin boyutunu giriniz = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dizinin elemanlarını giriniz = ");
            for (i = 0; i < n; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Aranacak elemanı giriniz = ");
            n1 = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                if (myArr[i]==n1)
                {
                    flag = 1;
                    Console.WriteLine("Sayı "+n1+ "konumu"+(i+1));
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("sayı dizide bulunamadı"+n1);
                
            }
            Console.ReadLine();




        }
    }
}
