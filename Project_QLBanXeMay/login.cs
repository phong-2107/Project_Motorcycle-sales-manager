using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_QLBanXeMay
{
    public partial class login : Form
    {

        /*==========  Connection databse ============*/
        //private static QLXMEntities db = new QLXMEntities();
        public static string username, fullname;
        public static int quyen;


        // 
        public login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            if (txtAccount.Text != "" && txtPassword.Text != "")
            {
                /*
                var user = db.DangNhaps.Select(s => s).Where(s => s.TaiKhoan.Equals(txtTaiKhoan.Text) && s.MatKhau.Equals(txtMatKhau.Text)).FirstOrDefault();
                if (user != null)
                {
                    username = txtTaiKhoan.Text;
                    fullname = user.TenDayDu;
                    quyen = int.Parse(user.Quyen + "");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                    txtTaiKhoan.Focus();
                }
                */

                this.Hide();
                Home home = new Home();
                home.Closed += (s, args) => this.Close();
                home.Show();
                
            }
            else
            {
                if(txtAccount.Text == "")
                    MessageBox.Show("You haven't filled in your account", "Sign in", MessageBoxButtons.OK);
                else if (txtPassword.Text == "")
                    MessageBox.Show("You haven't filled in your Password", "Sign in", MessageBoxButtons.OK);
                txtAccount.Focus();

            }



        }
    }
}
