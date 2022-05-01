using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _57_contextmenustrip
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Uygulama aiağıdaki kodlar yazıldığında sadece bir örnek çalışır.
            Process[] processesByName = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            if (processesByName.Length > 1)
            {
                MessageBox.Show("Uygulama zaten çalışıyor.");
                return;
            }
            Application.Run(new Form1());
        }
    }
}
