using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLBanXeMay
{
    public partial class Home : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipe
        );

        Home home;
        Overview overview;
        FormAbout about;
        FormHelp help;
        FormSetting setting;
        QLKhachHang qLKhachHang;
        QLNhanVien qLNhanVien;
        QLVehicle qLVehicle;
        login login;

        public Home()
        {
            InitializeComponent();
            mdiProp();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, Width, Height, 15, 15));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (overview == null)
            {
                overview = new Overview();
                overview.FormClosed += Overview_FormClosed;
                overview.MdiParent = this;
                //overview.Dock = DockStyle.Fill;
                overview.Show();
            }
            else
            {
                overview.Activate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        bool menuExpand = false;
        bool reportExpand = false;

        private void mdiProp()
        {
            this.SetBevel(false);
            //Controls.OfType<MdiClient>()
                    //.FirstOrDefault().BackColor = Color.FromArgb(243, 247, 255);
        }
        private void MenuTransition_Tick(object sender, EventArgs e)
        {
            if(menuExpand == false)
            {
                MenuContainer.Height += 10;
                if(MenuContainer.Height >= 197)
                {
                    MenuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                MenuContainer.Height -= 10;
                if(MenuContainer.Height <= 49)
                {
                    MenuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            MenuTransition.Start();
        }
        bool sidebarExpand = true;

        private void ReportTransition_Tick(object sender, EventArgs e)
        {
            if (reportExpand == false)
            {
                ReportContainer.Height += 10;
                if (ReportContainer.Height >= 197)
                {
                    ReportTransition.Stop();
                    reportExpand = true;
                }
            }
            else
            {
                ReportContainer.Height -= 10;
                if (ReportContainer.Height <= 49)
                {
                    ReportTransition.Stop();
                    reportExpand = false;
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportTransition.Start();
        }

        private void SidebarTransistion_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                Sidebar.Width -= 10;
                if(Sidebar.Width <= 70)
                {
                    sidebarExpand = false;
                    SidebarTransistion.Stop();
                    btnHome.Width = Sidebar.Width;
                    btnAbout.Width = Sidebar.Width;
                    btnHelp.Width = Sidebar.Width;
                    btnSettings.Width = Sidebar.Width;
                    MenuContainer.Width = Sidebar.Width;
                    ReportContainer.Width = Sidebar.Width;
                }
            }
            else
            {
                Sidebar.Width += 10;
                if(Sidebar.Width >= 216)
                {
                    sidebarExpand = true;
                    SidebarTransistion.Stop();

                    btnHome.Width = Sidebar.Width;
                    btnAbout.Width = Sidebar.Width;
                    btnHelp.Width = Sidebar.Width;
                    btnSettings.Width = Sidebar.Width;
                    MenuContainer.Width = Sidebar.Width;
                    ReportContainer.Width = Sidebar.Width;
                }
            }
        }


        // ================ Ham =================
        private void btnHam_Click(object sender, EventArgs e)
        {
            SidebarTransistion.Start();
        }


        //================ 1. Home Event CLick =================
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (overview == null)
            {
                overview = new Overview();
                overview.FormClosed += Overview_FormClosed;
                overview.Show();
            }
            else
            {
                overview.Activate();
            }
        }
        private void Overview_FormClosed(object sender, FormClosedEventArgs e)
        {
            overview = null;
        }


        //================ 2. Management Event CLick =================
        //========= 2.1 Staff Event CLick ===========
        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (qLNhanVien == null)
            {
                qLNhanVien = new QLNhanVien();
                qLNhanVien.FormClosed += Staff_FormClosed;
                qLNhanVien.MdiParent = this;
                qLNhanVien.Dock = DockStyle.Fill;
                qLNhanVien.Show();
            }
            else
            {
                qLNhanVien.Activate();
            }
        }
        private void Staff_FormClosed(object sender, FormClosedEventArgs e)
        {
            qLNhanVien = null;
        }


        //========= 2.2 Customer Event CLick ===========
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (qLKhachHang == null)
            {
                qLKhachHang = new QLKhachHang();
                qLKhachHang.FormClosed += Customer_FormClosed;
                qLKhachHang.MdiParent = this;
                qLKhachHang.Dock = DockStyle.Fill;
                qLKhachHang.Show();
            }
            else
            {
                qLKhachHang.Activate();
            }
        }
        private void Customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            qLKhachHang = null;
        }

        //========= 2.3 Vehicle Event CLick ===========
        private void btnVehicle_Click(object sender, EventArgs e)
        {
            if (qLVehicle == null)
            {
                qLVehicle = new QLVehicle();
                qLVehicle.FormClosed += Vehicle_FormClosed;
                qLVehicle.MdiParent = this;
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


        //================ 3. About Event CLick =================
        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (about == null)
            {
                about = new FormAbout();
                about.FormClosed += About_FormClosed;
                about.MdiParent = this;
                about.Dock = DockStyle.Fill;
                about.Show();
            }
            else
            {
                about.Activate();
            }
        }
        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            about = null;
        }



        //================ 4. Help Event CLick =================
        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (help == null)
            {
                help = new FormHelp();
                help.FormClosed += Help_FormClosed;
                help.MdiParent = this;
                help.Dock = DockStyle.Fill;
                help.Show();
            }
            else
            {
                help.Activate();
            }
        }
        private void Help_FormClosed(object sender, FormClosedEventArgs e)
        {
            help = null;
        }


        //================ 5. Settings Event CLick =================
        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (setting == null)
            {
                setting = new FormSetting();
                setting.FormClosed += Setting_FormClosed;
                setting.MdiParent = this;
                setting.Dock = DockStyle.Fill;
                setting.Show();
            }
            else
            {
                setting.Activate();
            }
        }
        private void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            setting = null;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            login = new login();
            login.FormClosed += login_FormClosed;
            login.Dock = DockStyle.Fill;
            login.Show();
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            login = null;   
        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
