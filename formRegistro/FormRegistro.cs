using System;
using System.Drawing;
using System.Windows.Forms;

namespace formRegistro
{
    public partial class FormRegistro : Form
    {
        // Último registro guardado
        private (string Nombre, int Edad, string Genero, string Direccion) ultimoRegistro;
        private bool tieneRegistro = false;

        public FormRegistro()
        {
            InitializeComponent();
           
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string genero = txtgenero.Text;
            string direccion = txtdireccion.Text;

            // Validar campos requeridos              
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(txtedad.Text) || string.IsNullOrWhiteSpace(genero) || string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            // Validar que la edad sea un número entero
            if (!int.TryParse(txtedad.Text, out int edad))
            {
                MessageBox.Show("Edad no válida. Introduzca un número entero.");
                return;
            }
            // Guardar solo el último registro
            ultimoRegistro = (nombre.Trim(), edad, genero.Trim(), direccion.Trim());
            tieneRegistro = true;
            MessageBox.Show("Registro guardado correctamente.");

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            if (!tieneRegistro)
            {
                if (this.txtpantalla != null) this.txtpantalla.Text = "No hay registro guardado.";
                return;
            }

            string texto = $"Nombre: {ultimoRegistro.Nombre}{Environment.NewLine}Edad: {ultimoRegistro.Edad}{Environment.NewLine}Género: {ultimoRegistro.Genero}{Environment.NewLine}Dirección: {ultimoRegistro.Direccion}";
            if (this.txtpantalla != null) this.txtpantalla.Text = texto;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtdireccion.Clear();
            txtedad.Clear();
            txtnombre.Clear();
            txtgenero.Clear();  
            txtpantalla.Clear();
        }

        private void txtpantalla_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
