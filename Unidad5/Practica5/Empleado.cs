using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad5.Practica5
{
    internal class Empleado : Persona
    {
        public decimal Sueldo { get; set; }

        public int Edad
        {
            get
            {
                return DateTime.Now.Year - AnoNacimiento;
            }
        }

        public Empleado(string nombre, int anoNacimiento, decimal sueldo)
            : base(nombre, anoNacimiento)
        {
            Sueldo = sueldo;
        }
    }
}
