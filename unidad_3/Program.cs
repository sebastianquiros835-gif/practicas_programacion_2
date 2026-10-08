using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using unidad_3.ejercisiosclase;

namespace unidad_3
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ejercicio1());
            //Application.Run(new ejercicio2());
            //Application.Run(new ejercicio3());
            Application.Run(new practica_programada3());
        }   
    }
}
