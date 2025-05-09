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
    public partial class RESERVACIONES : Form
    {
        public RESERVACIONES()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PRINCIPAL principalWdw = new PRINCIPAL();
            principalWdw.ShowDialog();
        }

        private void RESERVACIONES_Load(object sender, EventArgs e)
        {
            var con = new Clientes_DAO();
            var TabClients = new DataTable();
            TabClients = con.sp_GetClientes();
            DG_CLIENTES.DataSource = TabClients;

            var conn = new Hoteles_DAO();
            var TabHoteles = new DataTable();
            TabHoteles = conn.sp_GetHoteles();
            DG_HOTELES.DataSource = TabHoteles;
            DG_HOTELES.Columns["IDHotel"].Visible = false;
            DG_HOTELES.Columns["Inicio_de_Operaciones"].Visible = false;
            DG_HOTELES.Columns["Usuario_Registro"].Visible = false;
            CargarCiudadesEnComboBox();

        }

        private void DG_HOTELES_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DG_HOTELES.Rows[e.RowIndex];

                var idHotelValue = fila.Cells["IDHotel"].Value;

                if (idHotelValue != null && idHotelValue != DBNull.Value && int.TryParse(idHotelValue.ToString(), out int idHotel))
                {
                    var tipoHabGrid = new TiposDeHabitacion_DAO();
                    DataTable tiposHabitacion = tipoHabGrid.sp_GetTiposHabPorHotel(idHotel, 1);

                    DG_TIPOHAB.DataSource = tiposHabitacion;
                    DG_TIPOHAB.Columns["IDTipoHab"].Visible = false;
                    DG_TIPOHAB.Columns["IDHotel"].Visible = false;

                    DG_CAR.DataSource = null;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID del hotel seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DG_TIPOHAB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DG_TIPOHAB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DG_TIPOHAB.Rows[e.RowIndex];

                var idTipoHabValue = fila.Cells["IDTipoHab"].Value;

                if (idTipoHabValue != null && idTipoHabValue != DBNull.Value && int.TryParse(idTipoHabValue.ToString(), out int idTipoHab))
                {
                    var carGrid = new TiposDeHabitacion_DAO();
                    DataTable caracteristicas = carGrid.ObtenerCaracteristicasPorTipoHab(idTipoHab);

                    DG_CAR.DataSource = caracteristicas;

                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID del tipo de habitación seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CargarCiudadesEnComboBox()
        {
            try
            {
                var reservacionesDAO = new Reservaciones_DAO();

                DataTable ciudades = reservacionesDAO.sp_GetCiudad();

                if (ciudades.Rows.Count > 0)
                {
                    CB_CD.DataSource = ciudades;
                    CB_CD.DisplayMember = "Ciudad";
                    CB_CD.SelectedIndex = -1;
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las ciudades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
