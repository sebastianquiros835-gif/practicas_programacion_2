using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unidad_3.ejercisiosclase
{
    public partial class practica_programada3 : Form
    {
        public practica_programada3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarDia_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtDia.Text, out int dia))
            {
                switch (dia)
                {
                    case 1:
                        MessageBox.Show("Lunes"); break;
                    case 2:
                        MessageBox.Show("Martes"); break;                    
                    case 3:
                        MessageBox.Show("Miércoles"); break;
                    case 4:
                        MessageBox.Show("Jueves"); break;
                    case 5:
                        MessageBox.Show("Viernes"); break;
                    case 6:
                        MessageBox.Show("Sábado"); break;
                    case 7:
                        MessageBox.Show("Domingo"); break;
                    default:
                        MessageBox.Show("Número de día no válido. Ingrese un número del 1 al 7."); break;
                        
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmación", buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
