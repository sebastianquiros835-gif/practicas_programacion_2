using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad5.Practica5;

namespace Unidad5.Practica5
{
    public partial class practica5 : Form
    {
        public practica5()
        {
            InitializeComponent();
        }
        List<Empleado> empleados = new List<Empleado>();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre");
                return;
            }

            if (!int.TryParse(txtAnoNacimiento.Text, out int anio))
            {
                MessageBox.Show("Ingrese un año válido");
                return;
            }

            if (!decimal.TryParse(txtSueldo.Text, out decimal sueldo))
            {
                MessageBox.Show("Ingrese un sueldo válido");
                return;
            }

            if (sueldo <= 0)
            {
                MessageBox.Show("El sueldo debe ser mayor a cero");
                return;
            }

            Empleado nuevo = new Empleado(txtNombre.Text, anio, sueldo);

            empleados.Add(nuevo);

            dgvTrabajador.DataSource = null;
            dgvTrabajador.DataSource = empleados;

            MessageBox.Show("Empleado agregado correctamente");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                DialogResult respuesta = MessageBox.Show("¿Desea guardar los cambios?","Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    dgvTrabajador.DataSource = null;
                    dgvTrabajador.DataSource = empleados;

                    MessageBox.Show("Cambios guardados correctamente");







                }
            }

        }

        private void practica5_Load(object sender, EventArgs e)
        {

        }
    }
}

