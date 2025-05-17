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

        public DataTable sp_GetRsv(string codRsv = null)
        {
            try
            {
                conectar();
                SqlCommand cmd = new SqlCommand("sp_GetRsv", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodRsv", (object)codRsv ?? DBNull.Value);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las reservaciones: " + ex.Message);
            }
            finally
            {
                desconectar();
            }
        }
        public DataTable sp_GetRsvCheckIn(string codRsv = null)
        {
            try
            {
                conectar();
                SqlCommand cmd = new SqlCommand("sp_GetRsvCheckIn", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodRsv", (object)codRsv ?? DBNull.Value);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las reservaciones: " + ex.Message);
            }
            finally
            {
                desconectar();
            }
        }



        public void sp_CancelarReservacion(string codRsv)
        {
            try
            {
                conectar();
                SqlCommand cmd = new SqlCommand("sp_CancelarReservacion", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodRsv", codRsv);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cancelar la reservación: " + ex.Message);
            }
            finally
            {
                desconectar();
            }
        }
        public void sp_InsertCheckOut(string codRsv, DateTime fCheckOut, string serviciosJson, decimal descuento)
        {
            try
            {
                conectar();
                _comandosql = new SqlCommand("sp_InsertCheckOut", _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;

                _comandosql.Parameters.AddWithValue("@CodRsv", codRsv);
                _comandosql.Parameters.AddWithValue("@F_CheckOut", fCheckOut);
                _comandosql.Parameters.AddWithValue("@ServiciosAdicionales", serviciosJson);
                _comandosql.Parameters.AddWithValue("@Descuento", descuento);

                _comandosql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar el check-out: " + ex.Message);
            }
            finally
            {
                desconectar();
            }
        }


        public void sp_InsertCheckIn(string codRsv, DateTime fechaCheckIn)
        {
            try
            {
                conectar();
                SqlCommand cmd = new SqlCommand("sp_InsertCheckIn", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodRsv", codRsv);
                cmd.Parameters.AddWithValue("@F_CheckIn", fechaCheckIn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al realizar el check-in: " + ex.Message);
            }
            finally
            {
                desconectar();
            }
        }

        public DataTable GetFacturaPreview()
        {
            try
            {
                conectar();
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_FacturaPreview", _conexion);
                cmd.CommandType = CommandType.Text;


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la vista previa de la factura: " + ex.Message);
            }
            finally
            {
                desconectar();
            }
        }

        public DataTable GetFacturaPreviewCodRsv(string codRsv = null)
        {
            try
            {
                conectar();
                SqlCommand cmd;

                if (string.IsNullOrWhiteSpace(codRsv))
                {
                    // Si no hay código, trae todo
                    cmd = new SqlCommand("SELECT * FROM vw_FacturaPreview", _conexion);
                    cmd.CommandType = CommandType.Text;
                }
                else
                {
                    // Si hay código, busca por coincidencia parcial
                    cmd = new SqlCommand("SELECT * FROM vw_FacturaPreview WHERE Código_de_Reservación LIKE @CodRsv", _conexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@CodRsv", "%" + codRsv + "%");
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la vista previa de la factura por código de reservación: " + ex.Message);
            }
            finally
            {
                desconectar();
            }
        }
        public DataTable sp_GetServiciosRsv()
            { try
                {
                    conectar();
                    SqlCommand cmd = new SqlCommand("sp_GetServiciosRsv", _conexion);
                    cmd.CommandType = CommandType.Text;


                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener la vista previa de la factura: " + ex.Message);
                }
                finally
                {
                    desconectar();
                }
            }

        public class FechasReservacion
        {
            public DateTime? FechaEntrada { get; set; }
            public DateTime? FechaSalida { get; set; }
        }

        // En Reservaciones_DAO.cs, dentro de la clase Reservaciones_DAO
        public FechasReservacion GetFechasReservacion(string codRsv)
        {
            try
            {
                conectar();
                SqlCommand cmd = new SqlCommand("SELECT FechaEntrada, FechaSalida FROM DetalleReservaciones WHERE CodRsv = @CodRsv", _conexion);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@CodRsv", (object)codRsv ?? DBNull.Value);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                FechasReservacion fechas = null;
                if (dt.Rows.Count > 0)
                {
                    fechas = new FechasReservacion
                    {
                        FechaEntrada = dt.Rows[0]["FechaEntrada"] != DBNull.Value ? (DateTime?)dt.Rows[0]["FechaEntrada"] : null,
                        FechaSalida = dt.Rows[0]["FechaSalida"] != DBNull.Value ? (DateTime?)dt.Rows[0]["FechaSalida"] : null
                    };
                }

                return fechas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las fechas de la reservación: " + ex.Message);
            }
            finally
            {
                desconectar();
            }
        }

        public DateTime? GetCheckInDate(string codRsv)
        {
            try
            {
                conectar();
                SqlCommand cmd = new SqlCommand(
                    @"SELECT cio.F_CheckIn
              FROM CheckIn_Out cio
              INNER JOIN Reservaciones r ON cio.IDCheck = r.IDCheck
              WHERE r.CodRsv = @CodRsv", _conexion);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@CodRsv", (object)codRsv ?? DBNull.Value);

                object result = cmd.ExecuteScalar();
                return result != null && result != DBNull.Value ? (DateTime?)result : null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la fecha de check-in: " + ex.Message);
            }
            finally
            {
                desconectar();
            }
        }

        public DataTable sp_GetServiciosPorReservacion(string codRsv)
        {
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_GetServiciosPorReservacion"; // Tu SP debe devolver los servicios de la reservación
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.Parameters.Add("@CodRsv", SqlDbType.VarChar, 50).Value = codRsv;
                _adaptador = new SqlDataAdapter(_comandosql);
                _adaptador.Fill(tabla);
            }
            finally
            {
                desconectar();
            }
            return tabla;
        }

        public DataTable sp_GetFacturaPreviewConCostoFinal(string codRsv, string serviciosAdicionales, decimal descuento)
        {
            DataTable resultado = new DataTable();

            try
            {
                conectar();
                SqlCommand cmd = new SqlCommand("sp_GetFacturaCostosFinales", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodRsv", codRsv);
                cmd.Parameters.AddWithValue("@ServiciosAdicionales", string.IsNullOrEmpty(serviciosAdicionales) ? (object)DBNull.Value : serviciosAdicionales);
                cmd.Parameters.AddWithValue("@Descuento", descuento);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(resultado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la vista previa de la factura: " + ex.Message);
            }
            finally
            {
                desconectar();
            }

            return resultado;
        }

    }
}
