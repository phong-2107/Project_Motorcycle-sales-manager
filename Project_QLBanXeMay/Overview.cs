using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLBanXeMay
{
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
        }

        SalesHistory salesHistory;
        Home home;
        QLVehicle qLVehicle;
        private static string username;
        public string Username { get => username; set => username = value; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Overview_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            txtusername.Text = username;
        }

        private void borderRadius(object sender, EventArgs e)
        {
          
        }


        private void salesHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesHistory = null;
        }

        private void lbfinancy_Click(object sender, EventArgs e)
        {
            if (salesHistory == null)
            {
                salesHistory = new SalesHistory();
                salesHistory.FormClosed += salesHistory_FormClosed;
                salesHistory.MdiParent = base.MdiParent;
                salesHistory.Dock = DockStyle.Fill;
                salesHistory.Show();
            }
            else
            {
                salesHistory.Activate();
            }
        }

        private void lbMontorcycle_Click(object sender, EventArgs e)
        {
            if (qLVehicle == null)
            {
                qLVehicle = new QLVehicle();
                qLVehicle.FormClosed += Vehicle_FormClosed;
                qLVehicle.MdiParent = base.MdiParent;
                qLVehicle.Dock = DockStyle.Fill;
                qLVehicle.Show();
            }
            else
            {
                qLVehicle.Activate();
            }
        }

        private void Vehicle_FormClosed(object sender, FormClosedEventArgs e)
        {
            qLVehicle.Activate();
        }
    }
}
