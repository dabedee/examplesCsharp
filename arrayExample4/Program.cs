using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayExample4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myArr = new string[4] { "rukiye deniz yelken", "21 yaşında","orta boylu","lol oynuyor" };
            foreach (string myarr in myArr)
            {
                Console.WriteLine(myarr);
            }
            Console.ReadLine();
        }
    }
}
