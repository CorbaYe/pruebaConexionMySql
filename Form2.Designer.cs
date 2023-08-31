namespace pruebaConexionMySql
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombres = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guardar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.employees = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.document = new System.Windows.Forms.TextBox();
            this.genre = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.married = new System.Windows.Forms.ComboBox();
            this.update = new System.Windows.Forms.Button();
            this.botonNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employees)).BeginInit();
            this.SuspendLayout();
            // 
            // nombres
            // 
            this.nombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nombres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nombres.FormattingEnabled = true;
            this.nombres.Location = new System.Drawing.Point(34, 18);
            this.nombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombres.Name = "nombres";
            this.nombres.Size = new System.Drawing.Size(366, 28);
            this.nombres.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(148, 128);
            this.email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(228, 26);
            this.email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(148, 92);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(164, 26);
            this.name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Casado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Salario";
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(148, 277);
            this.salary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(146, 26);
            this.salary.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Genero";
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(56, 337);
            this.guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(152, 35);
            this.guardar.TabIndex = 8;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(216, 337);
            this.buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(160, 35);
            this.buscar.TabIndex = 9;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // employees
            // 
            this.employees.AllowUserToAddRows = false;
            this.employees.AllowUserToDeleteRows = false;
            this.employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.employees.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employees.Location = new System.Drawing.Point(417, 18);
            this.employees.Name = "employees";
            this.employees.ReadOnly = true;
            this.employees.RowHeadersWidth = 62;
            this.employees.RowTemplate.Height = 28;
            this.employees.Size = new System.Drawing.Size(735, 399);
            this.employees.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Documento";
            // 
            // document
            // 
            this.document.Location = new System.Drawing.Point(148, 56);
            this.document.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.document.Name = "document";
            this.document.Size = new System.Drawing.Size(146, 26);
            this.document.TabIndex = 1;
            // 
            // genre
            // 
            this.genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genre.FormattingEnabled = true;
            this.genre.Items.AddRange(new object[] {
            "M",
            "F"});
            this.genre.Location = new System.Drawing.Point(148, 165);
            this.genre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(82, 28);
            this.genre.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Telefono";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(148, 203);
            this.phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(113, 26);
            this.phone.TabIndex = 5;
            // 
            // married
            // 
            this.married.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.married.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.married.FormattingEnabled = true;
            this.married.Items.AddRange(new object[] {
            "NO",
            "SI"});
            this.married.Location = new System.Drawing.Point(148, 239);
            this.married.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.married.Name = "married";
            this.married.Size = new System.Drawing.Size(82, 28);
            this.married.TabIndex = 6;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(96, 382);
            this.update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(112, 35);
            this.update.TabIndex = 10;
            this.update.Text = "Actualizar";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // botonNew
            // 
            this.botonNew.Location = new System.Drawing.Point(216, 382);
            this.botonNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonNew.Name = "botonNew";
            this.botonNew.Size = new System.Drawing.Size(112, 35);
            this.botonNew.TabIndex = 11;
            this.botonNew.Text = "Nuevo";
            this.botonNew.UseVisualStyleBackColor = true;
            this.botonNew.Click += new System.EventHandler(this.botonNew_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 436);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.botonNew);
            this.Controls.Add(this.update);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.document);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.married);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.nombres);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox nombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.DataGridView employees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox document;
        private System.Windows.Forms.ComboBox genre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.ComboBox married;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button botonNew;
    }
}