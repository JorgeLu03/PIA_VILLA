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
    public partial class HOTEL_MGMT : Form
    {
        private Dictionary<string, int> serviciosDict = new Dictionary<string, int>
        {
            { "Wi-Fi", 1 },
            { "Traslado aeropuerto", 2 },
            { "Spa", 3 },
            { "Gimnasio", 4 },
            { "Playa", 5 },
            { "Lavandería", 6 },
            { "Salón de eventos", 7 },
            { "Piscina", 8 },
            { "Room service", 9 },
            { "Guía Turístico", 10 }

        };

        public HOTEL_MGMT()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PRINCIPAL principalWdw = new PRINCIPAL();
            principalWdw.ShowDialog();
        }

        private void HOTEL_MGMT_Load(object sender, EventArgs e)
        {
            foreach (var servicio in serviciosDict.Keys)
            {
                LB_SERV.Items.Add(servicio);
            }

            var con = new Hoteles_DAO();
            var TabHoteles = new DataTable();
            TabHoteles = con.sp_GetHoteles();
            DG_HOTEL.DataSource = TabHoteles;
            DG_HOTEL.Columns["IDHotel"].Visible = false;

        }

        private void BTN_CLS_Click(object sender, EventArgs e)
        {
            TB_DOM.Text = "";
            TB_NAME.Text = "";
            NUD_PISOS.Value = 0;
            TB_CD.Text = "";
            TB_ED.Text = "";
            TB_PAIS.Text = "";
            CB_ZONATUR.Checked = false;
            for (int i = 0; i < LB_SERV.Items.Count; i++) LB_SERV.SetItemChecked(i, false);
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            var con = new Hoteles_DAO();
            try
            {
                char opcion = 'A';
                string nombre = TB_NAME.Text;
                string domicilio = TB_DOM.Text;
                int pisos = (int)NUD_PISOS.Value;
                string ciudad = TB_CD.Text;
                string estado = TB_ED.Text;
                string pais = TB_PAIS.Text;
                string zona = CB_ZONATUR.Checked ? "Turística" : "No Turística";
                DateTime fechaInicOp = DateTime.Now;
                int numnomina = SESIÓN.NumNómina;

                con.sp_GestionHoteles(opcion, nombre, 0, zona, pisos, fechaInicOp, numnomina, ciudad, estado, pais, domicilio);
                int idHotelNuevo = con.ObtenerUltimoIDHotelInsertado();

                // Asignar servicios al hotel nuevo
                foreach (var item in LB_SERV.CheckedItems)
                {
                    string nombreServicio = item.ToString();

                    if (serviciosDict.TryGetValue(nombreServicio, out int idServicio))
                    {
                        con.sp_GestionServiciosHotel('A', idHotelNuevo, idServicio);
                    }
                    else
                    {
                        MessageBox.Show($"El servicio '{nombreServicio}' no está registrado en el diccionario.");
                    }
                }

                MessageBox.Show("Hotel registrado exitosamente.");
                var TabHoteles = new DataTable();
                TabHoteles = con.sp_GetHoteles();
                DG_HOTEL.DataSource = TabHoteles;
                DG_HOTEL.Columns["IDHotel"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        private void BTN_DEL_Click(object sender, EventArgs e)
        {
            var con = new Hoteles_DAO();
            try
            {
                if (DG_HOTEL.SelectedRows.Count > 0)
                {
                    int idHotel = Convert.ToInt32(DG_HOTEL.SelectedRows[0].Cells["IDHotel"].Value);

                    con.sp_GestionHoteles('E', "", idHotel, "", 0, DateTime.Now, 0, "", "", "", "");

                    MessageBox.Show("Hotel eliminado correctamente.");

                    var TabHoteles = new DataTable();
                    TabHoteles = con.sp_GetHoteles();
                    DG_HOTEL.DataSource = TabHoteles;
                    DG_HOTEL.Columns["IDHotel"].Visible = false;

                }
                else
                {
                    MessageBox.Show("Por favor selecciona un hotel para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }

        }

        private void DG_HOTEL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DG_HOTEL_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void BTN_MOD_Click(object sender, EventArgs e)
        {
            var con = new Hoteles_DAO();
            try
            {
                if (DG_HOTEL.CurrentRow != null)
                {
                    char opcion = 'M';
                    int idHotel = Convert.ToInt32(DG_HOTEL.CurrentRow.Cells["IDHotel"].Value);
                    string nombre = TB_NAME.Text;
                    string domicilio = TB_DOM.Text;
                    int pisos = (int)NUD_PISOS.Value;
                    string ciudad = TB_CD.Text;
                    string estado = TB_ED.Text;
                    string pais = TB_PAIS.Text;
                    string zona = CB_ZONATUR.Checked ? "Turística" : "No Turística";
                    DateTime fechaInicOp = DateTime.Now;
                    int numnomina = SESIÓN.NumNómina;

                    con.sp_GestionHoteles(opcion, nombre, idHotel, zona, pisos, fechaInicOp, numnomina, ciudad, estado, pais, domicilio);

                    // Obtener la lista de servicios actualmente asociados al hotel ANTES de modificar la selección
                    List<string> serviciosActuales = con.sp_GetServiciosHotel(idHotel);
                    List<string> serviciosSeleccionados = new List<string>();
                    foreach (var item in LB_SERV.CheckedItems)
                    {
                        serviciosSeleccionados.Add(item.ToString());
                    }

                    // Identificar servicios a eliminar
                    foreach (string servicioActual in serviciosActuales)
                    {
                        if (!serviciosSeleccionados.Contains(servicioActual, StringComparer.OrdinalIgnoreCase)) // Comparación insensible a mayúsculas
                        {
                            if (serviciosDict.TryGetValue(servicioActual, out int idServicioAEliminar))
                            {
                                con.sp_GestionServiciosHotel('E', idHotel, idServicioAEliminar); // Usamos 'E' para "Eliminar"
                            }
                        }
                    }

                    // Insertar los nuevos servicios seleccionados
                    foreach (string servicioSeleccionado in serviciosSeleccionados)
                    {
                        if (!serviciosActuales.Contains(servicioSeleccionado, StringComparer.OrdinalIgnoreCase))
                        {
                            if (serviciosDict.TryGetValue(servicioSeleccionado, out int idServicioAAgregar))
                            {
                                con.sp_GestionServiciosHotel('A', idHotel, idServicioAAgregar); // Usamos 'A' para "Agregar"
                            }
                        }
                    }

                    MessageBox.Show("Hotel modificado exitosamente.");

                    var TabHoteles = new DataTable();
                    TabHoteles = con.sp_GetHoteles();
                    DG_HOTEL.DataSource = TabHoteles;
                    DG_HOTEL.Columns["IDHotel"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un hotel para modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el hotel: " + ex.Message);
            }
        }

        private void DG_HOTEL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el clic no sea en la fila de encabezado
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DG_HOTEL.Rows[e.RowIndex];

                // Rellenar los TextBox
                TB_NAME.Text = fila.Cells["Nombre"].Value?.ToString();
                TB_DOM.Text = fila.Cells["Domicilio"].Value?.ToString();

                if (fila.Cells["Numero_de_Pisos"].Value != DBNull.Value)
                {
                    NUD_PISOS.Value = Convert.ToDecimal(fila.Cells["Numero_de_Pisos"].Value);
                }
                else
                {
                    NUD_PISOS.Value = NUD_PISOS.Minimum;
                }

                TB_CD.Text = fila.Cells["Ciudad"].Value?.ToString();
                TB_ED.Text = fila.Cells["Estado"].Value?.ToString();
                TB_PAIS.Text = fila.Cells["Pais"].Value?.ToString();
                CB_ZONATUR.Checked = fila.Cells["Zona_TurÍstica"].Value?.ToString().ToLower() == "turística";

                // Rellenar el CheckedListBox
                for (int i = 0; i < LB_SERV.Items.Count; i++)
                {
                    LB_SERV.SetItemChecked(i, false);
                }

                // Obtener el ID del hotel de la fila clickeada
                if (fila.Cells["IDHotel"].Value != DBNull.Value)
                {
                    int idHotelSeleccionado = Convert.ToInt32(fila.Cells["IDHotel"].Value);
                    var con = new Hoteles_DAO();
                    List<string> serviciosDelHotel = con.sp_GetServiciosHotel   (idHotelSeleccionado);

                    if (serviciosDelHotel != null)
                    {
                        foreach (string servicioDB in serviciosDelHotel)
                        {
                            for (int i = 0; i < LB_SERV.Items.Count; i++)
                            {
                                if (LB_SERV.Items[i].ToString().Trim().ToLower() == servicioDB.Trim().ToLower())
                                {
                                    LB_SERV.SetItemChecked(i, true);
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    // Si la fila clickeada tiene un IDHotel nulo, podrías limpiar los controles
                    BTN_CLS_Click(sender, EventArgs.Empty);
                }
            }
        }

    }
}
