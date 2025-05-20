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
    internal class Clientes_DAO
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

        public DataTable sp_GetClientes()
        {
            string msg = "";
            DataTable tablaResultado = new DataTable();
            try
            {
                conectar(); // Método tuyo para abrir conexión
                string qry = "sp_GetClientes";

                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                _adaptador = new SqlDataAdapter(_comandosql);
                _adaptador.Fill(tablaResultado);
            }
            catch (SqlException e)
            {
                msg = "Error al obtener los datos de los clientes: \n" + e.Message;
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                desconectar(); // Método tuyo para cerrar conexión
            }
            return tablaResultado;
        }

        public void sp_GestionCliente(char opcion,string nombre,DateTime fechaNac,string correo,string edoCivil,string rfc,string tel,string cel,string ciudad,string estado,string pais)
        {
            string msg = "";
            try
            {
                conectar();
                string qry = "sp_GestionClientes"; // Asegúrate de que este sea el nombre correcto de tu SP
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                // Parámetros del procedimiento
                _comandosql.Parameters.Add("@opcion", SqlDbType.Char, 1).Value = opcion;
                _comandosql.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = nombre;
                _comandosql.Parameters.Add("@fechanac", SqlDbType.Date).Value = fechaNac;
                _comandosql.Parameters.Add("@correo", SqlDbType.VarChar, 30).Value = correo;
                _comandosql.Parameters.Add("@edocivil", SqlDbType.VarChar, 20).Value = edoCivil ?? (object)DBNull.Value;
                _comandosql.Parameters.Add("@rfc", SqlDbType.VarChar, 20).Value = rfc ?? (object)DBNull.Value;
                _comandosql.Parameters.Add("@tel", SqlDbType.VarChar, 20).Value = tel ?? (object)DBNull.Value;
                _comandosql.Parameters.Add("@cel", SqlDbType.VarChar, 20).Value = cel ?? (object)DBNull.Value;
                _comandosql.Parameters.Add("@ciudad", SqlDbType.VarChar, 30).Value = ciudad ?? (object)DBNull.Value;
                _comandosql.Parameters.Add("@estado", SqlDbType.VarChar, 30).Value = estado ?? (object)DBNull.Value;
                _comandosql.Parameters.Add("@pais", SqlDbType.VarChar, 30).Value = pais ?? (object)DBNull.Value;

                // Ejecutar sin resultados
                _comandosql.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw;

            }
            finally
            {
                desconectar();
            }
        }

        public DataTable sp_BuscarClientes(char opcion, string termino)
        {
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                using (var cmd = new SqlCommand("sp_BuscarClientes", _conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Opcion", opcion);
                    cmd.Parameters.AddWithValue("@Termino", termino);
                    using (var da = new SqlDataAdapter(cmd))
                        da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar clientes: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                desconectar();
            }
            return tabla;
        }


        public DataTable GetHistorialClientes(string clienteRFC, int? año, bool todaHistoria)
        {
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                using (var cmd = new SqlCommand("PIA_VILLA.dbo.sp_GetHistorialClientes", _conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClienteRFC", (object)clienteRFC ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Año", (object)año ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@TodaHistoria", todaHistoria);
                    using (var da = new SqlDataAdapter(cmd))
                        da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el historial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                desconectar();
            }
            return tabla;
        }

        public bool GenerateHistorialPDF(string clienteRFC, int? año, bool todaHistoria)
        {
            try
            {
                DataTable dt = GetHistorialClientes(clienteRFC, año, todaHistoria);
                if (dt.Rows.Count == 0)
                {
                    throw new Exception("No hay datos para generar el PDF.");
                }

                string detalleRows = "";
                foreach (DataRow row in dt.Rows)
                {
                    string fechaCheckIn = row["Fecha de Check In"] != DBNull.Value
                        ? Convert.ToDateTime(row["Fecha de Check In"]).ToString("dd/MM/yyyy")
                        : "No disponible";
                    string fechaCheckOut = row["Fecha de Check Out"] != DBNull.Value
                        ? Convert.ToDateTime(row["Fecha de Check Out"]).ToString("dd/MM/yyyy")
                        : "No disponible";

                    detalleRows += $"<tr>" +
                        $"<td>{row["Nombre del cliente"]}</td>" +
                        $"<td>{row["Ciudad"]}</td>" +
                        $"<td>{row["Hotel"]}</td>" +
                        $"<td>{row["Tipo de habitación"]}</td>" +
                        $"<td>{row["Habitaciones Asignadas"]}</td>" +
                        $"<td>{row["Número de personas hospedadas"]}</td>" +
                        $"<td>{row["Código de reservación"]}</td>" +
                        $"<td>{Convert.ToDateTime(row["Fecha de reservación"]).ToString("dd/MM/yyyy")}</td>" +
                        $"<td>{fechaCheckIn}</td>" +
                        $"<td>{fechaCheckOut}</td>" +
                        $"<td>{row["Estatus de la reservación"]}</td>" +
                        $"<td>{Convert.ToDecimal(row["Anticipo"]).ToString("C2")}</td>" +
                        $"<td>{Convert.ToDecimal(row["Monto de hospedaje"]).ToString("C2")}</td>" +
                        $"<td>{Convert.ToDecimal(row["Monto de servicios adicionales"]).ToString("C2")}</td>" +
                        $"<td>{Convert.ToDecimal(row["Total Factura"]).ToString("C2")}</td>" +
                        $"</tr>";
                }

                string templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Facturas", "ReporteHistorial.html");
                if (!File.Exists(templatePath))
                {
                    throw new Exception("No se encontró la plantilla HTML.");
                }
                string htmlTemplate = File.ReadAllText(templatePath);
                string htmlContent = htmlTemplate
                    .Replace("{DETALLE_ROWS}", detalleRows)
                    .Replace("{FECHA}", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));

                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                    saveDialog.Title = "Guardar historial de clientes como PDF";
                    saveDialog.FileName = $"HistorialClientes_RFC_{clienteRFC}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                    if (saveDialog.ShowDialog() != DialogResult.OK)
                        return false; // Usuario canceló

                    string pdfPath = saveDialog.FileName;
                    using (FileStream fs = new FileStream(pdfPath, FileMode.Create))
                    {
                        Document document = new Document(PageSize.A4.Rotate(), 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(document, fs);
                        document.Open();
                        using (StringReader sr = new StringReader(htmlContent))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, sr);
                        }
                        document.Close();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al generar el PDF: {ex.Message}");
            }
        }







    }
}
