using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kredi_Kart_Denemesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int gtop = 0, top1 = 0, top2 = 0, gecici;
            string kartno;
            Console.Write("Kredi Kart Numarasını giriniz: ");
            kartno = Console.ReadLine();
            if (kartno.Length == 16)
            {
                for (int i = 1; i < 16; i += 2)
                {
                    top1 += Convert.ToInt16(kartno.Substring(i, 1));
                }
                for (int j = 0; j < 16; j += 2)
                {
                    gecici = Convert.ToInt16(kartno.Substring(j, 1));
                    gecici = gecici * 2;
                    if (gecici > 9)
                    {
                        gecici = gecici % 10;
                        gecici += 1;
                        top2 += gecici;
                    }
                    else
                    {
                        top2 += gecici;
                    }
                }
                gtop = top1 + top2;
                gtop = gtop % 10;
                if (gtop == 0)
                {
                    Console.WriteLine(new string('-', 35));
                    Console.WriteLine("Kredi Kartınız 'GEÇERLİ' dir..!");
                }
                else
                {
                    Console.WriteLine(new string('-', 35));
                    Console.WriteLine("Kredi Kartınız 'GEÇERSİZ' dir..!");
                }
            }
            else
            {
                Console.WriteLine("Kredi kartınız '16' haneli olmalıdır..!");
            }
            Console.ReadLine();           
        }
    }
}
