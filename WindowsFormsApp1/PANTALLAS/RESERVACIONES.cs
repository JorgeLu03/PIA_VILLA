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

            CB_CD.SelectedIndexChanged -= CB_CD_SelectedIndexChanged; // Desasocia el evento

            CargarCiudadesEnComboBox();
            CB_BUSQ.Items.Clear();
            CB_BUSQ.Items.Add("RFC");
            CB_BUSQ.Items.Add("Correo");
            CB_BUSQ.Items.Add("Nombre");
            CB_BUSQ.SelectedIndex = -1;
            CB_CD.SelectedIndex = -1;
            CB_CD.SelectedIndexChanged += CB_CD_SelectedIndexChanged; // Reasocia el evento


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
                    // ¡Revisa aquí! ¿Hay alguna línea que manipule la selección o la fila actual de 'ciudades'?
                }
                else
                {
                    // Manejar el caso de no haber ciudades
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las ciudades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CB_BUSQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TB_BUSQ.Clear();
            //DG_CLIENTES.DataSource = null;
            //TB_BUSQ.Focus();
        }

        private void TB_BUSQ_TextChanged(object sender, EventArgs e)
        {
            // Si no hay opción seleccionada, carga todo
            if (CB_BUSQ.SelectedIndex < 0)
            {
                DG_CLIENTES.DataSource = new Clientes_DAO().sp_GetClientes();
                return;
            }

            // Determina la opción
            char opcion;
            switch (CB_BUSQ.SelectedItem.ToString())
            {
                case "RFC":
                    opcion = 'R';
                    break;
                case "Correo":
                    opcion = 'C';
                    break;
                case "Nombre":
                    opcion = 'N';
                    break;
                default:
                    return;
            }

            // Ejecuta la búsqueda
            var dao = new Clientes_DAO();
            var resultados = dao.sp_BuscarClientes(opcion, TB_BUSQ.Text.Trim());
            DG_CLIENTES.DataSource = resultados;
        }

        private void CB_CD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_CD.SelectedIndex > -1)
            {
                string ciudadSeleccionada = CB_CD.Text;
                var conn = new Hoteles_DAO();
                DataTable hotelesPorCiudad = conn.sp_BuscarHotel(ciudadSeleccionada);
                DG_HOTELES.DataSource = hotelesPorCiudad;

                // Oculta columnas técnicas si es necesario
                if (DG_HOTELES.Columns.Contains("IDHotel"))
                    DG_HOTELES.Columns["IDHotel"].Visible = false;
                if (DG_HOTELES.Columns.Contains("Inicio_de_Operaciones"))
                    DG_HOTELES.Columns["Inicio_de_Operaciones"].Visible = false;
                if (DG_HOTELES.Columns.Contains("Usuario_Registro"))
                    DG_HOTELES.Columns["Usuario_Registro"].Visible = false;
            }
        }

        private void BTN_CLF_Click(object sender, EventArgs e)
        {
            CB_CD.SelectedIndex = -1;
            var conn = new Hoteles_DAO();
            var TabHoteles = new DataTable();
            TabHoteles = conn.sp_GetHoteles();
            DG_HOTELES.DataSource = TabHoteles;
            DG_HOTELES.Columns["IDHotel"].Visible = false;
            DG_HOTELES.Columns["Inicio_de_Operaciones"].Visible = false;
            DG_HOTELES.Columns["Usuario_Registro"].Visible = false;
        }
    }
}
