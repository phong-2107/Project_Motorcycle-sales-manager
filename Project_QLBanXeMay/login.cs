using Project_QLBanXeMay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_QLBanXeMay
{
    public partial class login : Form
    {
        /*==========  Connection databse ============*/

        public DangNhap Dn { get => dn; set => dn = value; }

        private DangNhap dn = new DangNhap();

        // 
        public login()
        {
            InitializeComponent();
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var context = new Model1();
            List<NhanVien> lg = context.NhanViens.ToList();
            //DangNhap dangNhap = new DangNhap();
            NhanVien nv = new NhanVien();
            int count = 0;
            if (txtAccount.Text != "" && txtPassword.Text != "")
            {
                foreach (var item in lg)
                {
                    if (item.TaiKhoan != null && txtAccount.Text == item.DangNhap.TaiKhoan && txtPassword.Text == item.DangNhap.MatKhau)
                    {
                        nv = item;
                        count = 1;
                    }
                }

                if (count == 1)
                {
                    this.Hide();
                    Overview overview = new Overview();
                    Home home = new Home();
                    home.Dn = nv;
                    home.Closed += (s, args) => this.Close();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Account or password is incorrect", "Sign in", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (txtAccount.Text == "")
                    MessageBox.Show("You haven't filled in your account", "Sign in", MessageBoxButtons.OK);
                else if (txtPassword.Text == "")
                    MessageBox.Show("You haven't filled in your Password", "Sign in", MessageBoxButtons.OK);
                txtAccount.Focus();

            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }

        private void txtAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.Handled = true;
            }
        }
    }
}
