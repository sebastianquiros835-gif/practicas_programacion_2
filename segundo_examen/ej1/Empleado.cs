using segundo_examen.ej1;
using System;

namespace segundo_examen
{
    public class Empleado : Persona
    {
        public double Salario { get; set; }

        public double SalarioAnual
        {
            get { return Salario * 12; }
        }
    }
}