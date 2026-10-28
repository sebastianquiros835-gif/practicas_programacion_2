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
    public partial class Menuservicio : Form
    {
        public Menuservicio()
        {
            InitializeComponent();
        }

        private void Menuservicio_Load(object sender, EventArgs e)
        {
            cmbServicios.Items.Add("Instalación de software");
            cmbServicios.Items.Add("Mantenimiento");
            cmbServicios.Items.Add("Soporte técnico");

            cmbServicios.SelectedIndex = -1;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbServicios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un servicio.");
                return;
            }

            double precio = 0;

            switch (cmbServicios.SelectedIndex)
            {
                case 0:
                    precio = 15000;
                    break;

                case 1:
                    precio = 20000;
                    break;

                case 2:
                    precio = 10000;
                    break;

                default:
                    MessageBox.Show("Servicio no válido.");
                    return;
            }

            MessageBox.Show("Servicio: " + cmbServicios.SelectedItem.ToString() + "\nPrecio: ₡" + precio.ToString("N2"),"Precio del servicio");
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                cmbServicios.SelectedIndex = -1;
                cmbServicios.Focus();
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
