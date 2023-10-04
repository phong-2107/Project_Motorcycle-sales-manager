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
    public partial class SalesHistory : Form
    {
        public SalesHistory()
        {
            InitializeComponent();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            SearchByDate.Visible = true;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            SearchByDate.Visible = false;
        }


        private void btnYesterday_Click(object sender, EventArgs e)
        {
            SearchByDate.Visible = false;
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            searchLabel.Visible = false;
        }
    }
}
