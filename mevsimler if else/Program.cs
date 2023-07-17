using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mevsimler_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mevsim;
            Console.WriteLine("Bir mevsim giriniz ");
            mevsim = Console.ReadLine();

            if (mevsim == "ilkbahar")
            {
                Console.WriteLine(mevsim + " " + "mevsiminin ayları mart, nisan,mayıs");
            }
            else if (mevsim == "yaz")
            {
                Console.WriteLine(mevsim + " " + "mevsiminin ayları haziran,temmuz,ağustos");
            }
            else if (mevsim == "sonbahar")
            {
                Console.WriteLine(mevsim + " " + "mevsiminin ayları eylül, ekim,kasım");
            }
            else if (mevsim == "kış")
            {
                Console.WriteLine(mevsim + " " + "mevsiminin ayları aralık,ocak,şubat");
            }
            Console.ReadLine();
        }
    }
}
