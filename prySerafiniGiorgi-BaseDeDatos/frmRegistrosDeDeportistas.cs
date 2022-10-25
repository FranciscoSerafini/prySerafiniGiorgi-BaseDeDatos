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
    public partial class frmRegistrosDeDeportistas : Form
    {
        public OleDbConnection conexionBD; //declaracion de conexion de BD
        public OleDbCommand comandoBD;//representa una instruccion 

        //declaracion de la ruta donde esta alojada la BD
        public string RutaBD = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";


        public frmRegistrosDeDeportistas()
        {
            InitializeComponent();
        }

        private void cmdRegistroDeportistas_Click(object sender, EventArgs e)
        {
            //variables para almacenar datos para el registro
            string IdDeportista = txtCodigoDeportista.Text;
            string NombreDeportista = txtNombreDeportista.Text;
            string ApellidoDeportista = txtApellidoDeportista.Text;
            string DireccionDeportista = Convert.ToString(txtDireccionDeportista.Text);
            Int32 TelefonoDeportistas = Convert.ToInt32(mskTelfonoDeportista.Text);
            Int32 EdadDeportista = Convert.ToInt32(mskEdadDeportista.Text);
            string Deporte = Convert.ToString(lstDeporte.SelectedItem);





            try
            {
                conexionBD = new OleDbConnection(RutaBD);
                conexionBD.Open();
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD; //conexion al origen de datos
                comandoBD.CommandType = CommandType.Text; //comando para insertar datos
                comandoBD.CommandText = "INSERT INTO" + " DEPORTISTA ([NOMBRE], [APELLIDO], [DIRECCION], [TELEFONO], [EDAD], [DEPORTE])" +
                        " VALUES ('" + IdDeportista + "','" + NombreDeportista + "','" + ApellidoDeportista+ "','" + DireccionDeportista+ "','" + TelefonoDeportistas+ "','" + EdadDeportista + "','" +Deporte +  "')";
                
                comandoBD.ExecuteNonQuery();//numero de filas afectadas
                MessageBox.Show("Tus datos fueron ingresados con exito");

            }
            catch (Exception)
            {
                MessageBox.Show("Tus datos no se pudieron registrar");
                //throw;
            }
            conexionBD.Close();
            //luego de cada registro debemos vaciar las cajas de texto
            txtApellidoDeportista.Text = "";
            txtCodigoDeportista.Text = "";
            txtDireccionDeportista.Text = "";
            txtNombreDeportista.Text = "";
            mskEdadDeportista.Text = "";
            mskTelfonoDeportista.Text = "";
            lstDeporte.SelectedItem = -1;

        }

        private void frmRegistrosDeDeportistas_Load(object sender, EventArgs e)
        {
            try
            {
                StatusBDdeportista.BackColor = Color.Green;
            }
            catch (Exception barraColor)
            {
                StatusBDdeportista.BackColor = Color.Red;
                //throw;
            }
        }
    }
}
