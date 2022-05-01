using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string ogr1;
            string ogr2 = "veli";
            string ogr3="ayşe";
            string ogr4="sinan";
            ogr1 = "inan";
            //dizi tanımlama
            string[] ogrenciler={"ali","ahmet","hasan","mehmet","ayşe"};
            Random rnd = new Random();
            Console.WriteLine(ogrenciler[rnd.Next(0,5)]);
            Console.WriteLine("--------------------------------------");
            int[] sayılar=new int[10];
            sayılar[0] = 25;
            sayılar[4] = 36;
            sayılar[8] = 12;

            int değer = sayılar[1];
            Console.WriteLine(değer);
           
            Console.ReadLine();

        }
    }
}
