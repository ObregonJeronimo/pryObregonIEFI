namespace pryObregonIEFI
{
    partial class frmNuevoSocio
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.lblSaldoCliente = new System.Windows.Forms.Label();
            this.txtSaldoCliente = new System.Windows.Forms.TextBox();
            this.mskDniCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lstBarrioCliente = new System.Windows.Forms.ComboBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblBarrioCliente = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.lstActividadCliente = new System.Windows.Forms.ComboBox();
            this.lblApellidoNombre = new System.Windows.Forms.Label();
            this.lblActividadCliente = new System.Windows.Forms.Label();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(163, 216);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCliente.Location = new System.Drawing.Point(98, 122);
            this.txtDireccionCliente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtDireccionCliente.MaxLength = 20;
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(116, 21);
            this.txtDireccionCliente.TabIndex = 25;
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCliente.Location = new System.Drawing.Point(35, 127);
            this.lblDireccionCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(55, 13);
            this.lblDireccionCliente.TabIndex = 33;
            this.lblDireccionCliente.Text = "Dirección:";
            // 
            // lblSaldoCliente
            // 
            this.lblSaldoCliente.AutoSize = true;
            this.lblSaldoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoCliente.Location = new System.Drawing.Point(35, 183);
            this.lblSaldoCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSaldoCliente.Name = "lblSaldoCliente";
            this.lblSaldoCliente.Size = new System.Drawing.Size(37, 13);
            this.lblSaldoCliente.TabIndex = 32;
            this.lblSaldoCliente.Text = "Saldo:";
            // 
            // txtSaldoCliente
            // 
            this.txtSaldoCliente.Location = new System.Drawing.Point(98, 178);
            this.txtSaldoCliente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtSaldoCliente.Name = "txtSaldoCliente";
            this.txtSaldoCliente.Size = new System.Drawing.Size(116, 20);
            this.txtSaldoCliente.TabIndex = 29;
            // 
            // mskDniCliente
            // 
            this.mskDniCliente.Location = new System.Drawing.Point(98, 66);
            this.mskDniCliente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.mskDniCliente.Mask = "99999999";
            this.mskDniCliente.Name = "mskDniCliente";
            this.mskDniCliente.Size = new System.Drawing.Size(116, 20);
            this.mskDniCliente.TabIndex = 22;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(35, 17);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(47, 13);
            this.lblNombreCliente.TabIndex = 23;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // lstBarrioCliente
            // 
            this.lstBarrioCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBarrioCliente.FormattingEnabled = true;
            this.lstBarrioCliente.Location = new System.Drawing.Point(98, 93);
            this.lstBarrioCliente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lstBarrioCliente.Name = "lstBarrioCliente";
            this.lstBarrioCliente.Size = new System.Drawing.Size(116, 23);
            this.lstBarrioCliente.TabIndex = 24;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(98, 12);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtNombreCliente.MaxLength = 20;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(116, 21);
            this.txtNombreCliente.TabIndex = 20;
            // 
            // lblBarrioCliente
            // 
            this.lblBarrioCliente.AutoSize = true;
            this.lblBarrioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrioCliente.Location = new System.Drawing.Point(35, 98);
            this.lblBarrioCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBarrioCliente.Name = "lblBarrioCliente";
            this.lblBarrioCliente.Size = new System.Drawing.Size(37, 13);
            this.lblBarrioCliente.TabIndex = 31;
            this.lblBarrioCliente.Text = "Barrio:";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoCliente.Location = new System.Drawing.Point(98, 39);
            this.txtApellidoCliente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtApellidoCliente.MaxLength = 20;
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(116, 21);
            this.txtApellidoCliente.TabIndex = 21;
            // 
            // lstActividadCliente
            // 
            this.lstActividadCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstActividadCliente.FormattingEnabled = true;
            this.lstActividadCliente.Location = new System.Drawing.Point(98, 149);
            this.lstActividadCliente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lstActividadCliente.Name = "lstActividadCliente";
            this.lstActividadCliente.Size = new System.Drawing.Size(116, 23);
            this.lstActividadCliente.TabIndex = 27;
            // 
            // lblApellidoNombre
            // 
            this.lblApellidoNombre.AutoSize = true;
            this.lblApellidoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoNombre.Location = new System.Drawing.Point(35, 44);
            this.lblApellidoNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblApellidoNombre.Name = "lblApellidoNombre";
            this.lblApellidoNombre.Size = new System.Drawing.Size(47, 13);
            this.lblApellidoNombre.TabIndex = 26;
            this.lblApellidoNombre.Text = "Apellido:";
            // 
            // lblActividadCliente
            // 
            this.lblActividadCliente.AutoSize = true;
            this.lblActividadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividadCliente.Location = new System.Drawing.Point(35, 154);
            this.lblActividadCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblActividadCliente.Name = "lblActividadCliente";
            this.lblActividadCliente.Size = new System.Drawing.Size(51, 13);
            this.lblActividadCliente.TabIndex = 30;
            this.lblActividadCliente.Text = "Actividad";
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCliente.Location = new System.Drawing.Point(35, 71);
            this.lblDniCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(29, 13);
            this.lblDniCliente.TabIndex = 28;
            this.lblDniCliente.Text = "DNI:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 216);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 34;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmNuevoSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 251);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.lblDireccionCliente);
            this.Controls.Add(this.lblSaldoCliente);
            this.Controls.Add(this.txtSaldoCliente);
            this.Controls.Add(this.mskDniCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lstBarrioCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblBarrioCliente);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.lstActividadCliente);
            this.Controls.Add(this.lblApellidoNombre);
            this.Controls.Add(this.lblActividadCliente);
            this.Controls.Add(this.lblDniCliente);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmNuevoSocio";
            this.Text = "Nuevo Socio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.Label lblSaldoCliente;
        private System.Windows.Forms.TextBox txtSaldoCliente;
        private System.Windows.Forms.MaskedTextBox mskDniCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.ComboBox lstBarrioCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblBarrioCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.ComboBox lstActividadCliente;
        private System.Windows.Forms.Label lblApellidoNombre;
        private System.Windows.Forms.Label lblActividadCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Button btnVolver;
    }
}