namespace ParcialNo._1
{
    partial class Parcial1
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCedula = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbFechaNacimiento = new System.Windows.Forms.Label();
            this.btEnviar = new System.Windows.Forms.Button();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Franklin Gothic Book", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(634, 50);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(521, 81);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Adivine su Futuro";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(151, 291);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(196, 55);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedula.Location = new System.Drawing.Point(135, 464);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(0, 55);
            this.lbCedula.TabIndex = 2;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(1036, 455);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(634, 44);
            this.dtpFechaNacimiento.TabIndex = 3;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged_1);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(433, 302);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(292, 44);
            this.tbNombre.TabIndex = 4;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.Location = new System.Drawing.Point(151, 446);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(147, 55);
            this.lbSexo.TabIndex = 6;
            this.lbSexo.Text = "Sexo:";
            // 
            // lbFechaNacimiento
            // 
            this.lbFechaNacimiento.AutoSize = true;
            this.lbFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaNacimiento.Location = new System.Drawing.Point(1076, 290);
            this.lbFechaNacimiento.Name = "lbFechaNacimiento";
            this.lbFechaNacimiento.Size = new System.Drawing.Size(491, 55);
            this.lbFechaNacimiento.TabIndex = 7;
            this.lbFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(758, 704);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(242, 97);
            this.btEnviar.TabIndex = 8;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click_1);
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexo.Location = new System.Drawing.Point(433, 464);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(141, 45);
            this.cbSexo.TabIndex = 9;
            // 
            // Parcial1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1779, 1035);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.lbFechaNacimiento);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lbCedula);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Parcial1";
            this.Text = "Adivina tu futuro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCedula;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbFechaNacimiento;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.ComboBox cbSexo;
    }
}

