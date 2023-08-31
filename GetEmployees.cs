using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace pruebaConexionMySql
{
    internal class GetEmployees
    {
        private DataTable nameEmployees = new DataTable();
        private MySqlDataAdapter sqlDataAdapter;
        private MySqlCommand sqlCommand;
        private MySqlDataReader sqlDataReader;
        private MysqlConnection con;
        private string document;
        private string name;
        private string email;
        private char genre;
        private string phone;
        private Boolean married;
        private double salary;
        private Boolean temp;

        //Cargar un combobox o datagriv
        public void getNameEmployees()
        {
            con = new MysqlConnection();
            sqlCommand = new MySqlCommand("SELECT document AS DOCUMENT, name AS NAME, email AS EMAIL, genre AS GENRE, phone AS PHONE, married AS MARIED, salary AS SALARY FROM employees", con.connection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(nameEmployees);
            con.connection.Close();
        }

        //Guarda un nuevo empleado
        public void newEmployee()
        {
            con = new MysqlConnection();
            sqlCommand = new MySqlCommand("INSERT INTO employees(document,name,email,genre,phone,married,salary) VALUES(@document,@name,@email,@genre,@phone,@married,@salary)", con.connection);
            sqlCommand.Parameters.AddWithValue("@name", name);
            sqlCommand.Parameters.AddWithValue("@married", married);
            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.Parameters.AddWithValue("@genre", genre);
            sqlCommand.Parameters.AddWithValue("@salary", salary);
            sqlCommand.Parameters.AddWithValue("@phone", phone);
            sqlCommand.Parameters.AddWithValue("@document", document);
            con.connection.Open();
            sqlCommand.ExecuteNonQuery();
            con.connection.Close();
        }
        //Obtiene la información de un nuevo empleado por email
        public void getEmployee()
        {
            con = new MysqlConnection();
            sqlCommand = new MySqlCommand("SELECT * FROM employees where document = @document", con.connection);
            sqlCommand.Parameters.AddWithValue("@document", document);
            con.connection.Open();
            sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read() == true)
            {
                name = Convert.ToString(sqlDataReader[1]);
                email = Convert.ToString(sqlDataReader[2]);
                genre = Convert.ToChar(sqlDataReader[3]);
                phone = Convert.ToString(sqlDataReader[4]);
                married = Convert.ToBoolean(sqlDataReader[5]);
                salary = Convert.ToDouble(sqlDataReader[6]);
                temp = true;
                return;
            }
            else
                temp = false;
            con.connection.Close();
        }
        public void updateEmployee()
        {
            con = new MysqlConnection();
            sqlCommand = new MySqlCommand("UPDATE employees set name = @name, email = @email , phone = @phone, married = @married, salary = @salary WHERE document = @document", con.connection);
            sqlCommand.Parameters.AddWithValue("@name", name);
            sqlCommand.Parameters.AddWithValue("@married", married);
            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.Parameters.AddWithValue("@salary", salary);
            sqlCommand.Parameters.AddWithValue("@phone", phone);
            sqlCommand.Parameters.AddWithValue("@document", document);
            con.connection.Open();
            sqlCommand.ExecuteNonQuery();
            con.connection.Close();
        }

        //getters and setters
        public void setDocument(string document)
        {
            this.document = document;
        }
        public string getDocument()
        {
            return this.document;
        }
        public void setPhone(string phone)
        {
            this.phone = phone;
        }
        public string getPhone()
        {
            return this.phone;
        }
        public void setMarried(Boolean married)
        {
            this.married = married;
        }
        public Boolean getMarried()
        {
            return this.married;
        }
        public Boolean getTemp()
        {
            return this.temp;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return this.email;
        }
        public void setGenre(char genre)
        {
            this.genre = genre;
        }
        public char getGenre()
        {
            return this.genre;
        }
        public void setSalary(double salary)
        {
            this.salary = salary;
        }
        public double getSalary()
        {
            return this.salary;
        }
        public DataTable getNameEmployee()
        {
            return nameEmployees;
        }
    }
}
