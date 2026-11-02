using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad5.Herencia_y_atributos
{
    public partial class Edad : Form
    {
        public Edad()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int añoNacimiento;

            if (int.TryParse(txtAñoNacimiento.Text, out añoNacimiento))
            {
                Estudiante estudiante = new Estudiante(añoNacimiento);

                MessageBox.Show(
                    "Año de nacimiento: " + estudiante.AñoNacimiento +
                    "\nEdad calculada: " + estudiante.EdadCalculada,
                    "Información del estudiante"
                );
            }
            else
            {
                MessageBox.Show("Ingrese un año válido.");
            }
        }
    }
}
