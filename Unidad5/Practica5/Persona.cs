using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad5.Practica5
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int AnoNacimiento { get; set; }

        public Persona()
        {
        }

        public Persona(string nombre, int anoNacimiento)
        {
            Nombre = nombre;
            AnoNacimiento = anoNacimiento;
        }


    }
}
