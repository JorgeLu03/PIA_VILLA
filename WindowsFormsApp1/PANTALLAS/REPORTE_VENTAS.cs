using PIA_VILLA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.MODELOS;

namespace WindowsFormsApp1.PANTALLAS
{
    public partial class REPORTE_VENTAS : Form
    {
        private Facturas_DAO dao;
        public REPORTE_VENTAS()
        {

            InitializeComponent();
        }


        private void REPORTE_VENTAS_Load(object sender, EventArgs e)
        {
            try
            {
                dao = new Facturas_DAO(); // ← usa el campo

                var (paises, ciudades, hoteles) = dao.GetFiltrosReporteHospedaje();

                CB_PAIS.DataSource = paises;
                CB_PAIS.DisplayMember = "Pais";
                CB_PAIS.ValueMember = "Pais";
                CB_PAIS.SelectedIndex = -1;

                CB_CD.DataSource = ciudades;
                CB_CD.DisplayMember = "Ciudad";
                CB_CD.ValueMember = "Ciudad";
                CB_CD.SelectedIndex = -1;

                CB_HOTEL.DataSource = hoteles;
                CB_HOTEL.DisplayMember = "Nombre";
                CB_HOTEL.ValueMember = "Nombre";
                CB_HOTEL.SelectedIndex = -1;

                NUD_AÑO.Minimum = 2000;
                NUD_AÑO.Maximum = 2100;
                NUD_AÑO.Value = DateTime.Now.Year;

                ActualizarReporte();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar filtros: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PRINCIPAL principalWdw = new PRINCIPAL();
            principalWdw.ShowDialog();
        }

        private void CB_PAIS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_PAIS.SelectedIndex != -1)
            {
                CargarCiudadesPorPais(CB_PAIS.SelectedValue.ToString());
            }
            // Si el usuario deselecciona el país, limpiar las ciudades y hoteles
            else
            {
                CB_CD.DataSource = null;
                CB_CD.SelectedIndex = -1;
                CB_HOTEL.DataSource = null;
                CB_HOTEL.SelectedIndex = -1;
                ActualizarReporte();
            }
        }
  
        private void CargarCiudadesPorPais(string pais)
        {
            try
            {
                var ciudades = dao.GetCiudadesPorPais(pais);
                CB_CD.DataSource = ciudades;
                CB_CD.DisplayMember = "Ciudad";
                CB_CD.ValueMember = "Ciudad";
                CB_CD.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar ciudades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CB_CD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_CD.SelectedIndex != -1)
            {
                CargarHotelesPorCiudad(CB_CD.SelectedValue.ToString());
            }
            // Si el usuario deselecciona la ciudad, limpiar los hoteles
            else
            {
                CB_HOTEL.DataSource = null;
                CB_HOTEL.SelectedIndex = -1;
                ActualizarReporte();
            }
        }
        private void CargarHotelesPorCiudad(string ciudad)
        {
            try
            {
                var hoteles = dao.GetHotelesPorCiudad(ciudad);
                CB_HOTEL.DataSource = hoteles;
                CB_HOTEL.DisplayMember = "Nombre";
                CB_HOTEL.ValueMember = "Nombre";
                CB_HOTEL.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar hoteles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarReporte()
        {
            try
            {
                int año = (int)NUD_AÑO.Value;
                string pais = CB_PAIS.SelectedValue?.ToString();
                string ciudad = CB_CD.SelectedValue?.ToString();
                string hotel = CB_HOTEL.SelectedValue?.ToString();

                // Llamar al nuevo método del DAO para obtener los datos del reporte de ventas
                DataTable dtDetalle = dao.GetDataForDG_VENTAS2(pais, año, ciudad, hotel);

                // Asignar el DataTable al DataGridView
                DG_VEN.DataSource = dtDetalle;

                // Formatear las columnas de ingresos como moneda
                if (DG_VEN.Columns.Count > 0)
                {
                    FormatearColumnasMoneda();
                    AjustarAnchoDeColumnas();
                    DeshabilitarOrdenamientoDeColumnas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de siempre: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FormatearColumnasMoneda()
        {
            if (DG_VEN.Columns.Contains("Ingresos por Hospedaje"))
            {
                DG_VEN.Columns["Ingresos por Hospedaje"].DefaultCellStyle.Format = "C2";
                DG_VEN.Columns["Ingresos por Hospedaje"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (DG_VEN.Columns.Contains("Ingresos por Servicios"))
            {
                DG_VEN.Columns["Ingresos por Servicios"].DefaultCellStyle.Format = "C2";
                DG_VEN.Columns["Ingresos por Servicios"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (DG_VEN.Columns.Contains("Ingresos Totales"))
            {
                DG_VEN.Columns["Ingresos Totales"].DefaultCellStyle.Format = "C2";
                DG_VEN.Columns["Ingresos Totales"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void AjustarAnchoDeColumnas()
        {
            DG_VEN.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void DeshabilitarOrdenamientoDeColumnas()
        {
            foreach (DataGridViewColumn column in DG_VEN.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void CB_HOTEL_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarReporte();
        }

        private void NUD_AÑO_ValueChanged(object sender, EventArgs e)
        {
            ActualizarReporte();
        }

        private void BTN_PDF_Click(object sender, EventArgs e)
        {
            try
            {
                int año = (int)NUD_AÑO.Value;

                string pais = CB_PAIS.SelectedIndex != -1 ? CB_PAIS.SelectedValue?.ToString() : null;
                string ciudad = CB_CD.SelectedIndex != -1 ? CB_CD.SelectedValue?.ToString() : null;
                string hotel = CB_HOTEL.SelectedIndex != -1 && CB_HOTEL.SelectedValue?.ToString() != "Todos los hoteles" ? CB_HOTEL.SelectedValue?.ToString() : null;

                bool exito = dao.GenerateReporteVentasPDF(pais, año, ciudad, hotel);
                if (exito)
                {
                    MessageBox.Show("Reporte PDF generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Si el usuario cancela, no se muestra ningún mensaje
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
