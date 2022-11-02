using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace prySerafiniGiorgi_BaseDeDatos
{
    internal class clsEntrenadores
    {
        //Realizo las distintas conexiones en la base
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adapatador = new OleDbDataAdapter();
        //Ruta para base de datos a utilizar
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "DEPORTE.accdb";
        private string Tabla = "ENTRENADORES";

        //variables a cambiar o eliminar
        private string codigoEntrenador;
        private string nombre;
        private string apellido;
        private string direccion;
        private string provincia;
        private string deporte;

        public string codigoDeportista
        {
            get { return codigoEntrenador; }
            set { codigoEntrenador = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }
        public string Deportes
        {
            get { return deporte; }
            set { deporte = value; }
        }

        public void Buscar(string codigo)
        {
            try
            {
                conexion.ConnectionString = Ruta;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader DR = comando.ExecuteReader();
                if (DR.HasRows)//pregunta si hay registros
                {
                    while (DR.Read())
                    {
                        if (DR.GetString(0) == codigo)
                        {
                            codigoEntrenador = DR.GetString(0);
                            nombre = DR.GetString(1);
                            apellido = DR.GetString(2);
                            direccion = DR.GetString(3);
                            provincia = DR.GetString(4);
                            deporte = DR.GetString(5);

                        }
                    }
                }

                conexion.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro");

            }
        }

        public void Modificar(string codigoDeportista)
        {
            try
            {
                //usaremos sentencias de SQL
                string Sql = "UPDATE ENTRENADORES SET DIRECCION= '" + Direccion + "', PROVINCIA='" + Provincia +"', DEPORTE='" + Deportes + "' WHERE [CODIGO DEPORTISTA] = '" + codigoEntrenador + "'";
                //Conecto la base de datos
                conexion.ConnectionString = Ruta;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = Sql;
                comando.ExecuteNonQuery();
                conexion.Close();


                MessageBox.Show("Tu registro se pudo modificar");
            }
            catch (Exception)
            {
                MessageBox.Show("Tu registro no se pudo modificar");

            }





        }
    }



}
