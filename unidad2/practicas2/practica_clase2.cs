using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unidad2
{
    public partial class practica_clase2 : Form
    {
        public practica_clase2()
        {
            InitializeComponent();
        }

        private void practica_clase2_Load(object sender, EventArgs e)
        {

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

        
    }
}
