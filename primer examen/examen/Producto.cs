using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_examen.examen
{
    internal class Producto
    {
        private string codigo;
        private string nombre;
        private double precio;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public double ObtenerPrecioConIVA()
        {
            return Precio * 0.13;
        }
    }
}
