namespace pryLabBaseDeDatosç
{
    partial class frmAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregar));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblTitulo.Location = new System.Drawing.Point(31, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(153, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ingreso de clientes";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnGuardar);
            this.gbDatos.Controls.Add(this.cboCiudad);
            this.gbDatos.Controls.Add(this.txtLimite);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lblCiudad);
            this.gbDatos.Controls.Add(this.lblLimite);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Location = new System.Drawing.Point(35, 70);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(519, 310);
            this.gbDatos.TabIndex = 1;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Agregar:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(31, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(111, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre y apellido:";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimite.Location = new System.Drawing.Point(31, 128);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(105, 15);
            this.lblLimite.TabIndex = 1;
            this.lblLimite.Text = "Límite de crédito:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(31, 208);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(47, 15);
            this.lblCiudad.TabIndex = 2;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(198, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(198, 123);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(248, 20);
            this.txtLimite.TabIndex = 4;
            // 
            // cboCiudad
            // 
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Location = new System.Drawing.Point(198, 201);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(248, 21);
            this.cboCiudad.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(312, 259);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(134, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar cliente";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(591, 418);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregar";
            this.Text = "Agregar clientes";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cboCiudad;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtNombre;
    }
}