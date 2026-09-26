using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplicación_con_decimales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            if (double.TryParse(txtnumero1.Text, out num1) && double.TryParse(txtnumero2.Text, out num2))
            {
                resultado = num1 * num2;
                int resultadoEntero = (int)resultado;
                textresultado.Text = resultadoEntero.ToString();
            }
            else
            {
                MessageBox.Show("Por favor ingrese números válidos.");
            }
        }
    }
}
