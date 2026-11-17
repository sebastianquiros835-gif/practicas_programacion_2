using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad7_BD.ejercicios;

namespace Unidad_7BD
{
    public partial class ejercisios : Form
    {
        public ejercisios()
        {
            InitializeComponent();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            try
            {
                using (MySqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    MessageBox.Show("Conexión exitosa con la base de datos tienda");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (txtNombre.Text.Trim() == "" || txtCorreo.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            Conexion conexion = new Conexion();

            try
            {
                using (MySqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "INSERT INTO clientes (Nombre, Correo) VALUES (@Nombre, @Correo)";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text.Trim());

                        cmd.ExecuteNonQuery();
                        
                        MySqlCommand cmdId = new MySqlCommand("SELECT LAST_INSERT_ID()", cn);

                        txtIdCliente.Text = cmdId.ExecuteScalar().ToString();

                        MessageBox.Show("Cliente insertado correctamente");

                        txtNombre.Clear();
                        txtCorreo.Clear();
                        txtIdCliente.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del cliente");
                return;
            }

            Conexion conexion = new Conexion();

            try
            {
                using (MySqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT IdCliente, Nombre, Correo FROM clientes WHERE Nombre = @Nombre";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtBuscar.Text.Trim());

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtIdCliente.Text = reader["IdCliente"].ToString();
                                txtNombre.Text = reader["Nombre"].ToString();
                                txtCorreo.Text = reader["Correo"].ToString();

                                MessageBox.Show("Cliente encontrado");
                            }
                            else
                            {
                                MessageBox.Show("Cliente no encontrado");

                                txtIdCliente.Clear();
                                txtNombre.Clear();
                                txtCorreo.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void brnModificar_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Trim() == "" ||
         txtNombre.Text.Trim() == "" ||
         txtCorreo.Text.Trim() == "")
            {
                MessageBox.Show("Primero debe buscar un cliente y completar los datos");
                return;
            }

            Conexion conexion = new Conexion();

            try
            {
                using (MySqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "UPDATE clientes SET Nombre = @Nombre, Correo = @Correo WHERE IdCliente = @IdCliente";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text.Trim());
                        cmd.Parameters.AddWithValue("@IdCliente", txtIdCliente.Text.Trim());

                        int resultado = cmd.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Cliente actualizado correctamente en la base de datos");
                        }
                        else
                        {
                            MessageBox.Show("No se realizaron cambios");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Trim() == "")
            {
                MessageBox.Show("Primero debe buscar un cliente");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea eliminar este cliente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Conexion conexion = new Conexion();

                try
                {
                    using (MySqlConnection cn = conexion.ObtenerConexion())
                    {
                        cn.Open();

                        string consulta = "DELETE FROM clientes WHERE IdCliente = @IdCliente";

                        using (MySqlCommand cmd = new MySqlCommand(consulta, cn))
                        {
                            cmd.Parameters.AddWithValue("@IdCliente", txtIdCliente.Text.Trim());

                            int resultado = cmd.ExecuteNonQuery();

                            if (resultado > 0)
                            {
                                MessageBox.Show("Cliente eliminado correctamente");

                                txtIdCliente.Clear();
                                txtNombre.Clear();
                                txtCorreo.Clear();
                                txtBuscar.Clear();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el cliente");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ejercisios_Load(object sender, EventArgs e)
        {
            
        }
    }
}
