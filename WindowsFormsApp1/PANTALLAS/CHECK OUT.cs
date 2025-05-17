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
    public partial class CHECK_OUT : Form
    {
        private Reservaciones_DAO con; // Declare 'con' as a private field  

        public CHECK_OUT()
        {
            InitializeComponent();
            con = new Reservaciones_DAO(); // Initialize 'con' in the constructor  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PRINCIPAL principalWdw = new PRINCIPAL();
            principalWdw.ShowDialog();
        }

        private void CHECK_OUT_Load(object sender, EventArgs e)
        {

            LoadReservations();

            var TabServicios = con.sp_GetServiciosRsv();
            DG_SERV.DataSource = TabServicios;
            DG_SERV.DataSource = TabServicios;
            DG_SERV.Columns["IDServicio"].Visible = false;

            CLB_SERV.Items.Clear();

            foreach (DataRow row in TabServicios.Rows)
            {
                if (row.Table.Columns.Contains("Nombre"))
                {
                    CLB_SERV.Items.Add(row["Nombre"]);
                }
                else
                {
                    MessageBox.Show("La columna no se encontró en la tabla de servicios.", "Error");
                    break;
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BTN_COUT_Click(object sender, EventArgs e)
        {
            try
            {
                if (DG_RSV.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, selecciona una reservación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string codRsv = DG_RSV.CurrentRow.Cells["Código_de_Reservación"].Value.ToString();
                DateTime fechaCheckOut = DateTime.Now;
                fechaCheckOut = new DateTime(fechaCheckOut.Year, fechaCheckOut.Month, fechaCheckOut.Day, fechaCheckOut.Hour, fechaCheckOut.Minute, 0);

                var fCheckIn = con.GetCheckInDate(codRsv);
                if (!fCheckIn.HasValue)
                {
                    MessageBox.Show("No se ha realizado el check-in para esta reservación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (fechaCheckOut <= fCheckIn.Value)
                {
                    MessageBox.Show("La fecha y hora de check-out deben ser posteriores a la de check-in.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal descuento;
                if (!decimal.TryParse(TB_DESC.Text.Trim(), out descuento) || descuento < 0)
                {
                    descuento = 0;
                }

                var serviciosSeleccionados = new List<int>();
                foreach (var item in CLB_SERV.CheckedItems)
                {
                    foreach (DataGridViewRow row in DG_SERV.Rows)
                    {
                        if (row.Cells["Nombre"].Value.ToString() == item.ToString())
                        {
                            serviciosSeleccionados.Add(Convert.ToInt32(row.Cells["IDServicio"].Value));
                            break;
                        }
                    }
                }

                string jsonServicios = "[" + string.Join(",", serviciosSeleccionados.Select(id => $"{{\"ID\":{id}}}")) + "]";

                con.sp_InsertCheckOut(codRsv, fechaCheckOut, jsonServicios, descuento);
                MessageBox.Show("Check-out realizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var TabRsv = con.GetFacturaPreview();
                DG_RSV.DataSource = TabRsv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException != null ? ex.InnerException.Message : ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DG_RSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DG_RSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || DG_RSV.Rows[e.RowIndex].Cells["Código_de_Reservación"].Value == null)
            {
                LB_FOLIO.Visible = false;
                LB_COST.Visible = false;
                return;
            }

            string codRsv = DG_RSV.Rows[e.RowIndex].Cells["Código_de_Reservación"].Value.ToString();

            // Obtener descuento
            decimal descuento = 0;
            decimal.TryParse(TB_DESC.Text.Trim(), out descuento);

            // Obtener servicios seleccionados
            var serviciosSeleccionados = new List<int>();
            foreach (var item in CLB_SERV.CheckedItems)
            {
                foreach (DataGridViewRow row in DG_SERV.Rows)
                {
                    if (row.Cells["Nombre"].Value.ToString() == item.ToString())
                    {
                        serviciosSeleccionados.Add(Convert.ToInt32(row.Cells["IDServicio"].Value));
                        break;
                    }
                }
            }

            string jsonServicios = "[" + string.Join(",", serviciosSeleccionados.Select(id => $"{{\"ID\":{id}}}")) + "]";

            // Llamar al procedimiento para obtener el preview
            var dao = new Reservaciones_DAO();
            DataTable preview = dao.sp_GetFacturaPreviewConCostoFinal(codRsv, jsonServicios, descuento);

            if (preview.Rows.Count > 0)
            {
                var row = preview.Rows[0];

                LB_FOLIO.Text = row["Folio"].ToString();
                LB_COST.Text = "$" + Convert.ToDecimal(row["CostoFinal"]).ToString("N2");

                LB_FOLIO.Visible = true;
                LB_COST.Visible = true;
            }
            else
            {
                LB_FOLIO.Visible = false;
                LB_COST.Visible = false;
            }
        }

        private void TB_COD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = TB_COD.Text.Trim();
                LoadReservations(searchText);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar las reservaciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadReservations(string codRsv = null)
        {
            try
            {
                DataTable dt = con.GetFacturaPreviewCodRsv(codRsv);
                DG_RSV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las reservaciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}