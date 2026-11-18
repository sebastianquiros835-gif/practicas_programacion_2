using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segundo_examen.ej2
{
    public partial class Form2 : Form
    {
        List<Actividad> actividades = new List<Actividad>();
        public Form2()
        {
            InitializeComponent();
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Actividad actividad = new Actividad();

            actividad.Descripcion = txtDescripcion.Text;
            actividad.Responsable = txtResponsable.Text;
            actividad.Fecha = DateTime.Now;

            actividades.Add(actividad);

            MessageBox.Show("Actividad agregada correctamente");

            txtDescripcion.Clear();
            txtResponsable.Clear();

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvActividades.Rows.Clear();
            dgvActividades.Columns.Clear();

            dgvActividades.Columns.Add("Informacion", "Información");

            dgvActividades.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

            foreach (Actividad actividad in actividades)
            {
                dgvActividades.Rows.Add(actividad.Informacion);
            }
        }
    }
}
