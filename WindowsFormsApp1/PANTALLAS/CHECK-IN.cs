using PIA_VILLA;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1.PANTALLAS
{
    public partial class CHECK_IN : Form
    {
        private Reservaciones_DAO con;

        public CHECK_IN()
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

        private void CHECK_IN_Load(object sender, EventArgs e)
        {
            LoadReservations();
            // Formatear columnas de fecha en el DataGridView
            if (DG_RSV.Columns["FechaEntrada"] != null)
                DG_RSV.Columns["FechaEntrada"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            if (DG_RSV.Columns["FechaSalida"] != null)
                DG_RSV.Columns["FechaSalida"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
        }

        private void LoadReservations(string codRsv = null)
        {
            try
            {
                DataTable dt = con.sp_GetRsvCheckIn(codRsv);
                DG_RSV.DataSource = dt;
                FormatearColumnasDinero();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las reservaciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FormatearColumnasDinero()
        {
            string[] columnasDinero = { "Anticipo", "Total", "Costo", "Precio", "Monto" };
            foreach (var col in columnasDinero)
            {
                if (DG_RSV.Columns.Contains(col))
                {
                    DG_RSV.Columns[col].DefaultCellStyle.Format = "C2";
                    DG_RSV.Columns[col].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        private void BTN_CHECKIN_Click(object sender, EventArgs e)
        {
            try
            {
                if (DG_RSV.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, selecciona una reservación para hacer el check-in.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string codRsv = DG_RSV.CurrentRow.Cells["Código_de_Reservación"].Value.ToString();
                DateTime fechaCheckIn = DateTime.Now;
                fechaCheckIn = new DateTime(fechaCheckIn.Year, fechaCheckIn.Month, fechaCheckIn.Day, fechaCheckIn.Hour, fechaCheckIn.Minute, 0);

                var fechas = con.GetFechasReservacion(codRsv);
                if (fechas == null || !fechas.FechaEntrada.HasValue || !fechas.FechaSalida.HasValue)
                {
                    MessageBox.Show("No se encontraron fechas válidas para la reservación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (fechaCheckIn < fechas.FechaEntrada || fechaCheckIn > fechas.FechaSalida)
                {
                    MessageBox.Show("La fecha y hora de check-in deben estar dentro del rango de la reservación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                con.sp_InsertCheckIn(codRsv, fechaCheckIn);
                MessageBox.Show("Check-in realizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReservations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException != null ? ex.InnerException.Message : ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}