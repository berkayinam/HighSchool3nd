using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_DizilerToplama
{
    class Program
    {
        static void Main(string[] args)
        {
           Random rnd=new Random();
            int[] sayı = new int[20];
            for (int i = 0; i < 20; i++)
            {
                sayı[i] = rnd.Next(0,100);
                Console.WriteLine(sayı[i]);
            }
 
            int toplam=0;
            for (int i = 0; i <20; i++)
            {
                toplam += sayı[i];
            }
            Console.WriteLine("Toplama işlemi sonucu : "+toplam);
            Console.ReadLine();


                  



        }
    }
}
