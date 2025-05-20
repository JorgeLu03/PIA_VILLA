    using PIA_VILLA;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.InteropServices.ComTypes;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using WindowsFormsApp1.MODELOS;

    namespace WindowsFormsApp1.PANTALLAS
    {
        public partial class TIPOHAB_MGMT : Form
        {
            public TIPOHAB_MGMT()
            {
                InitializeComponent();
            }

            private void button4_Click(object sender, EventArgs e)
            {
                this.Hide();
                PRINCIPAL principalWdw = new PRINCIPAL();
                principalWdw.ShowDialog();
            }

        private void TIPOHAB_MGMT_Load(object sender, EventArgs e)
        {
            var CLBCHECK = new TiposDeHabitacion_DAO();
            CLBCHECK.CargarCLBAmenidades(CLB_AMENIDADES);

            CB_TIPOCAMAS.Items.Add("Individual");
            CB_TIPOCAMAS.Items.Add("Doble");
            CB_TIPOCAMAS.Items.Add("Queen");
            CB_TIPOCAMAS.Items.Add("King");

            CargarHotelesEnComboBox();
            CB_HOTEL.Text = "";

            TB_COSTO.Text = "$";
            TB_COSTO.ForeColor = Color.Gray;

            TB_COSTO.GotFocus += (s, ev) =>
            {
                if (TB_COSTO.Text == "$")
                {
                    TB_COSTO.Text = "";
                    TB_COSTO.ForeColor = Color.Black;
                }
            };

            TB_COSTO.LostFocus += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(TB_COSTO.Text))
                {
                    TB_COSTO.Text = "$";
                    TB_COSTO.ForeColor = Color.Gray;
                }
            };
        }

        private void CargarHotelesEnComboBox()
            {
                try
                {
                    CB_HOTEL.Items.Clear();

                    Hoteles_DAO llenarHoteles = new Hoteles_DAO();
                    DataTable tablaHoteles = llenarHoteles.sp_GetHoteles();

                    if (tablaHoteles != null && tablaHoteles.Rows.Count > 0)
                    {
                        // Establece el DataSource del ComboBox
                        CB_HOTEL.DataSource = tablaHoteles;

                        // Indica qué columna se mostrará al usuario
                        CB_HOTEL.DisplayMember = "Nombre";

                        // Indica qué columna contendrá el valor real (el IDHotel)
                        CB_HOTEL.ValueMember = "IDHotel";

                        // Opcional: Seleccionar el primer ítem
                        if (CB_HOTEL.Items.Count > 0)
                            CB_HOTEL.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron hoteles registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar hoteles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            private void button5_Click(object sender, EventArgs e)
            {
                TB_CAR.Text = "";
                TB_COSTO.Text = "";
                NUD_CANTHAB.Value = 0;
                NUD_CAPACIDAD.Value = 0;
                NUD_NUMCAMAS.Value = 0;
                TB_NIVEL.Text = "";
                CB_HOTEL.Text = "";
                CB_TIPOCAMAS.Text = "";
                DG_CAR.DataSource = null;
                DG_TIPOHAB.DataSource=null;

                for (int i = 0; i < CLB_AMENIDADES.Items.Count; i++) CLB_AMENIDADES.SetItemChecked(i, false);
            }

            private void CB_HOTEL_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (CB_HOTEL.SelectedItem != null)
                {
                    if (CB_HOTEL.SelectedValue != null && int.TryParse(CB_HOTEL.SelectedValue.ToString(), out int idHotelSeleccionado))
                    {
                        var tipoHabGrid = new TiposDeHabitacion_DAO();
                        DataTable tiposHabitacion = tipoHabGrid.sp_GetTiposHabPorHotel(idHotelSeleccionado,1);

                        DG_TIPOHAB.DataSource = tiposHabitacion;
                    FormatearColumnaCosto();

                }
                }
                DG_CAR.DataSource = null;
            }

            private void DG_TIPOHAB_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            
            }

            private void DG_TIPOHAB_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow filaTH = DG_TIPOHAB.Rows[e.RowIndex];
                    DataGridViewRow fila = DG_TIPOHAB.Rows[e.RowIndex];
                    var cellValue = DG_TIPOHAB.Rows[e.RowIndex].Cells["IDHotel"].Value;
                    var idTipoHabValue = fila.Cells["IDTipoHab"].Value;
                    int idTipoHab = 0;
                    if (idTipoHabValue != null && idTipoHabValue != DBNull.Value)
                    {
                         idTipoHab = Convert.ToInt32(idTipoHabValue);
                    }


                    if (cellValue != DBNull.Value && cellValue != null)
                    {
                        TB_NIVEL.Text = fila.Cells["Nivel"].Value?.ToString() ?? "";
                        NUD_CAPACIDAD.Value = Convert.ToDecimal(fila.Cells["Capacidad"].Value);
                        NUD_NUMCAMAS.Value = Convert.ToDecimal(fila.Cells["Número_de_camas"].Value);
                        CB_TIPOCAMAS.Text = fila.Cells["Tipo_de_camas"].Value?.ToString();
                        TB_COSTO.Text = fila.Cells["Costo"].Value?.ToString() ?? "";
                        NUD_CANTHAB.Value = Convert.ToDecimal(fila.Cells["Cantidad_de_Habitaciones"].Value);

                        int idHotelSeleccionado = Convert.ToInt32(cellValue);
                        var CarGrid = new TiposDeHabitacion_DAO();
                        DataTable Car = CarGrid.sp_GetTiposHabPorHotel(idHotelSeleccionado, 2);
                        DG_CAR.DataSource = Car;

                            //CONCAT
                            List<string> listaCaracteristicas = new List<string>();
                            if (DG_CAR.Rows.Count > 0 && DG_CAR.Columns.Contains("Característica"))
                            {
                                foreach (DataGridViewRow row in DG_CAR.Rows)
                                {
                                    if (row.Cells["Característica"].Value != null && row.Cells["Característica"].Value != DBNull.Value)
                                    {
                                        listaCaracteristicas.Add(row.Cells["Característica"].Value.ToString().Trim());
                                    }
                                }
                                TB_CAR.Text = string.Join(", ", listaCaracteristicas);
                            }
                            else
                            {
                                TB_CAR.Text = "";
                            }
                        //

                        // Limpiar selecciones
                        for (int i = 0; i < CLB_AMENIDADES.Items.Count; i++)
                        {
                            CLB_AMENIDADES.SetItemChecked(i, false);
                        }

                        var amenHab = new TiposDeHabitacion_DAO();
                        List<int> amenidadesIDs = amenHab.ObtenerAmenidadesIDsPorTipoHab(idTipoHab);

                        // Marcar los items correspondientes
                        for (int i = 0; i < CLB_AMENIDADES.Items.Count; i++)
                        {
                            Amenidades amenidad = CLB_AMENIDADES.Items[i] as Amenidades;
                            if (amenidad != null && amenidadesIDs.Contains(amenidad.IDAmenidad))
                            {
                                CLB_AMENIDADES.SetItemChecked(i, true);
                            }
                        }


                        // Cargar características
                        var dao = new TiposDeHabitacion_DAO();
                        DataTable dtCaracteristicas = dao.ObtenerCaracteristicasPorTipoHab(idTipoHab);

                        List<string> caracteristicas = new List<string>();
                        foreach (DataRow row in dtCaracteristicas.Rows)
                        {
                            caracteristicas.Add(row["CaracterÍstica"].ToString());
                        }
                        TB_CAR.Text = string.Join(", ", caracteristicas);


                    }
                    else
                    {
                        TB_NIVEL.Text = "";
                        NUD_CAPACIDAD.Value = 0;
                        NUD_NUMCAMAS.Value = 0;
                        CB_TIPOCAMAS.Text = "";
                        TB_COSTO.Text = "";
                        TB_CAR.Text = "";
                        NUD_CANTHAB.Value = 0;
                        for (int i = 0; i < CLB_AMENIDADES.Items.Count; i++)
                        {
                            CLB_AMENIDADES.SetItemChecked(i, false);
                        }
                    }
                    if (cellValue != DBNull.Value && cellValue != null)
                    {
                        int idHotelSeleccionado = Convert.ToInt32(cellValue);
                        var CarGrid = new TiposDeHabitacion_DAO();
                        DataTable Car = CarGrid.sp_GetTiposHabPorHotel(idHotelSeleccionado, 2, idTipoHab);
                        DG_CAR.DataSource = Car;

                    }
                    else
                    {
                        DG_CAR.DataSource = null;
                    }
                }
            }

            private void BTN_ADD_Click(object sender, EventArgs e)
            {
                if (CB_HOTEL.SelectedValue == null || !int.TryParse(CB_HOTEL.SelectedValue.ToString(), out int idHotel))
                {
                    MessageBox.Show("Por favor, selecciona un hotel.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nivel = TB_NIVEL.Text.Trim();
                int capacidad = (int)NUD_CAPACIDAD.Value;
                int numCamas = (int)NUD_NUMCAMAS.Value;
                string tipoCamas = CB_TIPOCAMAS.Text.Trim();
                if (!decimal.TryParse(TB_COSTO.Text, out decimal costo))
                {
                    MessageBox.Show("Por favor, introduce un costo válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int cantidadHabitaciones = (int)NUD_CANTHAB.Value;


                List<int> idsAmenidades = new List<int>();
                foreach (var item in CLB_AMENIDADES.CheckedItems)
                {
                    Amenidades amenidad = item as Amenidades;
                    if (amenidad != null)
                    {
                        idsAmenidades.Add(amenidad.IDAmenidad);
                    }
                }
                string cadenaAmenidades = string.Join(",", idsAmenidades);

                //Características
                List<string> caracteristicas = TB_CAR.Text
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(c => c.Trim())
                    .Where(c => !string.IsNullOrWhiteSpace(c))
                    .ToList();

                string cadenaCaracteristicas = string.Join(",", caracteristicas);



                var tipoHabDAO = new TiposDeHabitacion_DAO();
                tipoHabDAO.GestionTipoHabitacion('A', null, idHotel, capacidad, nivel, numCamas, tipoCamas, costo, cantidadHabitaciones, cadenaAmenidades,cadenaCaracteristicas );
                // Actualizar
                if (CB_HOTEL.SelectedValue != null && int.TryParse(CB_HOTEL.SelectedValue.ToString(), out int currentHotelId))
                {
                    var tipoHabGrid = new TiposDeHabitacion_DAO();
                    DG_TIPOHAB.DataSource = tipoHabGrid.sp_GetTiposHabPorHotel(currentHotelId, 1);
                    var CarGrid = new TiposDeHabitacion_DAO();
                    DataTable Car = CarGrid.sp_GetTiposHabPorHotel(currentHotelId, 2);
                    DG_CAR.DataSource = Car;

                    //CONCAT
                    List<string> listaCaracteristicas = new List<string>();
                    if (DG_CAR.Rows.Count > 0 && DG_CAR.Columns.Contains("Característica"))
                    {
                        foreach (DataGridViewRow row in DG_CAR.Rows)
                        {
                            if (row.Cells["Característica"].Value != null && row.Cells["Característica"].Value != DBNull.Value)
                            {
                                listaCaracteristicas.Add(row.Cells["Característica"].Value.ToString().Trim());
                            }
                        }
                        TB_CAR.Text = string.Join(", ", listaCaracteristicas);
                    }
                    else
                    {
                        TB_CAR.Text = "";
                    }
                }
            }

            private void BTN_DEL_Click(object sender, EventArgs e)
            {
                var con = new TiposDeHabitacion_DAO();
                if (DG_TIPOHAB.SelectedRows.Count > 0)
                {
                    DialogResult confirm = MessageBox.Show("¿Estás seguro de que deseas eliminar este tipo de habitación?",
                                                           "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        int idTipoHab = Convert.ToInt32(DG_TIPOHAB.SelectedRows[0].Cells["IDTipoHab"].Value);

                        // Eliminar el tipo de habitación
                        TiposDeHabitacion_DAO dao = new TiposDeHabitacion_DAO();
                        dao.GestionTipoHabitacion('E', idTipoHab, null, null, null, null, null, null, null, null, null);

                        // Actualizar DG_TIPOHAB y DG_CAR
                        if (CB_HOTEL.SelectedValue != null && int.TryParse(CB_HOTEL.SelectedValue.ToString(), out int idHotelSeleccionado))
                        {
                            // Recargar tipos de habitación
                            var tipoHabGrid = new TiposDeHabitacion_DAO();
                            DataTable tiposHabitacion = tipoHabGrid.sp_GetTiposHabPorHotel(idHotelSeleccionado, 1);
                            DG_TIPOHAB.DataSource = tiposHabitacion;
                        FormatearColumnaCosto();

                        // Recargar características
                        DataTable caracteristicas = tipoHabGrid.sp_GetTiposHabPorHotel(idHotelSeleccionado, 2);
                            DG_CAR.DataSource = caracteristicas;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un tipo de habitación para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        private void BTN_MOD_Click(object sender, EventArgs e)
        {
            if (DG_TIPOHAB.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un tipo de habitación para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener IDTipoHab seleccionado
            int idTipoHab = Convert.ToInt32(DG_TIPOHAB.SelectedRows[0].Cells["IDTipoHab"].Value);

            // Validar hotel
            if (CB_HOTEL.SelectedValue == null || !int.TryParse(CB_HOTEL.SelectedValue.ToString(), out int idHotel))
            {
                MessageBox.Show("Selecciona un hotel válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener datos del formulario
            string nivel = TB_NIVEL.Text.Trim();
            int capacidad = (int)NUD_CAPACIDAD.Value;
            int numCamas = (int)NUD_NUMCAMAS.Value;
            string tipoCamas = CB_TIPOCAMAS.Text.Trim();

            if (!decimal.TryParse(TB_COSTO.Text, out decimal costo))
            {
                MessageBox.Show("Costo inválido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Amenidades
            List<int> idsAmenidades = new List<int>();
            foreach (var item in CLB_AMENIDADES.CheckedItems)
            {
                if (item is Amenidades amenidad)
                {
                    idsAmenidades.Add(amenidad.IDAmenidad);
                }
            }
            string cadenaAmenidades = string.Join(",", idsAmenidades);

            // Características
            List<string> caracteristicas = TB_CAR.Text
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(c => c.Trim())
                .Where(c => !string.IsNullOrWhiteSpace(c))
                .ToList();
            string cadenaCaracteristicas = string.Join(",", caracteristicas);

            // Llamar a DAO
            TiposDeHabitacion_DAO dao = new TiposDeHabitacion_DAO();
            dao.GestionTipoHabitacion('M', idTipoHab, idHotel, capacidad, nivel, numCamas, tipoCamas, costo, null, cadenaAmenidades, cadenaCaracteristicas);

            // Refrescar grids
            DataTable tipos = dao.sp_GetTiposHabPorHotel(idHotel, 1);
            DG_TIPOHAB.DataSource = tipos;

            DataTable cars = dao.sp_GetTiposHabPorHotel(idHotel, 2, idTipoHab);
            DG_CAR.DataSource = cars;

        }

        private void FormatearColumnaCosto()
        {
            if (DG_TIPOHAB.Columns.Contains("Costo"))
            {
                DG_TIPOHAB.Columns["Costo"].DefaultCellStyle.Format = "C2";
                DG_TIPOHAB.Columns["Costo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            DG_TIPOHAB.Columns["IDHotel"].Visible = false;
            DG_TIPOHAB.Columns["IDTipoHab"].Visible = false;


        }


    }
}
