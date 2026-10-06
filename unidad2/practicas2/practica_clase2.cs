using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unidad2
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class practica_clase2 : Form
    {
        public practica_clase2()
        {
            InitializeComponent();
        }

        private void practica_clase2_Load(object sender, EventArgs e)
        {
            listBoxColores.Items.Add("Rojo");
            listBoxColores.Items.Add("Morado");
            listBoxColores.Items.Add("Verde");

            listBoxColores.BackColor = Color.LightBlue;
            this.BackColor = Color.LightGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtnumero1.Text); 
            int numero2 = Convert.ToInt32(txtnumero2.Text);
           
            
            if (numero1 > numero2)
            {
                MessageBox.Show("El número mayor es: " + numero1);
            }
            else if (numero2 > numero1)
            {
                MessageBox.Show("El número mayor es: " + numero2);
            }
            else
            {
                MessageBox.Show("Los números son iguales");
            }

        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void listBoxColores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sadwdsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void moradoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void barraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
               this.BackColor = colorDialog1.Color;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            listBoxColores.Items.Add(" se seleccionó Rojo");
        }

        private void btnmorado_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.MediumPurple;
            listBoxColores.Items.Add(" se seleccionó Morado");
        }

        private void btnverde_Click_1(object sender, EventArgs e)

        {
            this.BackColor = Color.Green;
            listBoxColores.Items.Add(" se seleccionó Verde");
        }

        
    }
}
