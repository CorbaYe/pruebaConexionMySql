using MySql.Data.MySqlClient;
//using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaConexionMySql
{
    internal class Conexion
    {
        private MySqlConnection connection;
        private string server = "localhost";
        private string database = "employee";
        private string user = "admin";
        private string password = "admin";
        private string stringConnection;

        public Conexion()
        {
            stringConnection = "Database= " + database + "; DataSource= " + server +
                              "; User Id= " + user + "; password= " + password;
        }

        public MySqlConnection getConnetion()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(stringConnection);
                connection.Open();
            }
            return connection;
        }
    }
}
