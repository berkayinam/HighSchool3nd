using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Fal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd=new Random();
            string[] falDizisi = { "çok güzel görünüyorsun", "muhteşemsin", "sen adam olmazsın", "sen kocaman bir çılgınsın", "gelecek sanamı gelecek", "kaldırım mühendisimi olacan" };
            do
            {
                Console.Write("Hazırmısın.......");
                Console.ReadLine();
                Console.WriteLine(falDizisi[rnd.Next(0, 6)]); 
            } while (true);
            
        }
    }
}
