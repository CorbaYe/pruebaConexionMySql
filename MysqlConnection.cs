using MySql.Data.MySqlClient;

namespace pruebaConexionMySql
{
    internal class MysqlConnection
    {
        public MySqlConnection connection = new MySqlConnection("Database = employee; DataSource = localhost; User Id = admin; password = admin");

    }
}
