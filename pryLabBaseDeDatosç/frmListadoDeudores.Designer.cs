namespace pryLabBaseDeDatosç
{
    partial class frmListadoDeudores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoDeudores));
            this.lblCantidadDos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPromedioDos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalDos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidadDos
            // 
            this.lblCantidadDos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDos.Location = new System.Drawing.Point(236, 390);
            this.lblCantidadDos.Name = "lblCantidadDos";
            this.lblCantidadDos.Size = new System.Drawing.Size(107, 19);
            this.lblCantidadDos.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cantidad de clientes:";
            // 
            // lblPromedioDos
            // 
            this.lblPromedioDos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioDos.Location = new System.Drawing.Point(236, 366);
            this.lblPromedioDos.Name = "lblPromedioDos";
            this.lblPromedioDos.Size = new System.Drawing.Size(107, 19);
            this.lblPromedioDos.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Promedio deuda:";
            // 
            // lblTotalDos
            // 
            this.lblTotalDos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDos.Location = new System.Drawing.Point(236, 343);
            this.lblTotalDos.Name = "lblTotalDos";
            this.lblTotalDos.Size = new System.Drawing.Size(107, 19);
            this.lblTotalDos.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total deuda:";
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colDeuda});
            this.dgvListado.Location = new System.Drawing.Point(12, 12);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(344, 316);
            this.dgvListado.TabIndex = 14;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.FillWeight = 200F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colDeuda
            // 
            this.colDeuda.HeaderText = "Deuda";
            this.colDeuda.Name = "colDeuda";
            // 
            // frmListadoDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(366, 427);
            this.Controls.Add(this.lblCantidadDos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPromedioDos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalDos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoDeudores";
            this.Text = "frmListadoDeudores";
            this.Load += new System.EventHandler(this.frmListadoDeudores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidadDos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPromedioDos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalDos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
    }
}