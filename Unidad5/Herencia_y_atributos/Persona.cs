using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad5.Herencia_y_atributos
{
    internal class Persona
    {
        public int AñoNacimiento { get; set; }

        public Persona(int añoNacimiento)
        {
            AñoNacimiento = añoNacimiento;
        }
    }
}
