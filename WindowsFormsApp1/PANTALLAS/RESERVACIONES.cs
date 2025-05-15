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
            OcultarLabelsFactura();

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

        private void DG_CLIENTES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTN_CLS_Click(object sender, EventArgs e)
        {
        LimpiarCamposReserva();
        }

        private void LimpiarCamposReserva()
        {
            NUD_CANTPER.Value = 0;
            NUD_CANTHAB.Value = 0;
            TB_ANTICIPO.Text = "";
            DTP_ENTRADA.Value = DateTime.Now;
            DTP_SALIDA.Value = DateTime.Now;
            TB_BUSQ.Text = "";
            CB_BUSQ.Items.Clear();
            CB_BUSQ.Items.Add("");
            CB_BUSQ.Items.Add("RFC");
            CB_BUSQ.Items.Add("Correo");
            CB_BUSQ.Items.Add("Nombre");
            CB_BUSQ.SelectedIndex = 0;
            CB_CD.SelectedIndex = -1;
            var conn = new Hoteles_DAO();
            var TabHoteles = new DataTable();
            TabHoteles = conn.sp_GetHoteles();
            DG_HOTELES.DataSource = TabHoteles;
            DG_HOTELES.Columns["IDHotel"].Visible = false;
            DG_HOTELES.Columns["Inicio_de_Operaciones"].Visible = false;
            DG_HOTELES.Columns["Usuario_Registro"].Visible = false;

            // Limpiar DataGridView de tipos de habitación y características
            DG_TIPOHAB.DataSource = null;
            DG_CAR.DataSource = null;
            OcultarLabelsFactura();
        }
        private void BTN_RSV_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que haya una fila seleccionada en cada DataGridView
                if (DG_CLIENTES.CurrentRow == null ||
                    DG_HOTELES.CurrentRow == null ||
                    DG_TIPOHAB.CurrentRow == null)
                {
                    MessageBox.Show("Selecciona un cliente, hotel y tipo de habitación.");
                    return;
                }

                string rfc = DG_CLIENTES.CurrentRow.Cells["RFC"].Value.ToString();
                int idTipoHab = Convert.ToInt32(DG_TIPOHAB.CurrentRow.Cells["IDTipoHab"].Value);
                int cantHab = (int)NUD_CANTHAB.Value;
                int numPersonas = (int)NUD_CANTPER.Value;
                DateTime entrada = DTP_ENTRADA.Value;
                DateTime salida = DTP_SALIDA.Value;
                decimal anticipo = decimal.TryParse(TB_ANTICIPO.Text, out decimal result) ? result : 0;

                // Este número deberías obtenerlo del login, por ejemplo:
                int numNomina = SESIÓN.NumNómina; // ajusta según tu implementación

                // Generar código de reservación (aleatorio de 8 caracteres)
                string codRsv = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();

                // Ejecutar
                var dao = new Reservaciones_DAO();
                dao.sp_RegistrarReservacion(codRsv, rfc, idTipoHab, cantHab, numPersonas, entrada, salida, numNomina, anticipo);

                MessageBox.Show("Reservación registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposReserva();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarFacturaPreview()
        {
            try
            {
                // Asegurarse de que haya una selección válida
                if (DG_TIPOHAB.CurrentRow == null) return;

                string hotel = DG_HOTELES.CurrentRow?.Cells["Nombre"].Value.ToString();
                string tipoHab = DG_TIPOHAB.CurrentRow.Cells["Nivel"].Value.ToString();
                int cantidadHab = (int)NUD_CANTHAB.Value;
                DateTime fEntrada = DTP_ENTRADA.Value.Date;
                DateTime fSalida = DTP_SALIDA.Value.Date;

                // Calcular número de noches
                int noches = (int)(fSalida - fEntrada).TotalDays;
                if (noches <= 0) noches = 1;

                int precio = Convert.ToInt32(DG_TIPOHAB.CurrentRow.Cells["Costo"].Value);
                decimal costo = noches * cantidadHab * precio;
                decimal iva = costo * 0.16m;
                decimal total = costo + iva;

                decimal anticipo = decimal.TryParse(TB_ANTICIPO.Text, out decimal result) ? result : 0;
                decimal restante = total - anticipo;

                // Asignar valores
                lbHotel.Text = hotel;
                lbTipoHab.Text = tipoHab;
                lbCantHab.Text = cantidadHab.ToString();
                lbFEn.Text = fEntrada.ToShortDateString();
                lbFSal.Text = fSalida.ToShortDateString();
                lbCost.Text = costo.ToString("C");
                lbIVA.Text = iva.ToString("C");
                lbCostFin.Text = total.ToString("C");
                lbMiss.Text = restante.ToString("C");

                // Solo hacer visibles los labels si antes estaban ocultos
                if (!lbHotel.Visible)
                {
                    lbHotel.Visible = true;
                    lbTipoHab.Visible = true;
                    lbCantHab.Visible = true;
                    lbFEn.Visible = true;
                    lbFSal.Visible = true;
                    lbCost.Visible = true;
                    lbIVA.Visible = true;
                    lbCostFin.Visible = true;
                    lbMiss.Visible = true;
                }

            }
            catch
            {
                // Ignorar errores durante actualización en tiempo real
            }
        }

        private void OcultarLabelsFactura()
        {
            lbHotel.Visible = false;
            lbTipoHab.Visible = false;
            lbCantHab.Visible = false;
            lbFEn.Visible = false;
            lbFSal.Visible = false;
            lbCost.Visible = false;
            lbIVA.Visible = false;
            lbCostFin.Visible = false;
            lbMiss.Visible = false;
        }
        private void DG_CLIENTES_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarFacturaPreview();

        }

        private void DG_HOTELES_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarFacturaPreview();

        }

        private void DG_TIPOHAB_SelectionChanged(object sender, EventArgs e)
        {
            if (DG_TIPOHAB.CurrentRow != null)
            {
                ActualizarFacturaPreview();
            }
        }

        private void DTP_ENTRADA_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFacturaPreview();

        }

        private void DTP_SALIDA_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFacturaPreview();

        }

        private void NUD_CANTPER_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFacturaPreview();

        }

        private void NUD_CANTHAB_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFacturaPreview();

        }

        private void TB_ANTICIPO_TextChanged(object sender, EventArgs e)
        {
            ActualizarFacturaPreview();

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void lbCostFin_Click(object sender, EventArgs e)
        {

        }
    }
}
