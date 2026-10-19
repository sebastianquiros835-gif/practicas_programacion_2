using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad4_POO.EjerciciosPracticos;

namespace Unidad4_POO.ejerciciosPracticos
{
    public partial class producto : Form
    {
        public producto()
        {
            InitializeComponent();
        }

        private void producto_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Precio_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            {
                string nombre = txtNombre.Text;
                decimal precio = Convert.ToDecimal(txtPrecio.Text);

                Producto producto = new Producto(nombre, precio);

                MessageBox.Show(
                    "Producto asignado correctamente.\n" +
                    "Nombre: " + producto.Nombre + "\n" +
                    "Precio: ₡" + producto.Precio
                );
            }
        }
    }
}
