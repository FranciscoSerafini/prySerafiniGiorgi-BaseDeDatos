using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySerafiniGiorgi_BaseDeDatos
{
    public partial class frmRegistroDeEntrenadores : Form
    {
        public OleDbConnection conexionBD; //declaracion de conexion de BD
        public OleDbCommand comandoBD;//representa una instruccion 

        //declaracion de la ruta donde esta alojada la BD
        public string RutaBD = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";
        public frmRegistroDeEntrenadores()
        {
            InitializeComponent();
        }

        private void cmdRegistroDeportistas_Click(object sender, EventArgs e)
        {
            //declaracion de variables a grabar
            string IdEntrenadores = txtCodigoEntrenador.Text;
            string NombreEntrenador = txtNombreEntrenador.Text;
            string ApellidoEntrenador = txtApellidoEntrenador.Text;
            string DireccionEntrenador = Convert.ToString(txtDireccionEntrenador.Text);
            string ProvinciaEntrenador = txtProvincia.Text;
            string Deporte = Convert.ToString(lstDeporte.SelectedItem);

            try
            {
                conexionBD = new OleDbConnection(RutaBD);
                conexionBD.Open();
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD; //conexion al origen de datos
                comandoBD.CommandType = CommandType.Text; //comando para insertar datos
                comandoBD.CommandText = " INSERT INTO " + " ENTRENADORES ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [PROVINCIA], [DEPORTE])" +
                        " VALUES ('" +IdEntrenadores + "','" + NombreEntrenador + "','" + ApellidoEntrenador+ "','" + DireccionEntrenador+ "','" + ProvinciaEntrenador + "','" + Deporte+"')";

                comandoBD.ExecuteNonQuery();//numero de filas afectadas
                MessageBox.Show("Tus datos fueron ingresados con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Tus datos  NO fueron ingresados con exito");
                //throw;
            }
            //luego de grabar debemos limpiar las cajas de textos
            txtApellidoEntrenador.Text = "";
            txtCodigoEntrenador.Text = "";
            txtDireccionEntrenador.Text = "";
            txtNombreEntrenador.Text = "";
            txtProvincia.Text = "";
            lstDeporte.SelectedItem = -1;
        }

        private void frmRegistroDeEntrenadores_Load(object sender, EventArgs e)
        {
            try
            {
                StatusBDEntrenador.BackColor = Color.Green;
            }
            catch (Exception barraColor)
            {
                StatusBDEntrenador.BackColor = Color.Red;
                //throw;
            }
        }
    }
}
