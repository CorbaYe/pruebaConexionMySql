namespace pruebaConexionMySql
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonConexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonConexion
            // 
            this.botonConexion.Location = new System.Drawing.Point(108, 105);
            this.botonConexion.Name = "botonConexion";
            this.botonConexion.Size = new System.Drawing.Size(239, 64);
            this.botonConexion.TabIndex = 0;
            this.botonConexion.Text = "Probar conexión";
            this.botonConexion.UseVisualStyleBackColor = true;
            this.botonConexion.Click += new System.EventHandler(this.botonConexion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 365);
            this.Controls.Add(this.botonConexion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonConexion;
    }
}

