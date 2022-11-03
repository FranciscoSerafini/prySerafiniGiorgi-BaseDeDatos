namespace prySerafiniGiorgi_BaseDeDatos
{
    partial class frmConsultaEntrenador
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
            this.dtgEntrenadores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdListarEntrenadores = new System.Windows.Forms.Button();
            this.grpEliminarRegistro = new System.Windows.Forms.GroupBox();
            this.txtCodigoEntrenador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdEliminarRegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEntrenadores)).BeginInit();
            this.grpEliminarRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgEntrenadores
            // 
            this.dtgEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEntrenadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgEntrenadores.Location = new System.Drawing.Point(12, 24);
            this.dtgEntrenadores.Name = "dtgEntrenadores";
            this.dtgEntrenadores.Size = new System.Drawing.Size(636, 220);
            this.dtgEntrenadores.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo Entrenadores";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Direccion";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Provincia";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Deporte";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // cmdListarEntrenadores
            // 
            this.cmdListarEntrenadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListarEntrenadores.Location = new System.Drawing.Point(547, 250);
            this.cmdListarEntrenadores.Name = "cmdListarEntrenadores";
            this.cmdListarEntrenadores.Size = new System.Drawing.Size(101, 29);
            this.cmdListarEntrenadores.TabIndex = 1;
            this.cmdListarEntrenadores.Text = "Listar";
            this.cmdListarEntrenadores.UseVisualStyleBackColor = true;
            this.cmdListarEntrenadores.Click += new System.EventHandler(this.cmdListarEntrenadores_Click);
            // 
            // grpEliminarRegistro
            // 
            this.grpEliminarRegistro.Controls.Add(this.txtCodigoEntrenador);
            this.grpEliminarRegistro.Controls.Add(this.label1);
            this.grpEliminarRegistro.Controls.Add(this.cmdEliminarRegistro);
            this.grpEliminarRegistro.Location = new System.Drawing.Point(12, 260);
            this.grpEliminarRegistro.Name = "grpEliminarRegistro";
            this.grpEliminarRegistro.Size = new System.Drawing.Size(319, 97);
            this.grpEliminarRegistro.TabIndex = 6;
            this.grpEliminarRegistro.TabStop = false;
            this.grpEliminarRegistro.Text = "Eliminar registro";
            // 
            // txtCodigoEntrenador
            // 
            this.txtCodigoEntrenador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEntrenador.Location = new System.Drawing.Point(176, 33);
            this.txtCodigoEntrenador.Name = "txtCodigoEntrenador";
            this.txtCodigoEntrenador.Size = new System.Drawing.Size(121, 21);
            this.txtCodigoEntrenador.TabIndex = 6;
            this.txtCodigoEntrenador.TextChanged += new System.EventHandler(this.txtCodigoEntrenador_TextChanged);
            this.txtCodigoEntrenador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoEntrenador_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo  entrenador";
            // 
            // cmdEliminarRegistro
            // 
            this.cmdEliminarRegistro.Enabled = false;
            this.cmdEliminarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminarRegistro.Location = new System.Drawing.Point(196, 60);
            this.cmdEliminarRegistro.Name = "cmdEliminarRegistro";
            this.cmdEliminarRegistro.Size = new System.Drawing.Size(101, 27);
            this.cmdEliminarRegistro.TabIndex = 4;
            this.cmdEliminarRegistro.Text = "Eliminar";
            this.cmdEliminarRegistro.UseVisualStyleBackColor = true;
            this.cmdEliminarRegistro.Click += new System.EventHandler(this.cmdEliminarRegistro_Click);
            // 
            // frmConsultaEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 366);
            this.Controls.Add(this.grpEliminarRegistro);
            this.Controls.Add(this.cmdListarEntrenadores);
            this.Controls.Add(this.dtgEntrenadores);
            this.Name = "frmConsultaEntrenador";
            this.Text = "Consulta entrenadores";
            this.Load += new System.EventHandler(this.frmConsultaEntrenador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEntrenadores)).EndInit();
            this.grpEliminarRegistro.ResumeLayout(false);
            this.grpEliminarRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEntrenadores;
        private System.Windows.Forms.Button cmdListarEntrenadores;
        private System.Windows.Forms.GroupBox grpEliminarRegistro;
        private System.Windows.Forms.TextBox txtCodigoEntrenador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdEliminarRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}