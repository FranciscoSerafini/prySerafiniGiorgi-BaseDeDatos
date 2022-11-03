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
            Int32 TelefonoDeportistas = Convert.ToInt32(mskTelefono.Text);
            Int32 EdadDeportista = Convert.ToInt32(mskEdad.Text);
            string Deporte = Convert.ToString(lstDeporte.SelectedItem);





            try
            {
                conexionBD = new OleDbConnection(RutaBD);
                conexionBD.Open();
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD; //conexion al origen de datos
                comandoBD.CommandType = CommandType.Text; //comando para insertar datos
                comandoBD.CommandText = " INSERT INTO " + " DEPORTISTA ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [TELEFONO], [EDAD], [DEPORTE]) " +
                        " VALUES ('" + IdDeportista + "','" + NombreDeportista + "','" + ApellidoDeportista + "','" + DireccionDeportista + "','" + TelefonoDeportistas + "','" + EdadDeportista + "','" + Deporte +  "')";
                
                comandoBD.ExecuteNonQuery();//numero de filas afectadas
                MessageBox.Show("Tus datos fueron ingresados con exito");

            }
            catch (Exception mensaje)
            {
                MessageBox.Show("Tus datos no se pudieron registrar" + mensaje.Message);
                //throw;
            }
            conexionBD.Close();
            //luego de cada registro debemos vaciar las cajas de texto
            txtApellidoDeportista.Text = "";
            txtCodigoDeportista.Text = "";
            txtDireccionDeportista.Text = "";
            txtNombreDeportista.Text = "";
            mskEdad.Text = "";
            mskTelefono.Text = "";
            lstDeporte.SelectedItem = -1;
            txtCodigoDeportista.Focus();
            lstDeporte.SelectedItem = "";


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
        private void Verificacion()
        {
            if (txtApellidoDeportista.Text != "" && txtCodigoDeportista.Text != "" && txtDireccionDeportista.Text != "" && txtNombreDeportista.Text != "" && mskEdad.Text != "" && lstDeporte.SelectedIndex >= 0 && mskTelefono.Text != "")
            {
                cmdRegistroDeportistas.Enabled = true;
            }
            else
            {
                cmdRegistroDeportistas.Enabled = false;
            }
        }

        private void txtCodigoDeportista_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtNombreDeportista_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtApellidoDeportista_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtDireccionDeportista_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void mskTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Verificacion();
        }

        private void mskEdad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Verificacion();
        }

        private void lstDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtCodigoDeportista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
                MessageBox.Show("Por favor introduce solo letras");
            }
        }

        private void txtNombreDeportista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
                MessageBox.Show("Por favor introduce solo letras");
            }
        }

        private void txtApellidoDeportista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
                MessageBox.Show("Por favor introduce solo letras");
            }
        }
    }
}
