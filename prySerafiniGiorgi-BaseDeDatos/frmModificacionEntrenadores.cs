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
            if (Buscar.codigoDeportista != codigo)
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
        }
    }
}
