using PIA_VILLA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.MODELOS;

namespace WindowsFormsApp1.PANTALLAS
{
    public partial class USER_MGMT : Form
    {
        public USER_MGMT()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PRINCIPAL principalWdw = new PRINCIPAL();
            principalWdw.ShowDialog();
        }

        private void BTN_CLS_Click(object sender, EventArgs e)
        {
            TB_CORREO.Text = "";
            TB_NAME.Text = "";
            DTP_FECHANAC.Text = "";
            TB_NUMNOMINA.Text = "";
            TB_PSW.Text = "";
            TB_TEL.Text = "";
            TB_PUESTO.Text = "";
        }

        private void USER_MGMT_Load(object sender, EventArgs e)
        {
            var con = new Usuarios_DAO();
            var TabUsers = new DataTable();
            TabUsers = con.sp_GetUsuarios();
            DG_USERS.DataSource = TabUsers; 

            var TabBlock = new DataTable();
            TabBlock = con.sp_GetBlockUsers();
            DG_BLCK.DataSource = TabBlock;


        }

        private void DG_USERS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DG_USERS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DG_USERS.Rows[e.RowIndex];

                TB_NUMNOMINA.Text = fila.Cells["Número_de_Nómina"].Value.ToString();
                TB_NAME.Text = fila.Cells["Nombre_Completo"].Value.ToString();
                TB_CORREO.Text = fila.Cells["Correo"].Value.ToString();
                TB_TEL.Text = fila.Cells["Teléfono"].Value.ToString();
                TB_PUESTO.Text = fila.Cells["Puesto"].Value.ToString();
                TB_PSW.Text = fila.Cells["Contraseña"].Value.ToString();
                if (DateTime.TryParse(fila.Cells["Fecha_de_Nacimiento"].Value.ToString(), out DateTime fecha))
                {
                    DTP_FECHANAC.Value = fecha;
                }

            }
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            var con = new Usuarios_DAO();
            try
            {
                // Validaciones
                string mensajeError;

                // Validar Nombre
                if (!Validaciones.ValidarCampoNoVacio(TB_NAME.Text, out mensajeError) ||
                    !Validaciones.ValidarNombre(TB_NAME.Text, out mensajeError))
                {
                    MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar Correo
                if (!Validaciones.ValidarCampoNoVacio(TB_CORREO.Text, out mensajeError) ||
                    !Validaciones.ValidarCorreo(TB_CORREO.Text, out mensajeError))
                {
                    MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar Teléfono
                if (!Validaciones.ValidarCampoNoVacio(TB_TEL.Text, out mensajeError) ||
                    !Validaciones.ValidarTelefono(TB_TEL.Text, out mensajeError))
                {
                    MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar Contraseña
                if (!Validaciones.ValidarCampoNoVacio(TB_PSW.Text, out mensajeError) ||
                    !Validaciones.ValidarContrasena(TB_PSW.Text, out mensajeError))
                {
                    MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar Número de Nómina
                if (!Validaciones.ValidarCampoNoVacio(TB_NUMNOMINA.Text, out mensajeError) ||
                    !int.TryParse(TB_NUMNOMINA.Text, out int numNomina))
                {
                    MessageBox.Show("El número de nómina debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar Puesto
                if (!Validaciones.ValidarCampoNoVacio(TB_PUESTO.Text, out mensajeError))
                {
                    MessageBox.Show("El campo 'Puesto' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Registro
                char opcion = 'A';
                string nombre = TB_NAME.Text;
                DateTime fechaNac = DTP_FECHANAC.Value;
                string correo = TB_CORREO.Text;
                string puesto = TB_PUESTO.Text;
                string tel = TB_TEL.Text;
                string contrasena = TB_PSW.Text;

                con.sp_GestionEmpleado(opcion, nombre, fechaNac, correo, puesto, numNomina, tel, contrasena);

                MessageBox.Show($"Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TB_CORREO.Text = "";
                TB_NAME.Text = "";
                DTP_FECHANAC.Text = "";
                TB_NUMNOMINA.Text = "";
                TB_PSW.Text = "";
                TB_TEL.Text = "";
                TB_PUESTO.Text = "";
                var TabUsers = new DataTable();
                TabUsers = con.sp_GetUsuarios();
                DG_USERS.DataSource = TabUsers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_ELIM_Click(object sender, EventArgs e)
        {
            var con = new Usuarios_DAO();
            try
            {
                if (DG_USERS.SelectedRows.Count > 0)
                {
                    int numNomina = Convert.ToInt32(DG_USERS.SelectedRows[0].Cells["Número_de_Nómina"].Value);

                    con.sp_GestionEmpleado('E', "", DateTime.Now, "", "", numNomina, "", null);

                    MessageBox.Show($"Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TB_CORREO.Text = "";
                    TB_NAME.Text = "";
                    DTP_FECHANAC.Text = "";
                    TB_NUMNOMINA.Text = "";
                    TB_PSW.Text = "";
                    TB_TEL.Text = "";
                    TB_PUESTO.Text = "";
                    var TabUsers = new DataTable();
                    TabUsers = con.sp_GetUsuarios();
                    DG_USERS.DataSource = TabUsers;
                }
                else
                {
                    MessageBox.Show("Por favor selecciona un usuario para eliminar.","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_MOD_Click(object sender, EventArgs e)
        {
            var con = new Usuarios_DAO();
            try
            {
                // Validaciones
                string mensajeError;

                // Validar Nombre
                if (!Validaciones.ValidarCampoNoVacio(TB_NAME.Text, out mensajeError) ||
                    !Validaciones.ValidarNombre(TB_NAME.Text, out mensajeError))
                {
                    MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar Correo
                if (!Validaciones.ValidarCampoNoVacio(TB_CORREO.Text, out mensajeError) ||
                    !Validaciones.ValidarCorreo(TB_CORREO.Text, out mensajeError))
                {
                    MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar Teléfono
                if (!Validaciones.ValidarCampoNoVacio(TB_TEL.Text, out mensajeError) ||
                    !Validaciones.ValidarTelefono(TB_TEL.Text, out mensajeError))
                {
                    MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar Contraseña
                if (!Validaciones.ValidarCampoNoVacio(TB_PSW.Text, out mensajeError) ||
                    !Validaciones.ValidarContrasena(TB_PSW.Text, out mensajeError))
                {
                    MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar Número de Nómina
                if (!Validaciones.ValidarCampoNoVacio(TB_NUMNOMINA.Text, out mensajeError) ||
                    !int.TryParse(TB_NUMNOMINA.Text, out int numNomina))
                {
                    MessageBox.Show("El número de nómina debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar Puesto
                if (!Validaciones.ValidarCampoNoVacio(TB_PUESTO.Text, out mensajeError))
                {
                    MessageBox.Show("El campo 'Puesto' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Modificación
                char opcion = 'M';
                string nombre = TB_NAME.Text;
                DateTime fechaNac = DTP_FECHANAC.Value;
                string correo = TB_CORREO.Text;
                string puesto = TB_PUESTO.Text;
                string tel = TB_TEL.Text;
                string contrasena = TB_PSW.Text;

                int numNominaVer = Convert.ToInt32(DG_USERS.CurrentRow.Cells["Número_de_Nómina"].Value);

                if (numNomina != numNominaVer)
                {
                    MessageBox.Show("El número de nómina no se puede modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                con.sp_GestionEmpleado(opcion, nombre, fechaNac, correo, puesto, numNomina, tel, contrasena);

                MessageBox.Show($"Usuario modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var TabUsers = new DataTable();
                TabUsers = con.sp_GetUsuarios();
                DG_USERS.DataSource = TabUsers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_DESBLOQUEAR_Click(object sender, EventArgs e)
        {
            var con = new Usuarios_DAO();
            try
            {
                if (DG_BLCK.SelectedCells.Count > 0) // Verifica si hay alguna celda seleccionada
                {
                    // Obtiene el índice de la fila de la primera celda seleccionada.
                    int rowIndex = DG_BLCK.SelectedCells[0].RowIndex;

                    // Obtiene el valor de la celda "Número_de_Nómina" de la fila seleccionada.
                    int numNomina = Convert.ToInt32(DG_BLCK.Rows[rowIndex].Cells["Número_de_Nómina"].Value);

                    con.HabilitarUsuario(numNomina);

                    MessageBox.Show($"Usuario desbloqueado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresca la lista de usuarios bloqueados y activos
                    var TabBlock = con.sp_GetBlockUsers();
                    DG_BLCK.DataSource = TabBlock;

                    var TabUsers = con.sp_GetUsuarios();
                    DG_USERS.DataSource = TabUsers;
                }
                else
                {
                    MessageBox.Show("Selecciona un usuario para desbloquear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al habilitar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
