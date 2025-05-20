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

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace WindowsFormsApp1.PANTALLAS
{
    public partial class CHECK_OUT : Form
    {
        private Reservaciones_DAO con;

        public CHECK_OUT()
        {
            InitializeComponent();
            con = new Reservaciones_DAO();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PRINCIPAL principalWdw = new PRINCIPAL();
            principalWdw.ShowDialog();
        }

        private void FormatearColumnasDinero()
        {
            string[] columnasDinero = { "Costo_Por_Noche", "Costo_de_Hospedaje", "IVA", "Total_Con_IVA", "Anticipo", "Descuento", "Pendiente" };
            foreach (var col in columnasDinero)
            {
                if (DG_RSV.Columns.Contains(col))
                {
                    DG_RSV.Columns[col].DefaultCellStyle.Format = "C2";
                    DG_RSV.Columns[col].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            

        }

        private void CHECK_OUT_Load(object sender, EventArgs e)
        {

            TB_DESC.Text = "$";
            TB_DESC.ForeColor = Color.Gray;

            TB_DESC.GotFocus += (s, ev) =>
            {
                if (TB_DESC.Text == "$")
                {
                    TB_DESC.Text = "";
                    TB_DESC.ForeColor = Color.Black;
                }
            };

            TB_DESC.LostFocus += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(TB_DESC.Text))
                {
                    TB_DESC.Text = "$";
                    TB_DESC.ForeColor = Color.Gray;
                }
            };
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
            if (DG_SERV.Columns.Contains("Costo_después_de_Impuestos"))
            {
                DG_SERV.Columns["Costo_después_de_Impuestos"].DefaultCellStyle.Format = "C2";
                DG_SERV.Columns["Costo_después_de_Impuestos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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

                // Validación de descuento
                decimal descuento;
                string descuentoTexto = TB_DESC.Text.Replace("$", "").Trim();
                if (!decimal.TryParse(descuentoTexto, out descuento) || descuento < 0)
                {
                    MessageBox.Show("Por favor, ingresa un valor de descuento válido (número decimal positivo).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TB_DESC.Focus();
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

            // Asigna el descuento de la fila seleccionada a TB_DESC
            if (DG_RSV.Columns.Contains("Descuento") && DG_RSV.Rows[e.RowIndex].Cells["Descuento"].Value != DBNull.Value)
            {
                TB_DESC.Text = DG_RSV.Rows[e.RowIndex].Cells["Descuento"].Value.ToString();
                TB_DESC.ForeColor = Color.Black;
            }
            else
            {
                TB_DESC.Text = "$";
                TB_DESC.ForeColor = Color.Gray;
            }


            // Desmarcar todos los elementos del CheckedListBox al hacer clic en una nueva fila
            for (int i = 0; i < CLB_SERV.Items.Count; i++)
            {
                CLB_SERV.SetItemChecked(i, false);
            }

            string codRsv = DG_RSV.Rows[e.RowIndex].Cells["Código_de_Reservación"].Value.ToString();

            // Obtener descuento (esto ya lo tienes)
            decimal descuento = 0;
            decimal.TryParse(TB_DESC.Text.Trim(), out descuento);

            var DAT = new Reservaciones_DAO();
            DataTable serviciosRsv = DAT.sp_GetServiciosPorReservacion(codRsv);

            for (int i = 0; i < CLB_SERV.Items.Count; i++)
                CLB_SERV.SetItemChecked(i, false);
            foreach (DataRow servicio in serviciosRsv.Rows)
            {
                string nombreServicio = servicio["Nombre"].ToString();
                for (int i = 0; i < CLB_SERV.Items.Count; i++)
                {
                    if (CLB_SERV.Items[i].ToString() == nombreServicio)
                    {
                        CLB_SERV.SetItemChecked(i, true);
                        break;
                    }
                }
            }

            // Obtener servicios seleccionados (adaptado)
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

            // Llamar al procedimiento para obtener el preview (esto también lo tienes)
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
                FormatearColumnasDinero();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las reservaciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_PDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (DG_RSV.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, selecciona una reservación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación de descuento
                decimal descuento;
                string descuentoTexto = TB_DESC.Text.Replace("$", "").Trim();
                if (!decimal.TryParse(descuentoTexto, out descuento) || descuento < 0)
                {
                    MessageBox.Show("Por favor, ingresa un valor de descuento válido (número decimal positivo).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TB_DESC.Focus();
                    return;
                }

                string codRsv = DG_RSV.CurrentRow.Cells["Código_de_Reservación"].Value.ToString();

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

                bool exito = con.GenerateInvoicePDF(codRsv, jsonServicios, descuento);
                if (exito)
                {
                    MessageBox.Show("Factura generada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}