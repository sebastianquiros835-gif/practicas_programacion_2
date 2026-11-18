using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace segundo_examen

{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                try
                {
                    conexion.Open();

                    string consulta = "INSERT INTO Producto (Nombre, Precio, Cantidad) VALUES (@nombre, @precio, @cantidad)";

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));
                    comando.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txtCantidad.Text));

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Producto agregado correctamente");

                    txtCodigo.Clear();
                    txtNombre.Clear();
                    txtPrecio.Clear();
                    txtCantidad.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                try
                {
                    conexion.Open();

                    string consulta = "SELECT Codigo, Nombre, Precio, Cantidad FROM Producto";

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgvProductos.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
       "¿Está seguro de eliminar este producto?",
       "Confirmar eliminación",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (resultado == DialogResult.Yes)
            {
                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    try
                    {
                        conexion.Open();

                        string consulta = "DELETE FROM Producto WHERE Codigo = @codigo";

                        MySqlCommand comando = new MySqlCommand(consulta, conexion);

                        comando.Parameters.AddWithValue("@codigo", Convert.ToInt32(txtCodigo.Text));

                        int filas = comando.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show("Producto eliminado correctamente");
                            txtCodigo.Clear();
                            btnMostrar_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text = dgvProductos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                txtNombre.Text = dgvProductos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtPrecio.Text = dgvProductos.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
                txtCantidad.Text = dgvProductos.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString();
            }
        }
    }
}
