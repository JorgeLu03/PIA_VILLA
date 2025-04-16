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
            TB_FECNAC.Text = "";
            TB_NUMNOMINA.Text = "";
            TB_PSW.Text = "";
            TB_TEL.Text = "";
        }
    }
}
