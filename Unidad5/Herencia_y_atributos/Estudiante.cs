using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad5.Herencia_y_atributos
{
    internal class Estudiante : Persona
    {
        public int EdadCalculada
        {
            get
            {
                return DateTime.Now.Year - AñoNacimiento;
            }
        }

        public Estudiante(int añoNacimiento) : base(añoNacimiento)
        {

        }
    }
}
