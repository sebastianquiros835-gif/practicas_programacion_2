using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace primer_examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstCategorias.Items.Clear();
            lstCategorias.Items.Add("Excelente");
            lstCategorias.Items.Add("Muy bueno");
            lstCategorias.Items.Add("Bueno");
            lstCategorias.Items.Add("Regular");
            lstCategorias.Items.Add("Deficiente");
        }
          // Método para clasificar la nota
        private string ClasificarNota(double nota)
        {
            if (nota >= 90)
                return "Excelente";
            else if (nota >= 80)
                return "Muy bueno";
            else if (nota >= 70)
                return "Bueno";
            else if (nota >= 60)
                return "Regular";
            else
                return "Deficiente";
        }

        private void btnEvaluar_Click_1(object sender, EventArgs e)
        {
            {
                double nota;

                if (!double.TryParse(txtNota.Text, out nota) ||
                    nota < 0 || nota > 100)
                {
                    MessageBox.Show("Ingrese una nota entre 0 y 100.");
                    return;
                }

                string categoria = ClasificarNota(nota);

                lblResultado.Text = categoria;
                lstCategorias.SelectedItem = categoria;

                if (nota >= 90)
                {
                    lblResultado.BackColor = Color.LightGreen;
                }
                else if (nota < 60)
                {
                    lblResultado.BackColor = Color.LightCoral;
                }
                else
                {
                    lblResultado.BackColor = SystemColors.Control;
                }
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtNota.Clear();
            lblResultado.Text = "Resultado";
            lblResultado.BackColor = SystemColors.Control;
            lstCategorias.ClearSelected();
            txtNota.Focus();

        }
    }
}
