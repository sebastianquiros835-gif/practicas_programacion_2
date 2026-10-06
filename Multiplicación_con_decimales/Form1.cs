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
    public partial class Formmultiplicacion : Form
    {
        public Formmultiplicacion()
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
        // Validar y parsear de forma segura como enteros antes de operar
        if (!int.TryParse(txtnumero1.Text, out int num1))
        {
            MessageBox.Show("Entrada no válida en Número 1. Introduce un entero.");
            txtnumero1.Focus();
            return;
        }

        if (!int.TryParse(txtnumero2.Text, out int num2))
        {
            MessageBox.Show("Entrada no válida en Número 2. Introduce un entero.");
            txtnumero2.Focus();
            return;
        }

        int resultado = num1 * num2;
        textresultado.Text = resultado.ToString();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            textresultado.Clear();
            txtnumero1.Clear();
            txtnumero2.Clear();
        }

        private void textresultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
         this.Close();
        }
    }
}
