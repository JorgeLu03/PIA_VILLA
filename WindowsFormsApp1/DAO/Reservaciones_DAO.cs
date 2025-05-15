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

        public void sp_RegistrarReservacion(string codRsv, string rfc, int idTipoHab, int cantHab, int numPersonas, DateTime entrada, DateTime salida, int numNomina, decimal anticipo)
        {
            try
            {
                conectar();
                SqlCommand cmd = new SqlCommand("sp_RegistrarReservacion", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodRsv", codRsv);
                cmd.Parameters.AddWithValue("@RFC", rfc);
                cmd.Parameters.AddWithValue("@IDTipoHab", idTipoHab);
                cmd.Parameters.AddWithValue("@CantHab", cantHab);
                cmd.Parameters.AddWithValue("@NumPersonas", numPersonas);
                cmd.Parameters.AddWithValue("@FEntrada", entrada);
                cmd.Parameters.AddWithValue("@FSalida", salida);
                cmd.Parameters.AddWithValue("@NumNomina", numNomina);
                cmd.Parameters.AddWithValue("@Anticipo", anticipo);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar reservación: " + ex.Message);
            }
            finally
            {
                desconectar();
            }
        }


    }
}
