namespace WinformsConexionBD
{
    partial class Interface
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
            this.labCabecera = new System.Windows.Forms.Label();
            this.butInsertJob = new System.Windows.Forms.Button();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.labMinSalary = new System.Windows.Forms.Label();
            this.labMaxSalary = new System.Windows.Forms.Label();
            this.txtMinSalary = new System.Windows.Forms.TextBox();
            this.txtMaxSalary = new System.Windows.Forms.TextBox();
            this.grbJobInsert = new System.Windows.Forms.GroupBox();
            this.lstCosas = new System.Windows.Forms.ListBox();
            this.cmbSeleccion = new System.Windows.Forms.ComboBox();
            this.labListJobs = new System.Windows.Forms.Label();
            this.grbParametros = new System.Windows.Forms.GroupBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labApellido = new System.Windows.Forms.Label();
            this.labCiudad = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.labSelec = new System.Windows.Forms.Label();
            this.butVer = new System.Windows.Forms.Button();
            this.grbJobInsert.SuspendLayout();
            this.grbParametros.SuspendLayout();
            this.SuspendLayout();
            // 
            // labCabecera
            // 
            this.labCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.labCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCabecera.Location = new System.Drawing.Point(0, 0);
            this.labCabecera.Name = "labCabecera";
            this.labCabecera.Size = new System.Drawing.Size(775, 40);
            this.labCabecera.TabIndex = 3;
            this.labCabecera.Text = "Emps y jobs";
            this.labCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // butInsertJob
            // 
            this.butInsertJob.Location = new System.Drawing.Point(77, 202);
            this.butInsertJob.Name = "butInsertJob";
            this.butInsertJob.Size = new System.Drawing.Size(162, 32);
            this.butInsertJob.TabIndex = 4;
            this.butInsertJob.Text = "Insertame un job tio";
            this.butInsertJob.UseVisualStyleBackColor = true;
            this.butInsertJob.Click += new System.EventHandler(this.butInsertJob_Click);
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(25, 49);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(214, 22);
            this.txtJobTitle.TabIndex = 5;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Location = new System.Drawing.Point(22, 30);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(84, 16);
            this.labTitle.TabIndex = 6;
            this.labTitle.Text = "Insert job title";
            // 
            // labMinSalary
            // 
            this.labMinSalary.AutoSize = true;
            this.labMinSalary.Location = new System.Drawing.Point(22, 83);
            this.labMinSalary.Name = "labMinSalary";
            this.labMinSalary.Size = new System.Drawing.Size(103, 16);
            this.labMinSalary.TabIndex = 7;
            this.labMinSalary.Text = "Insert min salary";
            // 
            // labMaxSalary
            // 
            this.labMaxSalary.AutoSize = true;
            this.labMaxSalary.Location = new System.Drawing.Point(22, 142);
            this.labMaxSalary.Name = "labMaxSalary";
            this.labMaxSalary.Size = new System.Drawing.Size(107, 16);
            this.labMaxSalary.TabIndex = 8;
            this.labMaxSalary.Text = "Insert max salary";
            // 
            // txtMinSalary
            // 
            this.txtMinSalary.Location = new System.Drawing.Point(25, 102);
            this.txtMinSalary.Name = "txtMinSalary";
            this.txtMinSalary.Size = new System.Drawing.Size(214, 22);
            this.txtMinSalary.TabIndex = 9;
            // 
            // txtMaxSalary
            // 
            this.txtMaxSalary.Location = new System.Drawing.Point(25, 161);
            this.txtMaxSalary.Name = "txtMaxSalary";
            this.txtMaxSalary.Size = new System.Drawing.Size(214, 22);
            this.txtMaxSalary.TabIndex = 10;
            // 
            // grbJobInsert
            // 
            this.grbJobInsert.Controls.Add(this.labTitle);
            this.grbJobInsert.Controls.Add(this.txtMaxSalary);
            this.grbJobInsert.Controls.Add(this.butInsertJob);
            this.grbJobInsert.Controls.Add(this.txtMinSalary);
            this.grbJobInsert.Controls.Add(this.txtJobTitle);
            this.grbJobInsert.Controls.Add(this.labMaxSalary);
            this.grbJobInsert.Controls.Add(this.labMinSalary);
            this.grbJobInsert.Location = new System.Drawing.Point(418, 55);
            this.grbJobInsert.Name = "grbJobInsert";
            this.grbJobInsert.Size = new System.Drawing.Size(271, 267);
            this.grbJobInsert.TabIndex = 11;
            this.grbJobInsert.TabStop = false;
            this.grbJobInsert.Visible = false;
            // 
            // lstCosas
            // 
            this.lstCosas.FormattingEnabled = true;
            this.lstCosas.ItemHeight = 16;
            this.lstCosas.Location = new System.Drawing.Point(378, 76);
            this.lstCosas.Name = "lstCosas";
            this.lstCosas.Size = new System.Drawing.Size(362, 244);
            this.lstCosas.TabIndex = 12;
            this.lstCosas.Visible = false;
            // 
            // cmbSeleccion
            // 
            this.cmbSeleccion.FormattingEnabled = true;
            this.cmbSeleccion.Items.AddRange(new object[] {
            "Filtrar lista de empleados",
            "Ver lista de jobs",
            "Insertar un nuevo job"});
            this.cmbSeleccion.Location = new System.Drawing.Point(23, 85);
            this.cmbSeleccion.Name = "cmbSeleccion";
            this.cmbSeleccion.Size = new System.Drawing.Size(271, 24);
            this.cmbSeleccion.TabIndex = 14;
            this.cmbSeleccion.SelectedValueChanged += new System.EventHandler(this.Seleccion_ValueChng);
            // 
            // labListJobs
            // 
            this.labListJobs.AutoSize = true;
            this.labListJobs.Location = new System.Drawing.Point(378, 51);
            this.labListJobs.Name = "labListJobs";
            this.labListJobs.Size = new System.Drawing.Size(0, 16);
            this.labListJobs.TabIndex = 13;
            this.labListJobs.Visible = false;
            // 
            // grbParametros
            // 
            this.grbParametros.Controls.Add(this.butVer);
            this.grbParametros.Controls.Add(this.cmbCiudad);
            this.grbParametros.Controls.Add(this.txtApellido);
            this.grbParametros.Controls.Add(this.txtNombre);
            this.grbParametros.Controls.Add(this.labApellido);
            this.grbParametros.Controls.Add(this.labCiudad);
            this.grbParametros.Controls.Add(this.labNombre);
            this.grbParametros.Location = new System.Drawing.Point(23, 138);
            this.grbParametros.Name = "grbParametros";
            this.grbParametros.Size = new System.Drawing.Size(271, 199);
            this.grbParametros.TabIndex = 15;
            this.grbParametros.TabStop = false;
            this.grbParametros.Text = "Parametros";
            this.grbParametros.Visible = false;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Items.AddRange(new object[] {
            "Southlake",
            "South San Francisco",
            "Seattle",
            "Toronto",
            "London",
            "Oxford",
            "Munich"});
            this.cmbCiudad.Location = new System.Drawing.Point(10, 136);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(254, 24);
            this.cmbCiudad.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(9, 84);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(255, 22);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(10, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(255, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // labApellido
            // 
            this.labApellido.AutoSize = true;
            this.labApellido.Location = new System.Drawing.Point(6, 65);
            this.labApellido.Name = "labApellido";
            this.labApellido.Size = new System.Drawing.Size(57, 16);
            this.labApellido.TabIndex = 2;
            this.labApellido.Text = "Apellido";
            // 
            // labCiudad
            // 
            this.labCiudad.AutoSize = true;
            this.labCiudad.Location = new System.Drawing.Point(6, 116);
            this.labCiudad.Name = "labCiudad";
            this.labCiudad.Size = new System.Drawing.Size(50, 16);
            this.labCiudad.TabIndex = 1;
            this.labCiudad.Text = "Ciudad";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(7, 22);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(56, 16);
            this.labNombre.TabIndex = 0;
            this.labNombre.Text = "Nombre";
            // 
            // labSelec
            // 
            this.labSelec.AutoSize = true;
            this.labSelec.Location = new System.Drawing.Point(23, 63);
            this.labSelec.Name = "labSelec";
            this.labSelec.Size = new System.Drawing.Size(65, 16);
            this.labSelec.TabIndex = 16;
            this.labSelec.Text = "Opciones";
            // 
            // butVer
            // 
            this.butVer.Location = new System.Drawing.Point(167, 170);
            this.butVer.Name = "butVer";
            this.butVer.Size = new System.Drawing.Size(97, 23);
            this.butVer.TabIndex = 17;
            this.butVer.Text = "Ver";
            this.butVer.UseVisualStyleBackColor = true;
            this.butVer.Click += new System.EventHandler(this.butVer_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 375);
            this.Controls.Add(this.labSelec);
            this.Controls.Add(this.grbParametros);
            this.Controls.Add(this.cmbSeleccion);
            this.Controls.Add(this.labListJobs);
            this.Controls.Add(this.lstCosas);
            this.Controls.Add(this.grbJobInsert);
            this.Controls.Add(this.labCabecera);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Interface";
            this.Text = "Dumb nonsense";
            this.grbJobInsert.ResumeLayout(false);
            this.grbJobInsert.PerformLayout();
            this.grbParametros.ResumeLayout(false);
            this.grbParametros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labCabecera;
        private System.Windows.Forms.Button butInsertJob;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labMinSalary;
        private System.Windows.Forms.Label labMaxSalary;
        private System.Windows.Forms.TextBox txtMinSalary;
        private System.Windows.Forms.TextBox txtMaxSalary;
        private System.Windows.Forms.GroupBox grbJobInsert;
        private System.Windows.Forms.ListBox lstCosas;
        private System.Windows.Forms.ComboBox cmbSeleccion;
        private System.Windows.Forms.Label labListJobs;
        private System.Windows.Forms.GroupBox grbParametros;
        private System.Windows.Forms.Label labSelec;
        private System.Windows.Forms.Label labApellido;
        private System.Windows.Forms.Label labCiudad;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button butVer;
    }
}

