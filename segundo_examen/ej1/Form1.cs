using segundo_examen.ej1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segundo_examen
{
    public partial class Form1 : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdentifacion.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese la identificación y el nombre del empleado.");
                return;
            }

            if (!double.TryParse(txtSalario.Text, out double salario) || salario < 0)
            {
                MessageBox.Show("Ingrese un salario válido mayor o igual que cero.");
                return;
            }

            Empleado empleado = new Empleado();

            empleado.Identificacion = txtIdentifacion.Text;
            empleado.Nombre = txtNombre.Text;
            empleado.Salario = salario;

            empleados.Add(empleado);

            MessageBox.Show("Empleado agregado correctamente");

            txtIdentifacion.Clear();
            txtNombre.Clear();
            txtSalario.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Rows.Clear();

            dgvEmpleados.Columns.Clear();

            dgvEmpleados.Columns.Add("Identificacion", "Identificación");
            dgvEmpleados.Columns.Add("Nombre", "Nombre");
            dgvEmpleados.Columns.Add("Salario", "Salario");
            dgvEmpleados.Columns.Add("SalarioAnual", "Salario anual");

            foreach (Empleado empleado in empleados)
            {
                dgvEmpleados.Rows.Add(
                    empleado.Identificacion,
                    empleado.Nombre,
                    empleado.Salario,
                    empleado.SalarioAnual);


            }
        }

        
    }
}
