using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad5.practicas
{
    public class LogicaProducto
    {
        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();

            productos.Add(new Producto { Nombre = "Teclado", Precio = 8500 });
            productos.Add(new Producto { Nombre = "Mouse", Precio = 4500 });
            productos.Add(new Producto { Nombre = "Monitor", Precio = 75000 });

            return productos;
        }
    }
}
