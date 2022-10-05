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
        public string varRutaBaseDeDatos =
            "C:\\Users\\franc\\Desktop\\ANALISTA EN SISTEMAS\\SEMESTRE II\\LABORATORIO DE PROGRAMACION\\Base de datos\\Base-Datos-main\\2022103-VS-BaseDatos";

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
           
        }

        private void entrenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
