﻿namespace pryObregonIEFI
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNuevoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmBuscarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultaDeUnCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmConsultaGrlAllClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultaGrlClientesDeudores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultaGrlClientesCiudad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFecha = new System.Windows.Forms.ToolStripTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(378, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNuevoCliente,
            this.toolStripSeparator1,
            this.tsmBuscarCliente,
            this.tsmConsultaDeUnCliente,
            this.toolStripSeparator2,
            this.tsmConsultaGrlAllClientes,
            this.tsmConsultaGrlClientesDeudores,
            this.tsmConsultaGrlClientesCiudad,
            this.tsmFecha});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clientesToolStripMenuItem.Text = "Cliente";
            // 
            // tsmNuevoCliente
            // 
            this.tsmNuevoCliente.Name = "tsmNuevoCliente";
            this.tsmNuevoCliente.Size = new System.Drawing.Size(260, 22);
            this.tsmNuevoCliente.Text = "Nuevo Cliente";
            this.tsmNuevoCliente.Click += new System.EventHandler(this.tsmNuevoCliente_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // tsmBuscarCliente
            // 
            this.tsmBuscarCliente.Name = "tsmBuscarCliente";
            this.tsmBuscarCliente.Size = new System.Drawing.Size(260, 22);
            this.tsmBuscarCliente.Text = "Buscar Cliente";
            this.tsmBuscarCliente.Click += new System.EventHandler(this.tsmBuscarCliente_Click);
            // 
            // tsmConsultaDeUnCliente
            // 
            this.tsmConsultaDeUnCliente.Name = "tsmConsultaDeUnCliente";
            this.tsmConsultaDeUnCliente.Size = new System.Drawing.Size(260, 22);
            this.tsmConsultaDeUnCliente.Text = "Consulta de un Cliente";
            this.tsmConsultaDeUnCliente.Click += new System.EventHandler(this.tsmConsultaDeUnCliente_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(257, 6);
            // 
            // tsmConsultaGrlAllClientes
            // 
            this.tsmConsultaGrlAllClientes.Name = "tsmConsultaGrlAllClientes";
            this.tsmConsultaGrlAllClientes.Size = new System.Drawing.Size(260, 22);
            this.tsmConsultaGrlAllClientes.Text = "Listado de todos los Clientes";
            this.tsmConsultaGrlAllClientes.Click += new System.EventHandler(this.tsmConsultaGrlAllClientes_Click);
            // 
            // tsmConsultaGrlClientesDeudores
            // 
            this.tsmConsultaGrlClientesDeudores.Name = "tsmConsultaGrlClientesDeudores";
            this.tsmConsultaGrlClientesDeudores.Size = new System.Drawing.Size(260, 22);
            this.tsmConsultaGrlClientesDeudores.Text = "Listado de Clientes Deudores";
            this.tsmConsultaGrlClientesDeudores.Click += new System.EventHandler(this.tsmConsultaGrlClientesDeudores_Click);
            // 
            // tsmConsultaGrlClientesCiudad
            // 
            this.tsmConsultaGrlClientesCiudad.Name = "tsmConsultaGrlClientesCiudad";
            this.tsmConsultaGrlClientesCiudad.Size = new System.Drawing.Size(260, 22);
            this.tsmConsultaGrlClientesCiudad.Text = "Listado de Clientes de una ciudad...";
            this.tsmConsultaGrlClientesCiudad.Click += new System.EventHandler(this.tsmConsultaGrlClientesCiudad_Click);
            // 
            // tsmFecha
            // 
            this.tsmFecha.Enabled = false;
            this.tsmFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsmFecha.Name = "tsmFecha";
            this.tsmFecha.Size = new System.Drawing.Size(100, 23);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "EL MEJOR GIMNASIO DEL PLANETA!";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 255);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmNuevoCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmBuscarCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultaDeUnCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultaGrlAllClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultaGrlClientesDeudores;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultaGrlClientesCiudad;
        private System.Windows.Forms.ToolStripTextBox tsmFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

