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
    public partial class ejercicio3 : Form
    {
        private int numero1;

        public ejercicio3()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {


            if (int.TryParse(txtNumero.Text, result: out numero1))
            {
          
                switch (numero1)
                {
                    case 1:
                        MessageBox.Show("seleccionaste el 1"); break;
                    case 2:
                        MessageBox.Show("seleccionaste el 2"); break;
                    case 3:
                        MessageBox.Show("seleccionaste el 3"); break;
                    case 4:
                        MessageBox.Show("seleccionaste el 4"); break;
                    default:
                        MessageBox.Show("Opcion no valida, ingrese un numero del 1 al 4"); break;
             
                }
            }
            else 
            {
                
                MessageBox.Show("Por favor, ingrese un número válido.");
                return;
            }
        }
    }
}
