using PIA_VILLA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.PANTALLAS
{
    public partial class CLIENT_MGMT : Form
    {
        public CLIENT_MGMT()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PRINCIPAL principalWdw = new PRINCIPAL();
            principalWdw.ShowDialog();
        }

        private void CLIENT_MGMT_Load(object sender, EventArgs e)
        {
            CB_EDOCIV.Items.Add("Soltero");
            CB_EDOCIV.Items.Add("Casado");
            CB_EDOCIV.Items.Add("Viudo");
            var con = new Clientes_DAO();
            var TabClients = new DataTable();
            TabClients = con.sp_GetClientes();
            DG_CLIENTES.DataSource = TabClients;
        }

        private void DG_CLIENTES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTN_CLS_Click(object sender, EventArgs e)
        {
            TB_CORREO.Text = "";
            TB_NAME.Text = "";
            DTP_FECHANAC.Text = "";
            TB_RFC.Text = "";
            CB_EDOCIV.Text = "";
            TB_TEL.Text = "";
            TB_CEL.Text = "";            
            TB_CD.Text = "";
            TB_ED.Text = "";
            TB_PAIS.Text = "";
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            var con = new Clientes_DAO();
            try
            {
                char opcion = 'A';
                string nombre = TB_NAME.Text;
                DateTime fechaNac = DTP_FECHANAC.Value;
                string correo = TB_CORREO.Text;
                string edociv = CB_EDOCIV.Text;
                string rfc = TB_RFC.Text;
                string tel = TB_TEL.Text;
                string cel = TB_CEL.Text;
                string ciudad = TB_CD.Text;
                string estado = TB_ED.Text;
                string pais = TB_PAIS.Text;

                con.sp_GestionCliente(opcion, nombre, fechaNac, correo, edociv, rfc, tel, cel,ciudad,estado,pais);

                MessageBox.Show("Cliente registrado exitosamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var TabClients = new DataTable();
                TabClients = con.sp_GetClientes();
                DG_CLIENTES.DataSource = TabClients;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DG_CLIENTES_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DG_CLIENTES.Rows[e.RowIndex];

                TB_RFC.Text = fila.Cells["RFC"].Value.ToString();
                TB_NAME.Text = fila.Cells["Nombre"].Value.ToString();
                TB_CORREO.Text = fila.Cells["Correo"].Value.ToString();
                TB_TEL.Text = fila.Cells["Telefono"].Value.ToString();
                TB_CEL.Text = fila.Cells["Celular"].Value.ToString();
                CB_EDOCIV.Text = fila.Cells["Estado_Civil"].Value.ToString();
                TB_CD.Text = fila.Cells["Ciudad"].Value.ToString();
                TB_ED.Text = fila.Cells["Estado"].Value.ToString();
                TB_PAIS.Text = fila.Cells["Pais"].Value.ToString();
                if (DateTime.TryParse(fila.Cells["Fecha_de_Nacimiento"].Value.ToString(), out DateTime fecha))
                {
                    DTP_FECHANAC.Value = fecha;
                }

            }
        }

        private void BTN_DEL_Click(object sender, EventArgs e)
        {
            var con = new Clientes_DAO();
            try
            {
                if (DG_CLIENTES.SelectedRows.Count > 0)
                {
                    var confirm = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        string rfc = (string)DG_CLIENTES.SelectedRows[0].Cells["RFC"].Value;
                        con.sp_GestionCliente('E', "", DateTime.Now, "", "", rfc, "", "", "", "", "");
                        MessageBox.Show("Usuario eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var TabClients = new DataTable();
                        TabClients = con.sp_GetClientes();
                        DG_CLIENTES.DataSource = TabClients;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor selecciona un usuario para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_MOD_Click(object sender, EventArgs e)
        {
            var con = new Clientes_DAO();
            try
            {
                char opcion = 'M';
                string nombre = TB_NAME.Text;
                DateTime fechaNac = DTP_FECHANAC.Value;
                string correo = TB_CORREO.Text;
                string edociv = CB_EDOCIV.Text;
                string rfc = TB_RFC.Text;
                string tel = TB_TEL.Text;
                string cel = TB_CEL.Text;
                string ciudad = TB_CD.Text;
                string estado = TB_ED.Text;
                string pais = TB_PAIS.Text;

                con.sp_GestionCliente(opcion, nombre, fechaNac, correo, edociv, rfc, tel, cel, ciudad, estado, pais);

                string rfcVer = DG_CLIENTES.CurrentRow.Cells["RFC"].Value.ToString();

                if (rfc != rfcVer)
                {
                    MessageBox.Show("El RFC no se puede modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Cliente modificado exitosamente.", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var TabClients = new DataTable();
                TabClients = con.sp_GetClientes();
                DG_CLIENTES.DataSource = TabClients;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
    }
