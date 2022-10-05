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

        public string varRutaDeBaseDeDatos;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
