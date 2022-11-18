namespace pryObregonIEFI
{
    partial class frmConsultaClientes
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
            this.dgvConsultaClientes = new System.Windows.Forms.DataGridView();
            this.columnaUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSeis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSiete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCinco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCuatro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSaldoMenor = new System.Windows.Forms.Label();
            this.lblPromedioSaldos = new System.Windows.Forms.Label();
            this.lblSaldoMayor = new System.Windows.Forms.Label();
            this.txtPromedioSaldos = new System.Windows.Forms.TextBox();
            this.txtSaldoMayor = new System.Windows.Forms.TextBox();
            this.txtSaldoMenor = new System.Windows.Forms.TextBox();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblTotalSaldos = new System.Windows.Forms.Label();
            this.txtCantidadClientes = new System.Windows.Forms.TextBox();
            this.txtTotalSaldos = new System.Windows.Forms.TextBox();
            this.btnListarTotalClientes = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaClientes
            // 
            this.dgvConsultaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaUno,
            this.columnaDos,
            this.columnaTres,
            this.columnaSeis,
            this.columnaSiete,
            this.columnaCinco,
            this.columnaCuatro});
            this.dgvConsultaClientes.Location = new System.Drawing.Point(12, 12);
            this.dgvConsultaClientes.Name = "dgvConsultaClientes";
            this.dgvConsultaClientes.Size = new System.Drawing.Size(742, 239);
            this.dgvConsultaClientes.TabIndex = 0;
            // 
            // columnaUno
            // 
            this.columnaUno.HeaderText = "DNI";
            this.columnaUno.Name = "columnaUno";
            this.columnaUno.ReadOnly = true;
            // 
            // columnaDos
            // 
            this.columnaDos.HeaderText = "Nombre";
            this.columnaDos.Name = "columnaDos";
            this.columnaDos.ReadOnly = true;
            // 
            // columnaTres
            // 
            this.columnaTres.HeaderText = "Apellido";
            this.columnaTres.Name = "columnaTres";
            this.columnaTres.ReadOnly = true;
            // 
            // columnaSeis
            // 
            this.columnaSeis.HeaderText = "Barrio";
            this.columnaSeis.Name = "columnaSeis";
            this.columnaSeis.ReadOnly = true;
            // 
            // columnaSiete
            // 
            this.columnaSiete.HeaderText = "Dirección";
            this.columnaSiete.Name = "columnaSiete";
            this.columnaSiete.ReadOnly = true;
            // 
            // columnaCinco
            // 
            this.columnaCinco.HeaderText = "Actividad";
            this.columnaCinco.Name = "columnaCinco";
            this.columnaCinco.ReadOnly = true;
            // 
            // columnaCuatro
            // 
            this.columnaCuatro.HeaderText = "Saldo";
            this.columnaCuatro.Name = "columnaCuatro";
            this.columnaCuatro.ReadOnly = true;
            // 
            // lblSaldoMenor
            // 
            this.lblSaldoMenor.AutoSize = true;
            this.lblSaldoMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoMenor.Location = new System.Drawing.Point(229, 259);
            this.lblSaldoMenor.Name = "lblSaldoMenor";
            this.lblSaldoMenor.Size = new System.Drawing.Size(70, 13);
            this.lblSaldoMenor.TabIndex = 13;
            this.lblSaldoMenor.Text = "Saldo Menor:";
            // 
            // lblPromedioSaldos
            // 
            this.lblPromedioSaldos.AutoSize = true;
            this.lblPromedioSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioSaldos.Location = new System.Drawing.Point(16, 289);
            this.lblPromedioSaldos.Name = "lblPromedioSaldos";
            this.lblPromedioSaldos.Size = new System.Drawing.Size(89, 13);
            this.lblPromedioSaldos.TabIndex = 10;
            this.lblPromedioSaldos.Text = "Promedio Saldos:";
            // 
            // lblSaldoMayor
            // 
            this.lblSaldoMayor.AutoSize = true;
            this.lblSaldoMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoMayor.Location = new System.Drawing.Point(230, 287);
            this.lblSaldoMayor.Name = "lblSaldoMayor";
            this.lblSaldoMayor.Size = new System.Drawing.Size(69, 13);
            this.lblSaldoMayor.TabIndex = 14;
            this.lblSaldoMayor.Text = "Saldo Mayor:";
            // 
            // txtPromedioSaldos
            // 
            this.txtPromedioSaldos.Enabled = false;
            this.txtPromedioSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedioSaldos.Location = new System.Drawing.Point(111, 284);
            this.txtPromedioSaldos.Name = "txtPromedioSaldos";
            this.txtPromedioSaldos.ReadOnly = true;
            this.txtPromedioSaldos.Size = new System.Drawing.Size(115, 21);
            this.txtPromedioSaldos.TabIndex = 12;
            // 
            // txtSaldoMayor
            // 
            this.txtSaldoMayor.Enabled = false;
            this.txtSaldoMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoMayor.Location = new System.Drawing.Point(305, 284);
            this.txtSaldoMayor.Name = "txtSaldoMayor";
            this.txtSaldoMayor.ReadOnly = true;
            this.txtSaldoMayor.Size = new System.Drawing.Size(115, 21);
            this.txtSaldoMayor.TabIndex = 16;
            // 
            // txtSaldoMenor
            // 
            this.txtSaldoMenor.Enabled = false;
            this.txtSaldoMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoMenor.Location = new System.Drawing.Point(305, 257);
            this.txtSaldoMenor.Name = "txtSaldoMenor";
            this.txtSaldoMenor.ReadOnly = true;
            this.txtSaldoMenor.Size = new System.Drawing.Size(115, 21);
            this.txtSaldoMenor.TabIndex = 15;
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadClientes.Location = new System.Drawing.Point(426, 262);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(74, 13);
            this.lblCantidadClientes.TabIndex = 18;
            this.lblCantidadClientes.Text = "Total Clientes:";
            // 
            // lblTotalSaldos
            // 
            this.lblTotalSaldos.AutoSize = true;
            this.lblTotalSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaldos.Location = new System.Drawing.Point(36, 262);
            this.lblTotalSaldos.Name = "lblTotalSaldos";
            this.lblTotalSaldos.Size = new System.Drawing.Size(69, 13);
            this.lblTotalSaldos.TabIndex = 17;
            this.lblTotalSaldos.Text = "Total Saldos:";
            // 
            // txtCantidadClientes
            // 
            this.txtCantidadClientes.Enabled = false;
            this.txtCantidadClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadClientes.Location = new System.Drawing.Point(506, 257);
            this.txtCantidadClientes.Name = "txtCantidadClientes";
            this.txtCantidadClientes.ReadOnly = true;
            this.txtCantidadClientes.Size = new System.Drawing.Size(115, 21);
            this.txtCantidadClientes.TabIndex = 21;
            // 
            // txtTotalSaldos
            // 
            this.txtTotalSaldos.Enabled = false;
            this.txtTotalSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSaldos.Location = new System.Drawing.Point(111, 257);
            this.txtTotalSaldos.Name = "txtTotalSaldos";
            this.txtTotalSaldos.ReadOnly = true;
            this.txtTotalSaldos.Size = new System.Drawing.Size(115, 21);
            this.txtTotalSaldos.TabIndex = 20;
            // 
            // btnListarTotalClientes
            // 
            this.btnListarTotalClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTotalClientes.Location = new System.Drawing.Point(645, 257);
            this.btnListarTotalClientes.Name = "btnListarTotalClientes";
            this.btnListarTotalClientes.Size = new System.Drawing.Size(109, 48);
            this.btnListarTotalClientes.TabIndex = 19;
            this.btnListarTotalClientes.Text = "Listar";
            this.btnListarTotalClientes.UseVisualStyleBackColor = true;
            this.btnListarTotalClientes.Click += new System.EventHandler(this.btnListarTotalClientes_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 325);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 35;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 360);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblCantidadClientes);
            this.Controls.Add(this.lblTotalSaldos);
            this.Controls.Add(this.txtCantidadClientes);
            this.Controls.Add(this.txtTotalSaldos);
            this.Controls.Add(this.btnListarTotalClientes);
            this.Controls.Add(this.lblSaldoMenor);
            this.Controls.Add(this.lblPromedioSaldos);
            this.Controls.Add(this.lblSaldoMayor);
            this.Controls.Add(this.txtPromedioSaldos);
            this.Controls.Add(this.txtSaldoMayor);
            this.Controls.Add(this.txtSaldoMenor);
            this.Controls.Add(this.dgvConsultaClientes);
            this.Name = "frmConsultaClientes";
            this.Text = "Listado de todos los clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaUno;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTres;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSeis;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSiete;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCinco;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCuatro;
        private System.Windows.Forms.Label lblSaldoMenor;
        private System.Windows.Forms.Label lblPromedioSaldos;
        private System.Windows.Forms.Label lblSaldoMayor;
        private System.Windows.Forms.TextBox txtPromedioSaldos;
        private System.Windows.Forms.TextBox txtSaldoMayor;
        private System.Windows.Forms.TextBox txtSaldoMenor;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblTotalSaldos;
        private System.Windows.Forms.TextBox txtCantidadClientes;
        private System.Windows.Forms.TextBox txtTotalSaldos;
        private System.Windows.Forms.Button btnListarTotalClientes;
        private System.Windows.Forms.Button btnVolver;
    }
}