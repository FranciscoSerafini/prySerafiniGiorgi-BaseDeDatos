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
            this.cmdListarEntrenadores = new System.Windows.Forms.Button();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEntrenadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEntrenadores
            // 
            this.dtgEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEntrenadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgEntrenadores.Location = new System.Drawing.Point(12, 24);
            this.dtgEntrenadores.Name = "dtgEntrenadores";
            this.dtgEntrenadores.Size = new System.Drawing.Size(643, 220);
            this.dtgEntrenadores.TabIndex = 0;
            // 
            // cmdListarEntrenadores
            // 
            this.cmdListarEntrenadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListarEntrenadores.Location = new System.Drawing.Point(554, 250);
            this.cmdListarEntrenadores.Name = "cmdListarEntrenadores";
            this.cmdListarEntrenadores.Size = new System.Drawing.Size(101, 39);
            this.cmdListarEntrenadores.TabIndex = 1;
            this.cmdListarEntrenadores.Text = "Listar";
            this.cmdListarEntrenadores.UseVisualStyleBackColor = true;
            this.cmdListarEntrenadores.Click += new System.EventHandler(this.cmdListarEntrenadores_Click);
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
            // frmConsultaEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 296);
            this.Controls.Add(this.cmdListarEntrenadores);
            this.Controls.Add(this.dtgEntrenadores);
            this.Name = "frmConsultaEntrenador";
            this.Text = "Consulta entrenadores";
            ((System.ComponentModel.ISupportInitialize)(this.dtgEntrenadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEntrenadores;
        private System.Windows.Forms.Button cmdListarEntrenadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}