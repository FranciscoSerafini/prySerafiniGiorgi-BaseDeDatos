using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace prySerafiniGiorgi_BaseDeDatos
{
    public partial class frmPrincipal : Form
    {
        //declaracion de variables y objetos globales
        //utilizaremos las variables publicas para usarlas en todo el proyecto
        public OleDbConnection conexionBase; 
        public OleDbConnection queQuieroDeLaBase;
        public OleDbConnection lectorDeConsultas;
        public string varRutaBaseDeDatos = "DEPORTE.accdb";
           

        public string varRutaDeBaseDeDatos;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        
        

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                lblFechaActual.Text = DateTime.Now.ToString();
                conexionBase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ varRutaBaseDeDatos);
                conexionBase.Open();
                lblEstado.Text = "Conectado:" + conexionBase.ConnectionString;
                statusStrip1.BackColor = Color.GreenYellow;
            }
            catch (Exception mensajito)
            {
                lblEstado.Text = mensajito.Message;
                statusStrip1.BackColor= Color.Red;


               // throw;
            }
        }

        private void deportistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrosDeDeportistas ventanaRegistroDeDeportista = new frmRegistrosDeDeportistas();
            ventanaRegistroDeDeportista.ShowDialog();
        }

        private void entrenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroDeEntrenadores ventanaRegistroDeEntrenadores = new frmRegistroDeEntrenadores();
            ventanaRegistroDeEntrenadores.ShowDialog();
        }

        private void deportistasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaDeportista ventanaConsultaDeportista = new frmConsultaDeportista();
            ventanaConsultaDeportista.ShowDialog();
        }

        private void entrenadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaEntrenador ventanaConsultaEntrenador = new frmConsultaEntrenador();
            ventanaConsultaEntrenador.ShowDialog();
        }

        private void deportistasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ModifiacionesDeportistas objVentaModificacionesDeportista = new ModifiacionesDeportistas();
            objVentaModificacionesDeportista.ShowDialog();
        }

        private void entrenadorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmModificacionEntrenadores objVentana = new frmModificacionEntrenadores();
            objVentana.ShowDialog();
        }
    }
}
