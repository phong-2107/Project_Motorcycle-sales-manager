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
    public partial class QLKhachHang : Form
    {
        public QLKhachHang()
        {
            InitializeComponent();
        }

        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        bool AddCustomerExpand = false;
        private void AddCustomerTransition_Tick(object sender, EventArgs e)
        {
            if (AddCustomerExpand == false)
            {
                pnAddCustomer.Width += 10;
                if (pnAddCustomer.Width >= 477)
                {
                    AddCustomerExpand = true;
                    AddCustomerTransition.Stop();
                }
            }
            else
            {
                pnAddCustomer.Width -= 10;
                if (pnAddCustomer.Width <= 0)
                {
                    AddCustomerExpand = false;
                    AddCustomerTransition.Stop();
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerTransition.Start();
        }

    }
}
