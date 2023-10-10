using Project_QLBanXeMay.models;
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
        private static string fullname;
        public static int quyen;
        private static string username;

        public  string Username { get => username; set => username = value; }
        public  string Fullname { get => fullname; set => fullname = value; }


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
            List <DangNhap> lg = context.DangNhaps.ToList();
            int tmp = 0;
            if (txtAccount.Text != "" && txtPassword.Text != "")
            {
                foreach(var item in lg)
                {
                    if(txtAccount.Text == item.TaiKhoan && txtPassword.Text == item.MatKhau)
                    {
                        tmp = 1;
                    }
                }

                if(tmp == 1)
                {
                    
                    this.Hide();
                    Overview overview = new Overview();
                    Home home = new Home();
                    home.Username = txtAccount.Text;
                    home.Password = txtPassword.Text;
                    overview.Username = txtAccount.Text;
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
                if(txtAccount.Text == "")
                    MessageBox.Show("You haven't filled in your account", "Sign in", MessageBoxButtons.OK);
                else if (txtPassword.Text == "")
                    MessageBox.Show("You haven't filled in your Password", "Sign in", MessageBoxButtons.OK);
                txtAccount.Focus();

            }



        }
    }
}
