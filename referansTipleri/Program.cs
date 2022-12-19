using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referansTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int decimal float enum boolean değer tipleri
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine(sayi1);
            int[] myArr = new int[] { 1, 2, 3 };
            int[] myArr2 = new int[] { 10, 20, 30 };
            myArr = myArr2;
            myArr2[0] = 1000;
            Console.WriteLine(myArr[0]);
            Console.ReadLine();
            // array class interface referans tip dir 

        }
    }
}
