using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad5.Validaciones_y_DialogResult
{
    public partial class form1 : Form
    {
        List<string> estudiantes = new List<string>();
        public form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           DialogResult resultado = MessageBox.Show(
        "¿Desea guardar los cambios?",
        "Confirmación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

    if (resultado == DialogResult.Yes)
    {
        estudiantes.Add(txtNombre.Text);

        MessageBox.Show("Estudiante guardado correctamente.");

        txtNombre.Clear();
    }
    else
    {
        MessageBox.Show("Se canceló el guardado.");
    }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstEstudiantes.Items.Clear();

            foreach (string estudiante in estudiantes)
            {
                lstEstudiantes.Items.Add(estudiante);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
