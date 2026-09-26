using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suma_dos_numeros_ingresados
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
            Application.Run(new Form1());
        }
    }
}
while (true)
{ var consumeResult = consumer.consume();
  Console.WriteLine($"Received message: Key = {consumeResult.Message.Key}, Value = {consumeResult.Message.Value}");

}

