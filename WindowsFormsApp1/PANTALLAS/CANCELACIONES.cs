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
    public partial class CANCELACIONES : Form
    {
        private Reservaciones_DAO con;

        public CANCELACIONES()
        {
            InitializeComponent();
            con = new Reservaciones_DAO();
        }

        private void CANCELACIONES_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void LoadReservations(string codRsv = null)
        {
            try
            {
                DataTable dt = con.sp_GetRsv(codRsv);
                DG_RSV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las reservaciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TB_BUSQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PRINCIPAL principalWdw = new PRINCIPAL();
            principalWdw.ShowDialog();
        }

        private void BTN_CAN_Click(object sender, EventArgs e)
        {
            if (DG_RSV.CurrentCell != null) // Check if a cell is selected
            {
                try
                {
                    // Get the row index of the selected cell
                    int rowIndex = DG_RSV.CurrentCell.RowIndex;
                    // Get the CodRsv from the CodRsv column of that row
                    string codRsv = DG_RSV.Rows[rowIndex].Cells["CodRsv"].Value.ToString();

                    // Show confirmation dialog
                    DialogResult result = MessageBox.Show(
                        $"¿Está seguro de que desea cancelar la reservación con código {codRsv}?",
                        "Confirmar Cancelación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        con.sp_CancelarReservacion(codRsv);
                        LoadReservations(); // Refresh the DataGridView
                        MessageBox.Show("Reservación cancelada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cancelar la reservación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una celda de la reservación para cancelar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TB_COD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = TB_COD.Text.Trim();
                LoadReservations(searchText); // Reload with the search filter
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar las reservaciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}