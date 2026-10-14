namespace pryLabBaseDeDatosç
{
    partial class frmBuscar
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNombreDos = new System.Windows.Forms.Label();
            this.lblDeudaDos = new System.Windows.Forms.Label();
            this.lblLimiteDos = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(94, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo del cliente:";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(13, 97);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(89, 13);
            this.lblDatos.TabIndex = 1;
            this.lblDatos.Text = "Datos del cliente:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(143, 144);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(143, 179);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(42, 13);
            this.lblDeuda.TabIndex = 3;
            this.lblDeuda.Text = "Deuda:";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(143, 219);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(89, 13);
            this.lblLimite.TabIndex = 4;
            this.lblLimite.Text = "Límite de crédito:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(185, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(122, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblNombreDos
            // 
            this.lblNombreDos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreDos.Location = new System.Drawing.Point(238, 144);
            this.lblNombreDos.Name = "lblNombreDos";
            this.lblNombreDos.Size = new System.Drawing.Size(69, 13);
            this.lblNombreDos.TabIndex = 6;
            // 
            // lblDeudaDos
            // 
            this.lblDeudaDos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeudaDos.Location = new System.Drawing.Point(238, 179);
            this.lblDeudaDos.Name = "lblDeudaDos";
            this.lblDeudaDos.Size = new System.Drawing.Size(69, 13);
            this.lblDeudaDos.TabIndex = 7;
            // 
            // lblLimiteDos
            // 
            this.lblLimiteDos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLimiteDos.Location = new System.Drawing.Point(238, 219);
            this.lblLimiteDos.Name = "lblLimiteDos";
            this.lblLimiteDos.Size = new System.Drawing.Size(69, 13);
            this.lblLimiteDos.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(138, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(169, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 277);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblLimiteDos);
            this.Controls.Add(this.lblDeudaDos);
            this.Controls.Add(this.lblNombreDos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblLimite);
            this.Controls.Add(this.lblDeuda);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmBuscar";
            this.Text = "Buscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNombreDos;
        private System.Windows.Forms.Label lblDeudaDos;
        private System.Windows.Forms.Label lblLimiteDos;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}