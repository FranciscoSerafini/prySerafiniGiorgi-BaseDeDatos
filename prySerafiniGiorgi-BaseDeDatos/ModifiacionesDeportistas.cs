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
    public partial class ModifiacionesDeportistas : Form
    {
        public ModifiacionesDeportistas()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoDEportista.Text;
            ClaseDeportista Buscar = new ClaseDeportista();
            Buscar.Buscar(codigo);
            if (Buscar.codigoDeportista != codigo)
            {
                MessageBox.Show("No se encuentra el codigo en la base de datos");
            }
            else
            {
                txtDireccion.Text = Buscar.Direccion;
                txtTelefono.Text = Convert.ToString(Buscar.Telefono);
                txtEdad.Text = Convert.ToString(Buscar.Edad);
                txtDeporte.Text = Convert.ToString(Buscar.Deportes);

            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string deportistaCodigo = txtCodigoDEportista.Text;
            string direccion = txtDireccion.Text;
            string deporte = txtDeporte.Text;
            Int32 edad = Convert.ToInt32(txtEdad.Text);
           Int32 telefono = Convert.ToInt32(txtTelefono.Text);
            ClaseDeportista modificar = new ClaseDeportista();
            modificar.Direccion = direccion;
            modificar.Edad = edad;
            modificar.Deportes = deporte;
            modificar.Telefono = telefono;
            modificar.Modificar(deportistaCodigo);


        }
    }
}
