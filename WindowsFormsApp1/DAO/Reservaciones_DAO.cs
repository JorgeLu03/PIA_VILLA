using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace PIA_VILLA
{
    internal class Reservaciones_DAO
    {
        private SqlConnection _conexion;
        private SqlCommand _comandosql;
        private SqlDataAdapter _adaptador;

        private void conectar()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["WINAUTH"].ConnectionString;
            _conexion = new SqlConnection(cadenaConexion);
            _conexion.Open();
        }

        private void desconectar()
        {
            if (_conexion != null && _conexion.State == ConnectionState.Open)
            {
                _conexion.Close();
            }
        }


        public DataTable sp_GetCiudad()
        {
            DataTable tablaCiudades = new DataTable();

            try
            {
                conectar();

                string query = "SELECT Ciudad FROM UbiHotel";
                _comandosql = new SqlCommand(query, _conexion);
                _adaptador = new SqlDataAdapter(_comandosql);

                _adaptador.Fill(tablaCiudades);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener las ciudades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                desconectar();
            }

            return tablaCiudades;
        }


    }
}
