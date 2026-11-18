using MySql.Data.MySqlClient;

namespace segundo_examen
{
    public class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            string cadena = "Server=localhost;Database=Tienda;Uid=root;Pwd=*A123456789*;";

            return new MySqlConnection(cadena);
        }
    }
}