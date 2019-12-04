using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeybekMesafe
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplamAdim = 0;
            Console.Write("Toplam kac adim atiliyor:");
            toplamAdim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplam gidilen mesafe=" + Hesapla(toplamAdim));
            Console.ReadKey();
        }
        public static int Hesapla(int adim)
        {
            int mesafe = 0;
            if (adim % 5 == 0)
            {
                mesafe = adim / 5;
                return mesafe;
            }
            else if (adim % 5 != 0 && adim % 5 != 4)
            {
                int kalan = adim % 5;
                mesafe = (adim / 5) + kalan;
                return mesafe;
            }
            else
            {
                mesafe = (adim / 5) + 2;
                return mesafe;
            }
        }
    }
}
