using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Riesgos
{
    static class Program
    {
        public static string cnn212 = "Data Source=192.168.10.212;Initial Catalog=FINANPOP;User ID=sa;Password=finanpop_2018;";
        public static string cnn67 = "Data Source=192.168.10.67;Initial Catalog=FINANPOP;User ID=sa;Password=147852aaA;";
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }

    }
}
