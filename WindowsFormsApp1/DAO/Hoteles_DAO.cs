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
    internal class Hoteles_DAO
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

        public DataTable sp_GetHoteles()
        {
            try
            {
                conectar();
                _comandosql = new SqlCommand("sp_GetHoteles", _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _adaptador = new SqlDataAdapter(_comandosql);
                DataTable tabla = new DataTable();
                _adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            finally
            {
                desconectar();
            }
        }


        public void sp_GestionServiciosHotel(char opcion, int idHotel, int idServicio)
        {
            try
            {
                conectar();
                _comandosql = new SqlCommand("sp_GestionServiciosHotel", _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;

                _comandosql.Parameters.AddWithValue("@opcion", opcion);
                _comandosql.Parameters.AddWithValue("@idHotel", idHotel);
                _comandosql.Parameters.AddWithValue("@idServicio", idServicio);

                _comandosql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                desconectar();
            }
        }

        public void sp_GestionHoteles(char opcion, string nombre, int idhotel, string zonaTur, int numpisos, DateTime inicioop, int numNomina, string ciudad, string estado, string pais, string domicilio)
        {
            try
            {
                conectar();
                _comandosql = new SqlCommand("sp_GestionHoteles", _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;

                _comandosql.Parameters.AddWithValue("@opcion", opcion);
                _comandosql.Parameters.AddWithValue("@idhotel", idhotel);
                _comandosql.Parameters.AddWithValue("@nombre", nombre);
                _comandosql.Parameters.AddWithValue("@zonatur", zonaTur);
                _comandosql.Parameters.AddWithValue("@numpisos", numpisos);
                _comandosql.Parameters.AddWithValue("@inicioop", inicioop);
                _comandosql.Parameters.AddWithValue("@numnomina", numNomina);
                _comandosql.Parameters.AddWithValue("@ciudad", ciudad);
                _comandosql.Parameters.AddWithValue("@estado", estado);
                _comandosql.Parameters.AddWithValue("@pais", pais);
                _comandosql.Parameters.AddWithValue("@domicilio", domicilio);

                _comandosql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                desconectar();
            }
        }

        public int ObtenerUltimoIDHotelInsertado()
        {
            int ultimoID = 0;

            try
            {
                conectar();
                _comandosql = new SqlCommand("SELECT MAX(IDHotel) FROM Hoteles", _conexion);
                object resultado = _comandosql.ExecuteScalar();

                if (resultado != DBNull.Value)
                {
                    ultimoID = Convert.ToInt32(resultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el último ID del hotel: " + ex.Message);
            }
            finally
            {
                desconectar();
            }

            return ultimoID;
        }

        public List<string> sp_GetServiciosHotel(int idHotel)
        {
            List<string> nombresServicios = new List<string>();

            try
            {
                conectar();
                _comandosql = new SqlCommand("sp_GetServiciosHotel", _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.Parameters.AddWithValue("@IDHotel", SqlDbType.Int).Value = idHotel;

                using (SqlDataReader reader = _comandosql.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nombresServicios.Add(reader.GetString(0));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los servicios del hotel: " + ex.Message);
                return null;
            }
            finally
            {
                desconectar();
            }

            return nombresServicios;
        }



    }
}
