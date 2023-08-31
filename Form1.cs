using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaConexionMySql
{
    public partial class Form1 : Form
    {
        private Conexion connection;
        public Form1()
        {
            InitializeComponent();
            connection = new Conexion();
        }

        private void botonConexion_Click(object sender, EventArgs e)
        {
            if(connection.getConnetion() != null)
            {
                MessageBox.Show("Conexion establecida");
            }
        }
    }
}
