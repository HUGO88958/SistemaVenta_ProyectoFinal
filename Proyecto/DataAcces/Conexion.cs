using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoFinalP2.DataAcces
{
    public class Conexion
    {
        private MySqlConnection connection;

        public Conexion()
        {
            
            string connectionString = "server=localhost;database=PuntoDeVenta;uid=root;pwd=;";
            connection = new MySqlConnection(connectionString);
        }

        // Método para obtener la conexión
        public MySqlConnection GetConnection()
        {
            return connection;
        }

    
    }
}
