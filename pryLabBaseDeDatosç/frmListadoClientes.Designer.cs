namespace pryLabBaseDeDatosç
{
    partial class frmListadoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoClientes));
            this.lblCantidadDos = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPromedioDos = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblTotalDos = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidadDos
            // 
            this.lblCantidadDos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDos.Location = new System.Drawing.Point(356, 385);
            this.lblCantidadDos.Name = "lblCantidadDos";
            this.lblCantidadDos.Size = new System.Drawing.Size(100, 19);
            this.lblCantidadDos.TabIndex = 26;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(244, 388);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(106, 13);
            this.lblCantidad.TabIndex = 25;
            this.lblCantidad.Text = "Cantidad de clientes:";
            // 
            // lblPromedioDos
            // 
            this.lblPromedioDos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioDos.Location = new System.Drawing.Point(356, 361);
            this.lblPromedioDos.Name = "lblPromedioDos";
            this.lblPromedioDos.Size = new System.Drawing.Size(100, 19);
            this.lblPromedioDos.TabIndex = 24;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(263, 364);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(87, 13);
            this.lblPromedio.TabIndex = 23;
            this.lblPromedio.Text = "Promedio deuda:";
            // 
            // lblTotalDos
            // 
            this.lblTotalDos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDos.Location = new System.Drawing.Point(356, 338);
            this.lblTotalDos.Name = "lblTotalDos";
            this.lblTotalDos.Size = new System.Drawing.Size(100, 19);
            this.lblTotalDos.TabIndex = 22;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(285, 341);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 13);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total deuda:";
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(12, 12);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(444, 316);
            this.dgvListado.TabIndex = 20;
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(485, 422);
            this.Controls.Add(this.lblCantidadDos);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPromedioDos);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblTotalDos);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvListado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoClientes";
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.frmListadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidadDos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPromedioDos;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblTotalDos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvListado;
    }
}