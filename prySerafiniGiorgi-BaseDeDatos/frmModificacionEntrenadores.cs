using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySerafiniGiorgi_BaseDeDatos
{
    public partial class frmModificacionEntrenadores : Form
    {
        public frmModificacionEntrenadores()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoDeEntrenador.Text;
            clsEntrenadores Buscar = new clsEntrenadores();
            Buscar.Buscar(codigo);
            if (Buscar.codigoEntrenador != codigo)
            {
                MessageBox.Show("No se encuentra el codigo en la base de datos");
            }
            else
            {
                txtDireccion.Text = Buscar.Direccion;
                txtProvincia.Text = Convert.ToString(Buscar.Provincia);
                txtDeporte.Text = Convert.ToString(Buscar.Deportes);

            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string codigoEntrenador = txtCodigoDeEntrenador.Text;
            string direccion = txtDireccion.Text;
            string deporte = txtDeporte.Text;
            string provincia = txtProvincia.Text;
            clsEntrenadores modificar = new clsEntrenadores();
            modificar.Direccion = direccion;
            modificar.Deportes = deporte;
            modificar.Provincia = provincia;
            modificar.Modificar(codigoEntrenador);

            //limpiamos las cajas de texto
            txtCodigoDeEntrenador.Text = "";
            txtDeporte.Text = "";
            txtDireccion.Text = "";
            txtProvincia.Text = "";
            txtCodigoDeEntrenador.Focus();

            
        }
        private void Verificacion()
        {
            if (txtCodigoDeEntrenador.Text != "" && txtDeporte.Text != "" && txtDireccion.Text != "" && txtProvincia.Text != "")
            {
                cmdGuardar.Enabled = true;
            }
            else
            {
                cmdGuardar.Enabled = false;
            }
        }

        private void frmModificacionEntrenadores_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtCodigoDeEntrenador_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtDeporte_TextChanged(object sender, EventArgs e)
        {
            Verificacion();
        }

        private void txtDeporte_KeyPress(object sender, KeyPressEventArgs e)
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
