namespace pryLabBaseDeDatosç
{
    partial class frmDataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataBase));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUnClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTodosLosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesDeudoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesOrdenadosPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.agregarNuevosClientesToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // agregarNuevosClientesToolStripMenuItem
            // 
            this.agregarNuevosClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bToolStripMenuItem,
            this.buscarClientesToolStripMenuItem,
            this.consultaDeUnClienteToolStripMenuItem,
            this.listadoDeTodosLosClientesToolStripMenuItem,
            this.clientesDeudoresToolStripMenuItem,
            this.clientesOrdenadosPorToolStripMenuItem});
            this.agregarNuevosClientesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.agregarNuevosClientesToolStripMenuItem.Name = "agregarNuevosClientesToolStripMenuItem";
            this.agregarNuevosClientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarNuevosClientesToolStripMenuItem.Text = "Clientes";
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.bToolStripMenuItem.Text = "Agregar nuevos clientes...";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
            // 
            // buscarClientesToolStripMenuItem
            // 
            this.buscarClientesToolStripMenuItem.Name = "buscarClientesToolStripMenuItem";
            this.buscarClientesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.buscarClientesToolStripMenuItem.Text = "Buscar clientes";
            this.buscarClientesToolStripMenuItem.Click += new System.EventHandler(this.buscarClientesToolStripMenuItem_Click);
            // 
            // consultaDeUnClienteToolStripMenuItem
            // 
            this.consultaDeUnClienteToolStripMenuItem.Name = "consultaDeUnClienteToolStripMenuItem";
            this.consultaDeUnClienteToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.consultaDeUnClienteToolStripMenuItem.Text = "Consulta de un cliente";
            // 
            // listadoDeTodosLosClientesToolStripMenuItem
            // 
            this.listadoDeTodosLosClientesToolStripMenuItem.Name = "listadoDeTodosLosClientesToolStripMenuItem";
            this.listadoDeTodosLosClientesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.listadoDeTodosLosClientesToolStripMenuItem.Text = "Listado de todos los clientes";
            this.listadoDeTodosLosClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTodosLosClientesToolStripMenuItem_Click);
            // 
            // clientesDeudoresToolStripMenuItem
            // 
            this.clientesDeudoresToolStripMenuItem.Name = "clientesDeudoresToolStripMenuItem";
            this.clientesDeudoresToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.clientesDeudoresToolStripMenuItem.Text = "Clientes deudores";
            // 
            // clientesOrdenadosPorToolStripMenuItem
            // 
            this.clientesOrdenadosPorToolStripMenuItem.Name = "clientesOrdenadosPorToolStripMenuItem";
            this.clientesOrdenadosPorToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.clientesOrdenadosPorToolStripMenuItem.Text = "Clientes ordenados por";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // frmDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDataBase";
            this.Text = "Menú - Base de datos.";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUnClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTodosLosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesDeudoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesOrdenadosPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
    }
}

