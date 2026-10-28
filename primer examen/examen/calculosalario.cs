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
    public partial class calculosalario : Form
    {
        public calculosalario()
        {
            InitializeComponent();
        }

        private double CalcularSalario(double horas, double pagoHora)
        {
            if (horas <= 40)
            {
                return horas * pagoHora;
            }
            else
            {
                double salarioNormal = 40 * pagoHora;
                double horasExtra = horas - 40;
                double pagoExtra = horasExtra * pagoHora * 1.5;

                return salarioNormal + pagoExtra;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            double horas;
            double pagoHora;

            if (nombre == "")
            {
                MessageBox.Show("Ingrese el nombre del trabajador.");
                txtNombre.Focus();
                return;
            }

            if (!double.TryParse(txtHoras.Text, out horas) || horas <= 0)
            {
                MessageBox.Show("Las horas deben ser mayores que cero.");
                txtHoras.Focus();
                return;
            }

            if (!double.TryParse(txtPagoHora.Text, out pagoHora) ||
                pagoHora <= 0)
            {
                MessageBox.Show("El pago por hora debe ser mayor que cero.");
                txtPagoHora.Focus();
                return;
            }

            double salario = CalcularSalario(horas, pagoHora);

            lblResultado.Text = "Salario de " + nombre +
                                ": ₡" + salario.ToString("N2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtHoras.Clear();
            txtPagoHora.Clear();
            lblResultado.Text = "Resultado";
            txtNombre.Focus();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void txtPagoHora_TextChanged(object sender, EventArgs e)
        {

        }
    }
}