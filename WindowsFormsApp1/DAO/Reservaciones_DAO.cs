using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System.IO;


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

        public bool GenerateInvoicePDF(string codRsv, string serviciosAdicionales, decimal descuento)
        {
            try
            {
                conectar();

                // Obtener los datos de la factura
                SqlCommand cmd = new SqlCommand("sp_GetFacturaCostosFinales", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodRsv", codRsv);
                cmd.Parameters.AddWithValue("@ServiciosAdicionales", serviciosAdicionales ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Descuento", descuento);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dtFactura = new DataTable();
                adapter.Fill(dtFactura);

                if (dtFactura.Rows.Count == 0)
                {
                    throw new Exception("No se encontraron datos para generar la factura.");
                }

                DataRow factura = dtFactura.Rows[0];

                // Obtener los servicios adicionales
                SqlCommand cmdServicios = new SqlCommand("sp_GetServiciosPorReservacion", _conexion);
                cmdServicios.CommandType = CommandType.StoredProcedure;
                cmdServicios.Parameters.AddWithValue("@CodRsv", codRsv);
                DataTable dtServicios = new DataTable();
                adapter = new SqlDataAdapter(cmdServicios);
                adapter.Fill(dtServicios);

                // Calcular subtotal e IVA
                decimal costoBruto = Convert.ToDecimal(factura["CostoBruto"]);
                decimal costoSinIVA = costoBruto / 1.16m;

                decimal totalServicios = 0;
                foreach (DataRow servicio in dtServicios.Rows)
                {
                    if (servicio["PrecioBase"] != DBNull.Value)
                    {
                        totalServicios += Convert.ToDecimal(servicio["PrecioBase"]);
                    }
                }
                decimal iva = costoSinIVA * 0.16m;
                decimal subtotal = costoBruto + totalServicios;
                decimal totalFinal = subtotal - Convert.ToDecimal(factura["Anticipo"]);
                // Generar las filas HTML de servicios
                string serviciosRows = "";
                foreach (DataRow servicio in dtServicios.Rows)
                {
                    if (servicio["Nombre"] != DBNull.Value && servicio["PrecioBase"] != DBNull.Value)
                    {
                        serviciosRows += $"<tr><td>{servicio["Nombre"]}</td><td>{Convert.ToDecimal(servicio["PrecioBase"]).ToString("C2")}</td></tr>";
                    }
                }

                // Cargar plantilla HTML
                string templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Facturas", "FacturaPersonal.html");
                if (!File.Exists(templatePath))
                {
                    throw new Exception("No se encontró la plantilla HTML en la ruta especificada.");
                }
                string htmlTemplate = File.ReadAllText(templatePath);

                // Reemplazar marcadores
                string htmlContent = htmlTemplate
                .Replace("{FOLIO}", factura["Folio"]?.ToString() ?? "N/A")
                .Replace("{FECHA}", DateTime.Now.ToString("dd/MM/yyyy"))
                .Replace("{COD_RSV}", factura["Código_de_Reservación"]?.ToString() ?? "N/A")
                .Replace("{CLIENTE}", factura["NombreCliente"]?.ToString() ?? "N/A")
                .Replace("{RFC}", factura["RFC"]?.ToString() ?? "N/A")
                .Replace("{COSTO_BRUTO}", costoSinIVA.ToString("C2"))
                .Replace("{SERVICIOS_ROWS}", serviciosRows)
                .Replace("{SUBTOTAL}", subtotal.ToString("C2"))
                .Replace("{IVA}", iva.ToString("C2"))
                .Replace("{DESCUENTO}", Convert.ToDecimal(factura["Descuento"]).ToString("C2"))
                .Replace("{ANTICIPO}", Convert.ToDecimal(factura["Anticipo"]).ToString("C2"))
                .Replace("{COSTO_FINAL}", totalFinal.ToString("C2"))
                .Replace("{FECHA_ENTRADA}", Convert.ToDateTime(factura["FechaEntrada"]).ToString("dd/MM/yyyy"))
                .Replace("{FECHA_SALIDA}", Convert.ToDateTime(factura["FechaSalida"]).ToString("dd/MM/yyyy"))
                .Replace("{CHECKIN}", Convert.ToDateTime(factura["F_CheckIn"]).ToString("dd/MM/yyyy HH:mm"))
                .Replace("{CHECKOUT}", Convert.ToDateTime(factura["F_CheckOut"]).ToString("dd/MM/yyyy HH:mm"))
                .Replace("{NOMBRE_HOTEL}", factura["NombreHotel"]?.ToString() ?? "N/A")
                .Replace("{DOMICILIO_HOTEL}", factura["Domicilio"]?.ToString() ?? "N/A")
                .Replace("{TIPO_HABITACION}", factura["TipoHabitacion"]?.ToString() ?? "N/A")
                .Replace("{NUM_HABITACIONES}", factura["NumeroHabitaciones"]?.ToString() ?? "0");



                // Mostrar SaveFileDialog
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Guardar factura";
                saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = $"Factura_{codRsv}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return false; // Cancelado por el usuario
                }

                string pdfPath = saveFileDialog.FileName;

                // Generar PDF
                using (FileStream fs = new FileStream(pdfPath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    Document document = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(document, fs);
                    document.Open();

                    using (StringReader sr = new StringReader(htmlContent))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, sr);
                    }

                    document.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al generar la factura: {ex.Message}");
            }
            finally
            {
                desconectar();
            }
        }
    }
}
