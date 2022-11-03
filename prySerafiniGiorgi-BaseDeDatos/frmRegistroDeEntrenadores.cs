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
            txtCodigoEntrenador.Focus();
            lstDeporte.SelectedItem = "";
       
                    
        }
        private void Verificacion()
        {
            if (txtApellidoEntrenador.Text != "" && txtCodigoEntrenador.Text != "" && txtDireccionEntrenador.Text != "" && txtNombreEntrenador.Text != "" && txtProvincia.Text != "" && lstDeporte.SelectedIndex >= 0) 
            {
                cmdRegistroEntrenadores.Enabled = true;
            }
            else
            {
                cmdRegistroEntrenadores.Enabled = false;
            }
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

        private void txtCodigoEntrenador_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtNombreEntrenador_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtApellidoEntrenador_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtDireccionEntrenador_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void lstDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtCodigoEntrenador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
                MessageBox.Show("Por favor introduce solo letras");
            }
        }

        private void txtNombreEntrenador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
                MessageBox.Show("Por favor introduce solo letras");
            }
        }

        private void txtApellidoEntrenador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
                MessageBox.Show("Por favor introduce solo letras");
            }
        }

        private void txtProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
                MessageBox.Show("Por favor introduce solo letras");
            }
        }
    }
}
