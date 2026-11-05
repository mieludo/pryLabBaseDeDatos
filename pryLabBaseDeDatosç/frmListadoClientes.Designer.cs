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
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Limite = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvDataSet = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnListarDataSet = new System.Windows.Forms.Button();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Deuda,
            this.Limite,
            this.Ciudad});
            this.dgvListado.Location = new System.Drawing.Point(12, 12);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(444, 264);
            this.dgvListado.TabIndex = 20;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Deuda
            // 
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.Name = "Deuda";
            // 
            // Limite
            // 
            this.Limite.HeaderText = "Límite";
            this.Limite.Name = "Limite";
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            // 
            // dgvDataSet
            // 
            this.dgvDataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn2,
            this.dataGridViewButtonColumn5,
            this.dataGridViewButtonColumn3});
            this.dgvDataSet.Location = new System.Drawing.Point(12, 315);
            this.dgvDataSet.Name = "dgvDataSet";
            this.dgvDataSet.Size = new System.Drawing.Size(444, 264);
            this.dgvDataSet.TabIndex = 27;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(83, 282);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(88, 23);
            this.btnImprimir.TabIndex = 28;
            this.btnImprimir.Text = "Imprimir reporte";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(182, 282);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(104, 23);
            this.btnReporte.TabIndex = 29;
            this.btnReporte.Text = "Generar reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(83, 585);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(268, 23);
            this.btnListar.TabIndex = 30;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnListarDataSet
            // 
            this.btnListarDataSet.Location = new System.Drawing.Point(294, 282);
            this.btnListarDataSet.Name = "btnListarDataSet";
            this.btnListarDataSet.Size = new System.Drawing.Size(88, 23);
            this.btnListarDataSet.TabIndex = 31;
            this.btnListarDataSet.Text = "Listar";
            this.btnListarDataSet.UseVisualStyleBackColor = true;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Nombre";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            // 
            // dataGridViewButtonColumn5
            // 
            this.dataGridViewButtonColumn5.HeaderText = "Ciudad";
            this.dataGridViewButtonColumn5.Name = "dataGridViewButtonColumn5";
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.HeaderText = "Deuda";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // prtDocumento
            // 
            this.prtDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumento_PrintPage);
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(471, 622);
            this.Controls.Add(this.btnListarDataSet);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dgvDataSet);
            this.Controls.Add(this.dgvListado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoClientes";
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.frmListadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewButtonColumn Codigo;
        private System.Windows.Forms.DataGridViewButtonColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn Deuda;
        private System.Windows.Forms.DataGridViewButtonColumn Limite;
        private System.Windows.Forms.DataGridViewButtonColumn Ciudad;
        private System.Windows.Forms.DataGridView dgvDataSet;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.Button btnListarDataSet;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Drawing.Printing.PrintDocument prtDocumento;
    }
}