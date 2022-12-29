using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziOrnekleri8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ogrno = { "101", "102", "103", "104", "105", "106", "107", "108", "109", "110" };
            string[] isim = { "Ali", "Veli", "Hasan", "Kemal", "Can", "Ahmet", "Mehmet", "Enis", "Bilal", "Burak" };
            string[] telefon = { "111", "222", "333", "444", "555", "666", "777", "888", "999", "1000" };
            string[] mail = { "aaaa@aaa.aa", "bbbbb@bbb.bb", "cccc@ccc.cc", "dddd@ddd.dd", "eeee@eee.ee", "ffff@eee.ee", "gggg@eee.ee", 
                "hhhh@eee.ee", "iiii@eee.ee", "jj@eee.eej" };
            Console.Write("Kişi No'yu girin: ");
            string aranan = Console.ReadLine();
            int no = Array.IndexOf(ogrno, aranan.ToString());
            Console.WriteLine("===========================================================================");
            Console.WriteLine("Aranan Kişi : {0}\tTelefonu: {1}\tE-mail: {2}", isim[no], telefon[no], mail[no]);
            Console.ReadKey();


        }

    }
}
