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
using WindowsFormsApp1.PANTALLAS;

namespace PIA_VILLA
{
    public partial class LOGIN : Form
    {
        private int intentosFallidos = 0;
        public LOGIN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = new EnlaceDB();
            Usuarios login = new Usuarios();
            Contrasenas loginPSW = new Contrasenas();

            if (int.TryParse(TB_USER.Text, out int numNomina))
            {
                login.NumNómina = numNomina;
            }
            else
            {

            }

            login.NumNómina = int.Parse(TB_USER.Text);
            loginPSW.Contraseña = TB_PSW.Text;

            Usuarios_DAO usuarioDAO = new Usuarios_DAO();
            DataTable inicses = usuarioDAO.sp_LoginUsuario(login.NumNómina.ToString(), loginPSW.Contraseña);

            if (inicses.Rows.Count > 0)
            {
                DataRow row = inicses.Rows[0];

                // 🔹 Verificar si el usuario está bloqueado
                if (!(bool)row["Estatus"])
                {
                    MessageBox.Show("Usuario bloqueado. Contacta a soporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                intentosFallidos = 0;
                SESIÓN.NumNómina = Convert.ToInt32(row["NumNómina"]);
                SESIÓN.Tipo = row["Tipo"].ToString()[0];
                SESIÓN.NombreUsuario = row["NombreUsuario"].ToString();

                this.Hide();
                var PRINCIPAL = new PRINCIPAL();
                PRINCIPAL.Show();
            }
            else
            {
                intentosFallidos++;
                //MessageBox.Show("Usuario o contraseña incorrectos. Por favor, intenta de nuevo.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void TB_BYE_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
