using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark
{
   public  class arac
    {
        public int id { get; set; }
        public string plaka { get; set; }
        public DateTime girisTarihi { get; set; }
        public DateTime cikisTarihi { get; set; }
        public int ucret { get; set; }

        public void aracinOzellikleriniGoster()
        {
            Debug.Print(id.ToString() + " " + plaka.ToString() + " " + girisTarihi.ToString() + " " + ucret.ToString());
        }


    }
}
