using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unidad_3
{
    public partial class ejercicio1 : Form
    {
        public ejercicio1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtopcion.Text);

            switch (numero1)
            {
                case 1:
                    MessageBox.Show("Opción 1 seleccionada"); break;
                case 2:
                    MessageBox.Show("Opción 2 seleccionada"); break;
                case 3:
                    MessageBox.Show("Opción 3 seleccionada"); break;
                default:
                    MessageBox.Show("Opción no válida"); break;
            }
        }
    }
}
