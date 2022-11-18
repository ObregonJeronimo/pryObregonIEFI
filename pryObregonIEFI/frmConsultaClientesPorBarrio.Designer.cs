namespace pryObregonIEFI
{
    partial class frmConsultaClientesPorBarrio
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnReportar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.columnaCero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.lblActiviadadConsulta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 285);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 42;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(362, 36);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(97, 78);
            this.btnImprimir.TabIndex = 41;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnReportar
            // 
            this.btnReportar.Enabled = false;
            this.btnReportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportar.Location = new System.Drawing.Point(362, 120);
            this.btnReportar.Name = "btnReportar";
            this.btnReportar.Size = new System.Drawing.Size(97, 78);
            this.btnReportar.TabIndex = 40;
            this.btnReportar.Text = "Reportar";
            this.btnReportar.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Enabled = false;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(362, 201);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(97, 78);
            this.btnListar.TabIndex = 39;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCero,
            this.columnaUno,
            this.columnaDos});
            this.dgvConsulta.Location = new System.Drawing.Point(12, 36);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(344, 243);
            this.dgvConsulta.TabIndex = 38;
            // 
            // columnaCero
            // 
            this.columnaCero.HeaderText = "DNI";
            this.columnaCero.Name = "columnaCero";
            this.columnaCero.ReadOnly = true;
            // 
            // columnaUno
            // 
            this.columnaUno.HeaderText = "Nombre";
            this.columnaUno.Name = "columnaUno";
            this.columnaUno.ReadOnly = true;
            // 
            // columnaDos
            // 
            this.columnaDos.HeaderText = "Apellido";
            this.columnaDos.Name = "columnaDos";
            this.columnaDos.ReadOnly = true;
            // 
            // lstBarrio
            // 
            this.lstBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Location = new System.Drawing.Point(169, 7);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(187, 23);
            this.lstBarrio.TabIndex = 37;
            this.lstBarrio.SelectedIndexChanged += new System.EventHandler(this.lstBarrio_SelectedIndexChanged);
            // 
            // lblActiviadadConsulta
            // 
            this.lblActiviadadConsulta.AutoSize = true;
            this.lblActiviadadConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiviadadConsulta.Location = new System.Drawing.Point(27, 12);
            this.lblActiviadadConsulta.Name = "lblActiviadadConsulta";
            this.lblActiviadadConsulta.Size = new System.Drawing.Size(103, 13);
            this.lblActiviadadConsulta.TabIndex = 36;
            this.lblActiviadadConsulta.Text = "Seleccione el barrio:";
            // 
            // frmConsultaClientesPorBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 315);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnReportar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.lstBarrio);
            this.Controls.Add(this.lblActiviadadConsulta);
            this.Name = "frmConsultaClientesPorBarrio";
            this.Text = "Listado de clientes por barrio";
            this.Load += new System.EventHandler(this.frmConsultaClientesPorBarrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnReportar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCero;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaUno;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDos;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.Label lblActiviadadConsulta;
    }
}