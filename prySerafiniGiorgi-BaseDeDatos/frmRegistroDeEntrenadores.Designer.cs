namespace prySerafiniGiorgi_BaseDeDatos
{
    partial class frmRegistroDeEntrenadores
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
            this.cmdRegistroEntrenadores = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoEntrenador = new System.Windows.Forms.TextBox();
            this.txtApellidoEntrenador = new System.Windows.Forms.TextBox();
            this.txtDireccionEntrenador = new System.Windows.Forms.TextBox();
            this.txtNombreEntrenador = new System.Windows.Forms.TextBox();
            this.lstDeporte = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.StatusBDEntrenador = new System.Windows.Forms.StatusStrip();
            this.lblFechaActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBDEntrenador.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdRegistroEntrenadores
            // 
            this.cmdRegistroEntrenadores.Enabled = false;
            this.cmdRegistroEntrenadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistroEntrenadores.Location = new System.Drawing.Point(228, 348);
            this.cmdRegistroEntrenadores.Name = "cmdRegistroEntrenadores";
            this.cmdRegistroEntrenadores.Size = new System.Drawing.Size(135, 33);
            this.cmdRegistroEntrenadores.TabIndex = 33;
            this.cmdRegistroEntrenadores.Text = "Registrar";
            this.cmdRegistroEntrenadores.UseVisualStyleBackColor = true;
            this.cmdRegistroEntrenadores.Click += new System.EventHandler(this.cmdRegistroDeportistas_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(312, 31);
            this.label8.TabIndex = 32;
            this.label8.Text = "Registro  entrenadores";
            // 
            // txtCodigoEntrenador
            // 
            this.txtCodigoEntrenador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEntrenador.Location = new System.Drawing.Point(182, 69);
            this.txtCodigoEntrenador.Name = "txtCodigoEntrenador";
            this.txtCodigoEntrenador.Size = new System.Drawing.Size(181, 21);
            this.txtCodigoEntrenador.TabIndex = 31;
            this.txtCodigoEntrenador.TextChanged += new System.EventHandler(this.txtCodigoEntrenador_TextChanged);
            this.txtCodigoEntrenador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoEntrenador_KeyPress);
            // 
            // txtApellidoEntrenador
            // 
            this.txtApellidoEntrenador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoEntrenador.Location = new System.Drawing.Point(182, 163);
            this.txtApellidoEntrenador.Name = "txtApellidoEntrenador";
            this.txtApellidoEntrenador.Size = new System.Drawing.Size(181, 21);
            this.txtApellidoEntrenador.TabIndex = 29;
            this.txtApellidoEntrenador.TextChanged += new System.EventHandler(this.txtApellidoEntrenador_TextChanged);
            this.txtApellidoEntrenador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoEntrenador_KeyPress);
            // 
            // txtDireccionEntrenador
            // 
            this.txtDireccionEntrenador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccionEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionEntrenador.Location = new System.Drawing.Point(182, 210);
            this.txtDireccionEntrenador.Name = "txtDireccionEntrenador";
            this.txtDireccionEntrenador.Size = new System.Drawing.Size(181, 21);
            this.txtDireccionEntrenador.TabIndex = 28;
            this.txtDireccionEntrenador.TextChanged += new System.EventHandler(this.txtDireccionEntrenador_TextChanged);
            // 
            // txtNombreEntrenador
            // 
            this.txtNombreEntrenador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEntrenador.Location = new System.Drawing.Point(182, 116);
            this.txtNombreEntrenador.Name = "txtNombreEntrenador";
            this.txtNombreEntrenador.Size = new System.Drawing.Size(181, 21);
            this.txtNombreEntrenador.TabIndex = 27;
            this.txtNombreEntrenador.TextChanged += new System.EventHandler(this.txtNombreEntrenador_TextChanged);
            this.txtNombreEntrenador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEntrenador_KeyPress);
            // 
            // lstDeporte
            // 
            this.lstDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstDeporte.FormattingEnabled = true;
            this.lstDeporte.Items.AddRange(new object[] {
            "TENIS",
            "BASQUET",
            "CICLISMO",
            "FUTBOL",
            "VOLEY"});
            this.lstDeporte.Location = new System.Drawing.Point(182, 305);
            this.lstDeporte.Name = "lstDeporte";
            this.lstDeporte.Size = new System.Drawing.Size(181, 21);
            this.lstDeporte.TabIndex = 26;
            this.lstDeporte.SelectedIndexChanged += new System.EventHandler(this.lstDeporte_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Deporte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Codigo entrenador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Provincia";
            // 
            // txtProvincia
            // 
            this.txtProvincia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvincia.Location = new System.Drawing.Point(182, 257);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(181, 21);
            this.txtProvincia.TabIndex = 35;
            this.txtProvincia.TextChanged += new System.EventHandler(this.txtProvincia_TextChanged);
            this.txtProvincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProvincia_KeyPress);
            // 
            // StatusBDEntrenador
            // 
            this.StatusBDEntrenador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFechaActual,
            this.lblEstado});
            this.StatusBDEntrenador.Location = new System.Drawing.Point(0, 391);
            this.StatusBDEntrenador.Name = "StatusBDEntrenador";
            this.StatusBDEntrenador.Size = new System.Drawing.Size(378, 22);
            this.StatusBDEntrenador.TabIndex = 36;
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(0, 17);
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 17);
            // 
            // frmRegistroDeEntrenadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 413);
            this.Controls.Add(this.StatusBDEntrenador);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdRegistroEntrenadores);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodigoEntrenador);
            this.Controls.Add(this.txtApellidoEntrenador);
            this.Controls.Add(this.txtDireccionEntrenador);
            this.Controls.Add(this.txtNombreEntrenador);
            this.Controls.Add(this.lstDeporte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistroDeEntrenadores";
            this.Text = "Registro de entrenadores";
            this.Load += new System.EventHandler(this.frmRegistroDeEntrenadores_Load);
            this.StatusBDEntrenador.ResumeLayout(false);
            this.StatusBDEntrenador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRegistroEntrenadores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoEntrenador;
        private System.Windows.Forms.TextBox txtApellidoEntrenador;
        private System.Windows.Forms.TextBox txtDireccionEntrenador;
        private System.Windows.Forms.TextBox txtNombreEntrenador;
        private System.Windows.Forms.ComboBox lstDeporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.StatusStrip StatusBDEntrenador;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaActual;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
    }
}