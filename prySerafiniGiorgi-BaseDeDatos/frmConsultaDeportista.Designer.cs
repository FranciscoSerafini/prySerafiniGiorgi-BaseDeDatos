namespace prySerafiniGiorgi_BaseDeDatos
{
    partial class frmConsultaDeportista
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
            this.cmdListarDeportista = new System.Windows.Forms.Button();
            this.dtgDeportistas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeportistas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdListarDeportista
            // 
            this.cmdListarDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListarDeportista.Location = new System.Drawing.Point(357, 252);
            this.cmdListarDeportista.Name = "cmdListarDeportista";
            this.cmdListarDeportista.Size = new System.Drawing.Size(101, 39);
            this.cmdListarDeportista.TabIndex = 3;
            this.cmdListarDeportista.Text = "Listar";
            this.cmdListarDeportista.UseVisualStyleBackColor = true;
            this.cmdListarDeportista.Click += new System.EventHandler(this.cmdListarDeportista_Click);
            // 
            // dtgDeportistas
            // 
            this.dtgDeportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDeportistas.Location = new System.Drawing.Point(12, 12);
            this.dtgDeportistas.Name = "dtgDeportistas";
            this.dtgDeportistas.Size = new System.Drawing.Size(476, 220);
            this.dtgDeportistas.TabIndex = 2;
            // 
            // frmConsultaDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 311);
            this.Controls.Add(this.cmdListarDeportista);
            this.Controls.Add(this.dtgDeportistas);
            this.Name = "frmConsultaDeportista";
            this.Text = "Consulta deportistas";
            this.Load += new System.EventHandler(this.frmConsultaDeportista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeportistas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdListarDeportista;
        private System.Windows.Forms.DataGridView dtgDeportistas;
    }
}