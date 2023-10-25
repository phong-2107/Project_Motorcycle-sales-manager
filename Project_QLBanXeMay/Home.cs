using Project_QLBanXeMay.Models;
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
        
        /* Custom border radius for form home *//*
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipe
        );
        */
        /* Create a child form for form home */
        Home home;
        Overview overview;
        FormAbout about;
        FormContact help;
        FormSetting setting;
        QLKhachHang qLKhachHang;
        QLNhanVien qLNhanVien;
        QLVehicle qLVehicle;
        SalesHistory salesHistory;
        ImportHistory importHistory;
        login login;

        /*  initialize variables */
        bool menuExpand = false;
        bool reportExpand = false;


        private NhanVien dn = new NhanVien();
        public NhanVien Dn { get => dn; set => dn = value; }

        private Panel botttomBorder;
        private Panel leftBorder;

        

        /* ============ Source code MAIN ==============*/

        public Home()
        {
            InitializeComponent();
            mdiProp();
            StartPosition = FormStartPosition.Manual;
            Rectangle screen = Screen.FromPoint(Cursor.Position).WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            Location = new Point(screen.Left + (screen.Width - w) / 2, screen.Top + (screen.Height - h) / 2);
            Size = new Size(w, h);
            this.Text = string.Empty;
            this.DoubleBuffered = true;
            this.Location = new Point(0, 0);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            botttomBorder = new Panel();
            botttomBorder.Size = new Size(120, 7);
            pnBar.Controls.Add(botttomBorder);
            botttomBorder.BackColor = System.Drawing.Color.FromArgb(72, 60, 255);
            botttomBorder.Location = new Point(btnCreaateInvoice.Location.X, 40);
;
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            btnCreateAccount.Text = Dn.DangNhap.TaiKhoan;
            
            if (overview == null)
            {
                overview = new Overview();
                overview.FormClosed += Overview_FormClosed;
                overview.MdiParent = this;
                //overview.Dock = DockStyle.Fill;
                overview.Dn = Dn;
                overview.Show();

               

            }
            else
            {
                overview.Activate();
            }
        }

        private void mdiProp()
        {
            this.SetBevel(false);
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
                if (ReportContainer.Height >= 147)
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

        private void siderTransistion_Tick(object sender, EventArgs e)
        {
            

            if (sidebarExpand)
            {
                
                sider.Width -= 15;
                if ( sider.Width <= 70)
                {
                    sidebarExpand = false;
                    SidebarTransistion.Stop();
                    btnHome.Width = sider.Width;
                    btnAbout.Width = sider.Width;
                    btnHelp.Width = sider.Width;
                    btnSettings.Width = sider.Width;
                    MenuContainer.Width = sider.Width;
                    ReportContainer.Width = sider.Width;
                }
            }
            else
            {
                sider.Width += 15;
                if ( sider.Width >= 216)
                {
                    sidebarExpand = true;
                    SidebarTransistion.Stop();

                    btnHome.Width = sider.Width;
                    btnAbout.Width = sider.Width;
                    btnHelp.Width = sider.Width;
                    btnSettings.Width = sider.Width;
                    MenuContainer.Width = sider.Width;
                    ReportContainer.Width = sider.Width;
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
                overview.Refresh();
                overview.Show();
                
            }
            else
            {
                overview.Refresh();
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
                qLNhanVien.Refresh();
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
                qLKhachHang.Refresh();
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
                qLVehicle.Refresh();
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


        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            if (salesHistory == null)
            {
                salesHistory = new SalesHistory();
                salesHistory.FormClosed += salesHistory_FormClosed;
                salesHistory.MdiParent = this;
                salesHistory.Dock = DockStyle.Fill;
                salesHistory.Refresh();
                salesHistory.Show();
            }
            else
            {
                salesHistory.Activate();
            }
        }
        private void salesHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            salesHistory = null;
        }


        private void btnImportReport_Click(object sender, EventArgs e)
        {
            if (importHistory == null)
            {
                importHistory = new ImportHistory();
                importHistory.FormClosed += ImportHistory_FormClosed;
                importHistory.MdiParent = this;
                importHistory.Dock = DockStyle.Fill;
                importHistory.Refresh();
                importHistory.Show();
            }
            else
            {
                importHistory.Activate();
            }
        }
        private void ImportHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            importHistory = null;
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
                help = new FormContact();
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
                setting.Dn = Dn;
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


        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure Logout ? ", "LOG OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                
                login lg = new login();
                lg.Show();
                lg.FormClosing += FrmClosing;
                Hide();
            }
        }

        private void FrmClosing(object sender, FormClosingEventArgs e)
        {
            Show();
        }


        private void btnCreaateInvoice_Click(object sender, EventArgs e)
        {
            botttomBorder.BackColor = System.Drawing.Color.FromArgb(72, 60, 255);
            botttomBorder.Location = new Point(btnCreaateInvoice.Location.X, 40);
            home.Opacity = 80;
            HoaDon hd = new HoaDon();
            hd.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            botttomBorder.BackColor = System.Drawing.Color.FromArgb(72, 60, 255);
            botttomBorder.Location = new Point(button1.Location.X, 40);
        }
    }
}
