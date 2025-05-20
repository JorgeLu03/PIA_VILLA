using PIA_VILLA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.MODELOS;
using static System.Collections.Specialized.BitVector32;

namespace WindowsFormsApp1.PANTALLAS
{

    public partial class PRINCIPAL : Form
    {
        public PRINCIPAL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            USER_MGMT userMGMTWdw = new USER_MGMT();
            userMGMTWdw.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOTEL_MGMT hotelMGMTWdw = new HOTEL_MGMT();
            hotelMGMTWdw.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TIPOHAB_MGMT habMGMTWdw = new TIPOHAB_MGMT();
            habMGMTWdw.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CANCELACIONES cancelWdw = new CANCELACIONES();
            cancelWdw.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            REPORTE_OCUP reporteWdw = new REPORTE_OCUP();
            reporteWdw.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN loginWdw = new LOGIN();
            loginWdw.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            CLIENT_MGMT clientMGMTWdw = new CLIENT_MGMT();
            clientMGMTWdw.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            RESERVACIONES rsvWdw = new RESERVACIONES();
            rsvWdw.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            CHECK_IN checkinWdw = new CHECK_IN();
            checkinWdw.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            CHECK_OUT checkoutWdw = new CHECK_OUT();
            checkoutWdw.ShowDialog();
        }

        private void PRINCIPAL_Load(object sender, EventArgs e)
        {
            if (SESIÓN.Tipo == 'O')
            {
                label10.Text = "Bienvenido " + Environment.NewLine + SESIÓN.NombreUsuario;
                label10.Visible = true;
                LB_TX.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                labelIN.Visible = false;
                BTN_USERMGMT.Visible = false;
                BTN_HOTELMGMT.Visible = false;
                BTN_HABMGMT.Visible = false;
                BTN_CAN.Visible = false;
                BTN_REP.Visible = false;
                button1.Visible = false;
                BTN_HISTCLIEN.Visible = false;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            REPORTE_VENTAS checkinWdw = new REPORTE_VENTAS();
            checkinWdw.ShowDialog();
        }

        private void BTN_HISTCLIEN_Click(object sender, EventArgs e)
        {
            this.Hide();
            HISTORIAL_CLIENTE checkinWdw = new HISTORIAL_CLIENTE();
            checkinWdw.ShowDialog();
        }
    }
}
