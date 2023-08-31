using System;
using System.Windows.Forms;

namespace pruebaConexionMySql
{
    public partial class Form2 : Form
    {
        GetEmployees getEmployees;
        public Form2()
        {
            InitializeComponent();
            getName();
            married.SelectedIndex = 0;
            genre.SelectedIndex = 0;
        }
        //Carga el combobox con los valores obtenidos
        private void getName()
        {
            getEmployees = new GetEmployees();
            getEmployees.getNameEmployees();
            nombres.ValueMember = "name";
            nombres.DataSource = getEmployees.getNameEmployee();
            employees.DataSource = getEmployees.getNameEmployee();
        }
        //Guarda un nuevo enpleado
        private void newEmployee()
        {
            if (document.Text != "" && email.Text != "" && name.Text != "")
            {
                getEmployees = new GetEmployees();
                getEmployees.setEmail(email.Text);
                getEmployees.setName(name.Text);
                getEmployees.setPhone(phone.Text);
                getEmployees.setDocument(document.Text);
                getEmployees.setMarried(Convert.ToBoolean(married.SelectedIndex));
                getEmployees.setSalary(Convert.ToDouble(salary.Text));
                getEmployees.setGenre(Convert.ToChar(genre.Text));
                getEmployees.newEmployee();
                getName();
                MessageBox.Show("Registro confirmado.");
            }
            else
            {
                MessageBox.Show("Rellenar todos los campos obligatorios.");
            }
        }
        private void validarEmployeeSave(string document)
        {
            getEmployees = new GetEmployees();
            if (document != "")
            {
                getEmployees.setDocument(document);
                getEmployees.getEmployee();
                if (getEmployees.getTemp())
                {
                    MessageBox.Show("No se pueden agregar registros duplicados.");
                }
                else
                {
                    newEmployee();
                }
            }
        }
        //Busca la información de un nuevo empleado por Email
        public void getEmployeeForDocument()
        {
            name.Text = getEmployees.getName();
            if (getEmployees.getGenre() == 'M')
                genre.SelectedIndex = 0;
            else
                genre.SelectedIndex = 1;
            married.SelectedIndex = Convert.ToInt32(getEmployees.getMarried());
            salary.Text = "" + getEmployees.getSalary();
            email.Text = getEmployees.getEmail();
            phone.Text = getEmployees.getPhone();
        }
        private void validarEmployeeSearch(string document)
        {
            getEmployees = new GetEmployees();
            if (document != "")
            {
                getEmployees.setDocument(document);
                getEmployees.getEmployee();
                if (getEmployees.getTemp())
                {
                    getEmployeeForDocument();
                    this.document.Enabled = false;
                    genre.Enabled = false;
                    guardar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Registro no encontrado.");
                }
            }
            else
                MessageBox.Show("Debe ingresar un documento para continuar.");
        }
        //Actualizar un empleado
        private void updateEmployee()
        {
            if (document.Text != "" && email.Text != "" && name.Text != "")
            {
                getEmployees = new GetEmployees();
                getEmployees.setEmail(email.Text);
                getEmployees.setName(name.Text);
                getEmployees.setPhone(phone.Text);
                getEmployees.setDocument(document.Text);
                getEmployees.setMarried(Convert.ToBoolean(married.SelectedIndex));
                getEmployees.setSalary(Convert.ToDouble(salary.Text));
                getEmployees.updateEmployee();
                getName();
                MessageBox.Show("Registro actualizado con éxito.");
            }
            else
            {
                MessageBox.Show("Rellenar todos los campos obligatorios.");
            }
        }
        //Limpiar campos
        private void guardar_Click(object sender, EventArgs e)
        {
            validarEmployeeSave(document.Text);
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            validarEmployeeSearch(document.Text);
        }

        private void botonNew_Click(object sender, EventArgs e)
        {
            name.Text = "";
            email.Text = "";
            document.Text = "";
            salary.Text = "";
            phone.Text = "";
            document.Enabled = true;
            genre.Enabled = true;
            guardar.Enabled = true;
            nombres.SelectedIndex = 0;
            married.SelectedIndex = 0;
            genre.SelectedIndex = 0;
            document.Focus();
        }

        private void update_Click(object sender, EventArgs e)
        {
            updateEmployee();
        }
    }
}
