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

namespace WindowsFormsApp1.PANTALLAS
{
    public partial class HISTORIAL_CLIENTE : Form
    {

        private Clientes_DAO dao = new Clientes_DAO();
        private string rfcSeleccionado = null;
        public HISTORIAL_CLIENTE()
        {
            InitializeComponent();
            CargarCombos();
            ConfigurarGridClientes();
            CargarClientesDinamico();
        }

        private void CargarCombos()
        {
            CB_FILTRO.Items.AddRange(new string[] { "Nombre", "Correo electrónico", "RFC" });
            CB_FILTRO.SelectedIndex = 0;
            NUD_AÑO.Minimum = 2000;
            NUD_AÑO.Maximum = 2100;
            NUD_AÑO.Value = DateTime.Now.Year;
        }

        private void ConfigurarGridClientes()
        {
            DG_CLIENT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DG_CLIENT.MultiSelect = false;
            DG_CLIENT.AutoGenerateColumns = true;
            DG_CLIENT.Columns.Clear();
            DG_CLIENT.Columns.Add("RFC", "RFC");
            DG_CLIENT.Columns.Add("Nombre", "Nombre");
            DG_CLIENT.Columns.Add("Correo", "Correo");
            DG_CLIENT.Columns["RFC"].DataPropertyName = "RFC";
            DG_CLIENT.Columns["Nombre"].DataPropertyName = "Nombre";
            DG_CLIENT.Columns["Correo"].DataPropertyName = "Correo";
            DG_CLIENT.AutoResizeColumns();
        }

        private void CargarClientesDinamico()
        {
            try
            {
                string criterio = CB_FILTRO.SelectedItem?.ToString();
                string termino = TB_BUSQ.Text.Trim();
                char opcion;

                if (string.IsNullOrEmpty(criterio))
                    return;

                if (criterio == "Nombre") opcion = 'N';
                else if (criterio == "Correo electrónico") opcion = 'C';
                else opcion = 'R'; // RFC

                DataTable dtClientes = dao.sp_BuscarClientes(opcion, termino);
                DG_CLIENT.DataSource = dtClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PRINCIPAL principalWdw = new PRINCIPAL();
            principalWdw.ShowDialog();
        }

        private void HISTORIAL_CLIENTE_Load(object sender, EventArgs e)
        {

        }

        private void TB_BUSQ_TextChanged(object sender, EventArgs e)
        {
            CargarClientesDinamico();
        }

        private void CB_FILTRO_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarClientesDinamico();
        }

        private void DG_CLIENT_SelectionChanged(object sender, EventArgs e)
        {
            if (DG_CLIENT.SelectedRows.Count > 0)
            {
                rfcSeleccionado = DG_CLIENT.SelectedRows[0].Cells["RFC"].Value?.ToString();
                ActualizarHistorial();
            }
            else
            {
                rfcSeleccionado = null;
                DG_HIST.DataSource = null;
            }
        }

        private void ActualizarHistorial()
        {
            try
            {
                if (string.IsNullOrEmpty(rfcSeleccionado))
                {
                    DG_HIST.DataSource = null;
                    return;
                }

                int? año = CHK_EVER.Checked ? (int?)null : (int)NUD_AÑO.Value;
                DataTable dtHistorial = dao.GetHistorialClientes(rfcSeleccionado, año, CHK_EVER.Checked);
                DG_HIST.DataSource = dtHistorial;

                if (DG_HIST.Columns.Count > 0)
                {
                    DG_HIST.Columns["Anticipo"].DefaultCellStyle.Format = "C2";
                    DG_HIST.Columns["Monto de hospedaje"].DefaultCellStyle.Format = "C2";
                    DG_HIST.Columns["Monto de servicios adicionales"].DefaultCellStyle.Format = "C2";
                    DG_HIST.Columns["Total Factura"].DefaultCellStyle.Format = "C2";
                    DG_HIST.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el historial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CHK_EVER_CheckedChanged(object sender, EventArgs e)
        {
            NUD_AÑO.Enabled = !CHK_EVER.Checked;
            ActualizarHistorial();
        }

        private void NUD_AÑO_ValueChanged(object sender, EventArgs e)
        {
            ActualizarHistorial();
        }

        private void BTN_PDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(rfcSeleccionado))
                {
                    MessageBox.Show("Por favor, seleccione un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int? año = CHK_EVER.Checked ? (int?)null : (int)NUD_AÑO.Value;
                bool exito = dao.GenerateHistorialPDF(rfcSeleccionado, año, CHK_EVER.Checked);
                if (exito)
                {
                    MessageBox.Show("PDF generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
