using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4_POO.ejerciciosPracticos
{
    public partial class ErrorProvide : Form
    {
        public ErrorProvide()
        {
            InitializeComponent();
            this.txrNombre.Validating += txrNombre_Validating;
        }

        private void txrNombre_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txrNombre.Text))
            {
                errorProvider1.SetError(txrNombre, "El nombre no puede estar vacío.");
            }
            else
            {
                errorProvider1.SetError(txrNombre, string.Empty);
            }
        }

        private void txrNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txrNombre.Text))
            {
                errorProvider1.SetError(txrNombre, "El nombre no puede estar vacío.");
                e.Cancel = true; // no permite salir del textbox 
            }
            else
            {
                errorProvider1.SetError(txrNombre, string.Empty);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            bool todoBien = true;

            // Validar el nombre
            if (string.IsNullOrWhiteSpace(txrNombre.Text))
            {
                errorProvider1.SetError(txrNombre, "El nombre no puede estar vacío.");
                todoBien = false;
            }
            else
            {
                errorProvider1.SetError(txrNombre, "");
            }


            //validar el precio
            int precio;

            if (!int.TryParse(txtPrecio.Text, out precio) || precio < 0)
            {
                errorProvider1.SetError(txtPrecio, "numero invalido.");
                todoBien = false;
            }
            else
            {
                errorProvider1.SetError(txtPrecio, "");


                if (todoBien)
                {
                    MessageBox.Show("Producto guardado correctamente.");


                }
                
            }
        }
    }
}
