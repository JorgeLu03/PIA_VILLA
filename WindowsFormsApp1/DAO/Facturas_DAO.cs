using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace PIA_VILLA
{
    internal class Facturas_DAO
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

        public (DataTable paises, DataTable ciudades, DataTable hoteles) GetFiltrosReporteHospedaje()
        {
            DataSet ds = new DataSet();
            try
            {
                conectar();
                SqlCommand cmd = new SqlCommand("sp_GetFiltrosReporteHospedaje", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                if (ds.Tables.Count < 3)
                {
                    throw new Exception("No se recibieron todas las tablas necesarias.");
                }

                return (ds.Tables[0], ds.Tables[1], ds.Tables[2]);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los filtros de reporte: " + ex.Message);
            }
            finally
            {
                desconectar();
            }
        }

        public (DataTable Detalle, DataTable Resumen) GetReporteOcupacionHoteles(string pais, int año, string ciudad, string hotel)
        {
            try
            {
                conectar();

                SqlCommand cmd = new SqlCommand("sp_ReporteOcupacionHoteles", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Pais", (object)pais ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Año", año);
                cmd.Parameters.AddWithValue("@Ciudad", (object)ciudad ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Hotel", (object)hotel ?? DBNull.Value);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    if (ds.Tables.Count < 2)
                    {
                        throw new Exception("El procedimiento no devolvió los conjuntos de resultados esperados.");
                    }

                    return (ds.Tables[0], ds.Tables[1]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el reporte de ocupación: {ex.Message}");
            }
            finally
            {
                desconectar();
            }
        }

        public DataTable GetDataForDG_OCUP1(string pais, int año, string ciudad, string hotel)
        {
            try
            {
                var (detalle, _) = GetReporteOcupacionHoteles(pais, año, ciudad, hotel);

                // Crear un nuevo DataTable con nombres de columnas personalizados
                DataTable dt = new DataTable();
                dt.Columns.Add("Ciudad", typeof(string));
                dt.Columns.Add("Nombre_del_Hotel", typeof(string));
                dt.Columns.Add("Año", typeof(int));
                dt.Columns.Add("Mes", typeof(string));
                dt.Columns.Add("Tipo_de_Habitación", typeof(string));
                dt.Columns.Add("Cantidad_de_Habitaciones", typeof(int));
                dt.Columns.Add("Porcentaje_de_Ocupación_(%)", typeof(decimal));
                dt.Columns.Add("Cantidad_de_Personas_Hospedadas", typeof(int));

                // Llenar el DataTable con los datos
                foreach (DataRow row in detalle.Rows)
                {
                    dt.Rows.Add(
                        row["Ciudad"],
                        row["NombreHotel"],
                        row["Año"],
                        row["Mes"],
                        row["TipoHabitacion"],
                        row["CantidadHabitaciones"],
                        Convert.ToDecimal(row["PorcentajeOcupacion"]),
                        row["CantidadPersonas"]
                    );
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al preparar datos para DG_OCUP1: {ex.Message}");
            }
        }

        public DataTable GetDataForDG_OCUP2(string pais, int año, string ciudad, string hotel)
        {
            try
            {
                var (_, resumen) = GetReporteOcupacionHoteles(pais, año, ciudad, hotel);

                // Crear un nuevo DataTable con nombres de columnas personalizados
                DataTable dt = new DataTable();
                dt.Columns.Add("Ciudad", typeof(string));
                dt.Columns.Add("Nombre_del_Hotel", typeof(string));
                dt.Columns.Add("Año", typeof(int));
                dt.Columns.Add("Mes", typeof(string));
                dt.Columns.Add("Porcentaje_de_Ocupación_(%)", typeof(decimal));

                // Llenar el DataTable con los datos
                foreach (DataRow row in resumen.Rows)
                {
                    dt.Rows.Add(
                        row["Ciudad"],
                        row["NombreHotel"],
                        row["Año"],
                        row["Mes"],
                        Convert.ToDecimal(row["PorcentajeOcupacion"])
                    );
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al preparar datos para DG_OCUP2: {ex.Message}");
            }
        }

        public bool GenerateReporteOcupacionPDF(string pais, int año, string ciudad, string hotel)
        {
            try
            {
                var (detalle, resumen) = GetReporteOcupacionHoteles(pais, año, ciudad, hotel);

                string detalleRows = "";
                foreach (DataRow row in detalle.Rows)
                {
                    detalleRows += $"<tr>" +
                        $"<td>{row["Ciudad"]}</td>" +
                        $"<td>{row["NombreHotel"]}</td>" +
                        $"<td>{row["Año"]}</td>" +
                        $"<td>{row["Mes"]}</td>" +
                        $"<td>{row["TipoHabitacion"]}</td>" +
                        $"<td>{row["CantidadHabitaciones"]}</td>" +
                        $"<td>{Convert.ToDecimal(row["PorcentajeOcupacion"]).ToString("N2")}%</td>" +
                        $"<td>{row["CantidadPersonas"]}</td>" +
                        $"</tr>";
                }

                string resumenRows = "";
                foreach (DataRow row in resumen.Rows)
                {
                    resumenRows += $"<tr>" +
                        $"<td>{row["Ciudad"]}</td>" +
                        $"<td>{row["NombreHotel"]}</td>" +
                        $"<td>{row["Año"]}</td>" +
                        $"<td>{row["Mes"]}</td>" +
                        $"<td>{Convert.ToDecimal(row["PorcentajeOcupacion"]).ToString("N2")}%</td>" +
                        $"</tr>";
                }

                string templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Facturas", "ReporteOcupacion.html");
                if (!File.Exists(templatePath))
                {
                    throw new Exception("No se encontró la plantilla HTML en la ruta especificada.");
                }
                string htmlTemplate = File.ReadAllText(templatePath);

                string htmlContent = htmlTemplate
                    .Replace("{DETALLE_ROWS}", detalleRows)
                    .Replace("{RESUMEN_ROWS}", resumenRows)
                    .Replace("{FECHA}", DateTime.Now.ToString("dd/MM/yyyy"));

                // Mostrar SaveFileDialog para que el usuario elija la ubicación y nombre del PDF
                // Mostrar SaveFileDialog para que el usuario elija la ubicación y nombre del PDF
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Guardar reporte de ocupación";
                    saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"ReporteOcupacion_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                        return false; // El usuario canceló

                    string pdfPath = saveFileDialog.FileName;

                    using (FileStream fs = new FileStream(pdfPath, FileMode.Create, FileAccess.Write, FileShare.None))
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
                throw new Exception($"Error al generar el PDF del reporte de ocupación: {ex.Message}");
            }
        }

        public DataTable GetPaises()
        {
            DataTable dt = new DataTable();
            try
            {
                conectar();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT Pais FROM PIA_VILLA.dbo.UbiHotel ORDER BY Pais", _conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los países: " + ex.Message);
            }
            finally
            {
                desconectar();
            }
        }

        public DataTable GetCiudadesPorPais(string pais)
        {
            DataTable dt = new DataTable();
            try
            {
                conectar();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT Ciudad FROM PIA_VILLA.dbo.UbiHotel WHERE Pais = @Pais ORDER BY Ciudad", _conexion);
                cmd.Parameters.AddWithValue("@Pais", pais);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las ciudades: " + ex.Message);
            }
            finally
            {
                desconectar();
            }
        }

        public DataTable GetHotelesPorCiudad(string ciudad)
        {
            DataTable dt = new DataTable();
            try
            {
                conectar();
                SqlCommand cmd = new SqlCommand(
                    "SELECT H.Nombre " +
                    "FROM PIA_VILLA.dbo.Hoteles H " +
                    "INNER JOIN PIA_VILLA.dbo.UbiHotel UH ON H.IDUbiHotel = UH.IDUbiHotel " +
                    "WHERE UH.Ciudad = @Ciudad " +
                    "ORDER BY H.Nombre", _conexion);
                cmd.Parameters.AddWithValue("@Ciudad", ciudad);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los hoteles: " + ex.Message);
            }
            finally
            {
                desconectar();
            }
        }

        public (DataTable Detalle, DataTable Resumen) GetReporteVentasHoteles(string pais, int año, string ciudad, string hotel)
        {
            try
            {
                conectar();

                SqlCommand cmd = new SqlCommand("sp_ReporteVentasHoteles", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Pais", (object)pais ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Año", año);
                cmd.Parameters.AddWithValue("@Ciudad", (object)ciudad ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Hotel", (object)hotel ?? DBNull.Value);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    if (ds.Tables.Count < 1) // Ajustamos la validación ya que el SP solo devuelve un resultado
                    {
                        throw new Exception("El procedimiento no devolvió el conjunto de resultados esperado.");
                    }

                    return (ds.Tables[0], new DataTable()); // Devolvemos el DataTable y un DataTable vacío para el "Resumen"
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el reporte de ventas: {ex.Message}");
            }
            finally
            {
                desconectar();
            }
        }

        public DataTable DG_VENTAS(string pais, int año, string ciudad, string hotel)
        {
            try
            {
                var (detalle, _) = GetReporteVentasHoteles(pais, año, ciudad, hotel);

                DataTable dt = new DataTable();
                dt.Columns.Add("Ciudad", typeof(string));
                dt.Columns.Add("Hotel", typeof(string));
                dt.Columns.Add("Año", typeof(int));
                dt.Columns.Add("Mes", typeof(string));
                dt.Columns.Add("Ingresos por Hospedaje", typeof(decimal));
                dt.Columns.Add("Ingresos por Servicios", typeof(decimal));
                dt.Columns.Add("Ingresos Totales", typeof(decimal));

                foreach (DataRow row in detalle.Rows)
                {
                    dt.Rows.Add(
                        row["Ciudad"],
                        row["Hotel"],
                        row["Año"],
                        row["Mes"],
                        Convert.ToDecimal(row["Ingresos_por_Hospedaje"]),
                        Convert.ToDecimal(row["Ingresos_por_Servicios"]),
                        Convert.ToDecimal(row["Ingresos_Totales"])
                    );
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al preparar datos para DG_VENTAS1: {ex.Message}");
            }
        }

        public DataTable DG_VENTAS2(string pais, int año, string ciudad, string hotel)
        {
            try
            {
                conectar();
                SqlCommand cmd = new SqlCommand("sp_ReporteVentasHoteles", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Pais", (object)pais ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Año", año);
                cmd.Parameters.AddWithValue("@Ciudad", (object)ciudad ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Hotel", (object)hotel ?? DBNull.Value);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener datos de ventas: {ex.Message}");
            }
            finally
            {
                desconectar();
            }
        }


        public DataTable GetDataForDG_VENTAS2(string pais, int año, string ciudad, string hotel)
        {
            try
            {
                var (detalle, _) = GetReporteVentasHoteles2(pais, año, ciudad, hotel);

                DataTable dt = new DataTable();
                dt.Columns.Add("Ciudad", typeof(string));
                dt.Columns.Add("Nombre_del_Hotel", typeof(string));
                dt.Columns.Add("Año", typeof(int));
                dt.Columns.Add("Mes", typeof(string));
                dt.Columns.Add("Ingresos_por_Hospedaje", typeof(decimal));
                dt.Columns.Add("Ingresos_por_Servicios", typeof(decimal));
                dt.Columns.Add("Ingresos_Totales", typeof(decimal));

                foreach (DataRow row in detalle.Rows)
                {
                    dt.Rows.Add(
                        row["Ciudad"],
                        row["Hotel"],
                        row["Año"],
                        row["Mes"],
                        Convert.ToDecimal(row["Ingresos_por_Hospedaje"]),
                        Convert.ToDecimal(row["Ingresos_por_Servicios"]),
                        Convert.ToDecimal(row["Ingresos_Totales"])
                    );
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al preparar datos para DG_VENTAS1: {ex.Message}");
            }
        }

        public (DataTable Detalle, DataTable Resumen) GetReporteVentasHoteles2(string pais, int año, string ciudad, string hotel)
        {
            try
            {
                conectar();

                SqlCommand cmd = new SqlCommand("sp_ReporteVentasHoteles", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Pais", (object)pais ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Año", año);
                cmd.Parameters.AddWithValue("@Ciudad", (object)ciudad ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Hotel", (object)hotel ?? DBNull.Value);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    if (ds.Tables.Count < 1)
                    {
                        throw new Exception("El procedimiento no devolvió el conjunto de resultados esperado.");
                    }

                    return (ds.Tables[0], new DataTable());
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el reporte de ventas: {ex.Message}");
            }
            finally
            {
                desconectar();
            }
        }

        public bool GenerateReporteVentasPDF(string pais, int año, string ciudad, string hotel)
        {
            try
            {
                // Ajustar la llamada para desestructurar el resultado de GetReporteVentasHoteles2
                var (detalle, _) = GetReporteVentasHoteles2(pais, año, ciudad, hotel);

                string detalleRows = "";
                foreach (DataRow row in detalle.Rows)
                {
                    detalleRows += $"<tr>" +
                        $"<td>{row["Ciudad"]}</td>" +
                        $"<td>{row["Hotel"]}</td>" +
                        $"<td>{row["Año"]}</td>" +
                        $"<td>{row["Mes"]}</td>" +
                        $"<td>{Convert.ToDecimal(row["Ingresos_por_Hospedaje"]).ToString("C2")}</td>" +
                        $"<td>{Convert.ToDecimal(row["Ingresos_por_Servicios"]).ToString("C2")}</td>" +
                        $"<td>{Convert.ToDecimal(row["Ingresos_Totales"]).ToString("C2")}</td>" +
                        $"</tr>";
                }

                string templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Facturas", "ReporteVentas.html");
                if (!File.Exists(templatePath))
                {
                    throw new Exception("No se encontró la plantilla HTML en la ruta especificada.");
                }
                string htmlTemplate = File.ReadAllText(templatePath);

                string htmlContent = htmlTemplate
                    .Replace("{DETALLE_ROWS}", detalleRows)
                    .Replace("{FECHA}", DateTime.Now.ToString("dd/MM/yyyy"));

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Guardar reporte de ventas";
                    saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"ReporteVentas_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                        return false; // Usuario canceló

                    string pdfPath = saveFileDialog.FileName;

                    using (FileStream fs = new FileStream(pdfPath, FileMode.Create, FileAccess.Write, FileShare.None))
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
                throw new Exception($"Error al generar el PDF del reporte de ventas: {ex.Message}");
            }
        }
    }
}