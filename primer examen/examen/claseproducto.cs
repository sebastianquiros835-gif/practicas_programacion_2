using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primer_examen.examen
{
    public partial class claseproducto : Form
    {
        public claseproducto()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool valido = true;
            double precio;

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                errorProvider1.SetError(txtCodigo, "Ingrese el código.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre.");
                valido = false;
            }

            if (!double.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                errorProvider1.SetError(txtPrecio,
                    "Ingrese un precio mayor que cero.");
                valido = false;
            }

            if (!valido)
                return;

            Producto producto = new Producto();

            producto.Codigo = txtCodigo.Text.Trim();
            producto.Nombre = txtNombre.Text.Trim();
            producto.Precio = precio;

            MessageBox.Show(
                "Código: " + producto.Codigo +
                "\nNombre: " + producto.Nombre +
                "\nPrecio: ₡" + producto.Precio.ToString("N2") +
                "\nPrecio con IVA: ₡" +
                producto.ObtenerPrecioConIVA().ToString("N2"),
                "Datos del producto");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            errorProvider1.Clear();
            txtCodigo.Focus();
        }

        private void claseproducto_Load(object sender, EventArgs e)
        {

        }
    }
}
