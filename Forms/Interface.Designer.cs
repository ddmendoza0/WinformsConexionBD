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
            this.butOpen = new System.Windows.Forms.Button();
            this.labConexion = new System.Windows.Forms.Label();
            this.butClose = new System.Windows.Forms.Button();
            this.labCabecera = new System.Windows.Forms.Label();
            this.butInsertJob = new System.Windows.Forms.Button();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.labMinSalary = new System.Windows.Forms.Label();
            this.labMaxSalary = new System.Windows.Forms.Label();
            this.txtMinSalary = new System.Windows.Forms.TextBox();
            this.txtMaxSalary = new System.Windows.Forms.TextBox();
            this.grbJobInsert = new System.Windows.Forms.GroupBox();
            this.lstJobs = new System.Windows.Forms.ListBox();
            this.labListJobs = new System.Windows.Forms.Label();
            this.grbJobInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // butOpen
            // 
            this.butOpen.BackColor = System.Drawing.Color.Lime;
            this.butOpen.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOpen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butOpen.Location = new System.Drawing.Point(31, 43);
            this.butOpen.Name = "butOpen";
            this.butOpen.Size = new System.Drawing.Size(350, 200);
            this.butOpen.TabIndex = 0;
            this.butOpen.Text = "OPEN";
            this.butOpen.UseVisualStyleBackColor = false;
            this.butOpen.Click += new System.EventHandler(this.butRedBig_Click);
            // 
            // labConexion
            // 
            this.labConexion.AutoSize = true;
            this.labConexion.Location = new System.Drawing.Point(143, 280);
            this.labConexion.Name = "labConexion";
            this.labConexion.Size = new System.Drawing.Size(95, 16);
            this.labConexion.TabIndex = 1;
            this.labConexion.Text = "Conexión: OFF";
            // 
            // butClose
            // 
            this.butClose.BackColor = System.Drawing.Color.Crimson;
            this.butClose.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butClose.Location = new System.Drawing.Point(31, 43);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(350, 200);
            this.butClose.TabIndex = 2;
            this.butClose.Text = "CLOSE";
            this.butClose.UseVisualStyleBackColor = false;
            this.butClose.Visible = false;
            this.butClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // labCabecera
            // 
            this.labCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.labCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCabecera.Location = new System.Drawing.Point(0, 0);
            this.labCabecera.Name = "labCabecera";
            this.labCabecera.Size = new System.Drawing.Size(1182, 40);
            this.labCabecera.TabIndex = 3;
            this.labCabecera.Text = "Pulsar para abrir la conexion";
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
            this.grbJobInsert.Location = new System.Drawing.Point(479, 43);
            this.grbJobInsert.Name = "grbJobInsert";
            this.grbJobInsert.Size = new System.Drawing.Size(271, 267);
            this.grbJobInsert.TabIndex = 11;
            this.grbJobInsert.TabStop = false;
            this.grbJobInsert.Text = "Inserting jobs BD";
            this.grbJobInsert.Visible = false;
            // 
            // lstJobs
            // 
            this.lstJobs.FormattingEnabled = true;
            this.lstJobs.ItemHeight = 16;
            this.lstJobs.Location = new System.Drawing.Point(836, 66);
            this.lstJobs.Name = "lstJobs";
            this.lstJobs.Size = new System.Drawing.Size(311, 244);
            this.lstJobs.TabIndex = 12;
            // 
            // labListJobs
            // 
            this.labListJobs.AutoSize = true;
            this.labListJobs.Location = new System.Drawing.Point(836, 41);
            this.labListJobs.Name = "labListJobs";
            this.labListJobs.Size = new System.Drawing.Size(83, 16);
            this.labListJobs.TabIndex = 13;
            this.labListJobs.Text = "Lista de jobs";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 375);
            this.Controls.Add(this.labListJobs);
            this.Controls.Add(this.lstJobs);
            this.Controls.Add(this.grbJobInsert);
            this.Controls.Add(this.labCabecera);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.labConexion);
            this.Controls.Add(this.butOpen);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Interface";
            this.Text = "Dumb nonsense";
            this.grbJobInsert.ResumeLayout(false);
            this.grbJobInsert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butOpen;
        private System.Windows.Forms.Label labConexion;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Label labCabecera;
        private System.Windows.Forms.Button butInsertJob;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labMinSalary;
        private System.Windows.Forms.Label labMaxSalary;
        private System.Windows.Forms.TextBox txtMinSalary;
        private System.Windows.Forms.TextBox txtMaxSalary;
        private System.Windows.Forms.GroupBox grbJobInsert;
        private System.Windows.Forms.ListBox lstJobs;
        private System.Windows.Forms.Label labListJobs;
    }
}

