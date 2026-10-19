using System;
using System.Windows.Forms;

namespace Unidad4_POO.EjerciciosPracticos
{
    public class Producto
    {  // Atributos
        private string nombre { get; set; }
        private decimal precio { get; set; }

        // Propiedades públicas
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        // Constructor
        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        // Metodo
    
        public void MostrarInfo()
        {
            MessageBox.Show($"Nombre :{Nombre}\nPrecio: {Precio:C}");
        }
    }
}
