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

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace WindowsFormsApp1.PANTALLAS
{
    public partial class REPORTE_OCUP : Form
    {
        private Facturas_DAO dao;
        private int numNomina;

        public REPORTE_OCUP()
        {
            InitializeComponent();
        }

        private void REPORTE_OCUP_Load(object sender, EventArgs e)
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
                NUD_AÑO.Value = 2025;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar filtros: " + ex.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PRINCIPAL principalWdw = new PRINCIPAL();
            principalWdw.ShowDialog();

        }

        private void ActualizarGrids()
        {
            try
            {
                // Verificar que el año esté definido (siempre lo estará)
                int año = (int)NUD_AÑO.Value;

                // Obtener los filtros (pueden estar vacíos)
                string pais = CB_PAIS.SelectedValue?.ToString();
                string ciudad = CB_CD.SelectedValue?.ToString();
                string hotel = CB_HOTEL.SelectedValue?.ToString();

                // Llamar a los métodos del DAO
                var dtDetalle = dao.GetDataForDG_OCUP1(pais, año, ciudad, hotel);
                var dtResumen = dao.GetDataForDG_OCUP2(pais, año, ciudad, hotel);

                DG_OCUP1.DataSource = dtDetalle;
                DG_OCUP2.DataSource = dtResumen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el reporte: " + ex.Message);
            }
        }

        private void CB_PAIS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_PAIS.SelectedIndex != -1)
            {
                var ciudades = dao.GetCiudadesPorPais(CB_PAIS.SelectedValue.ToString());
                CB_CD.DataSource = ciudades;
                CB_CD.DisplayMember = "Ciudad";
                CB_CD.ValueMember = "Ciudad";
                CB_CD.SelectedIndex = -1;
            }
        }

        private void CB_CD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_CD.SelectedIndex != -1)
            {
                var hoteles = dao.GetHotelesPorCiudad(CB_CD.SelectedValue.ToString());
                CB_HOTEL.DataSource = hoteles;
                CB_HOTEL.DisplayMember = "Nombre";
                CB_HOTEL.ValueMember = "Nombre";
                CB_HOTEL.SelectedIndex = -1;
            }
        }

        private void CB_HOTEL_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGrids();

        }

        private void NUD_AÑO_ValueChanged(object sender, EventArgs e)
        {
            ActualizarGrids();

        }

        private void BTN_PDF_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén los filtros actuales
                int año = (int)NUD_AÑO.Value;
                string pais = CB_PAIS.SelectedValue?.ToString();
                string ciudad = CB_CD.SelectedValue?.ToString();
                string hotel = CB_HOTEL.SelectedValue?.ToString();

                // Llama al método del DAO para generar el PDF
                dao.GenerateReporteOcupacionPDF(pais, año, ciudad, hotel);

                MessageBox.Show("PDF generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}