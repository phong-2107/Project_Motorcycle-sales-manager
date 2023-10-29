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
        HoaDon hoadon;
        TableColor color;
        TableNCC company;
        FormAccount account;
        FormCustomerDeleted customerDeleted;
        FormMotorDeleted motorDeleted;
        FormAddMotor AddMotor;
        /*  initialize variables */
        bool menuExpand = false;
        bool reportExpand = false;
        bool settingExpand = false;

        private NhanVien dn = new NhanVien();
        public NhanVien Dn { get => dn; set => dn = value; }

        private Panel botttomBorder;
        private Panel leftBorder;


        Form formActive = new Form();
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

            leftBorder = new Panel();
            leftBorder.Size = new Size(7, 49);
            flowLayoutPanel1.Controls.Add(leftBorder);
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            btnAccount.Text = Dn.DangNhap.TaiKhoan + "    ⏑";
            TemplateCurrentBn(btnHome);
            if (overview == null)
            {
                overview = new Overview();
                overview.FormClosed += Overview_FormClosed;
                overview.MdiParent = this;
                overview.Dn = Dn;
                overview.Show();
            }
            else
            {
                overview.Activate();
            }
        }

        Button currentButton = new Button();

        private void TemplateCurrentBn(Button btn)
        {
            if (btn != null) {
                currentButton.BackColor = Color.Transparent;
                currentButton.ForeColor = Color.FromArgb(161, 161, 161);
                currentButton = btn;
                currentButton.BackColor = Color.DarkCyan;
                currentButton.ForeColor = Color.White;
            }
        }

        private void restartForm(Form tmp)
        {
            formActive.Close();
            formActive = tmp;
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
                if(MenuContainer.Height <= 52)
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
                    btnCreaateInvoice.Width = sider.Width;
                    btnReport.Width = sider.Width;
                    btnSettings.Width = sider.Width;
                    //MenuContainer.Width = sider.Width;
                    //ReportContainer.Width = sider.Width;
                    //settingContainer.Width = sider.Width;
                }
            }
            else
            {
                sider.Width += 15;
                if ( sider.Width >= 216)
                {
                    sidebarExpand = true;
                    SidebarTransistion.Stop();
                    btnCreaateInvoice.Width = sider.Width;
                    btnHome.Width = sider.Width;
                    btnAbout.Width = sider.Width;
                    btnSettings.Width = sider.Width;
                    //MenuContainer.Width = sider.Width;
                    //ReportContainer.Width = sider.Width;
                    btnReport.Width = sider.Width;
                    //settingContainer.Width = sider.Width;
                }
            }
        }


        private void SettingsTransition_Tick(object sender, EventArgs e)
        {
            if (settingExpand == false)
            {
                settingContainer.Height += 10;
                if (settingContainer.Height >= 260)
                {
                    SettingsTransition.Stop();
                    settingExpand = true;
                }
            }
            else
            {
                settingContainer.Height -= 10;
                if (settingContainer.Height <= 49)
                {
                    SettingsTransition.Stop();
                    settingExpand = false;
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsTransition.Start();
        }
        // ================ Ham =================
        private void btnHam_Click(object sender, EventArgs e)
        {
            SidebarTransistion.Start();
        }


        //================ 1. Home Event CLick =================
        private void btnHome_Click(object sender, EventArgs e)
        {
            TemplateCurrentBn(btnHome);

            if (overview == null)
            {
                overview = new Overview();
                restartForm(overview);
                overview.FormClosed += Overview_FormClosed;
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
            TemplateCurrentBn(btnStaff);
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
            TemplateCurrentBn(btnCustomer);
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
            TemplateCurrentBn(btnVehicle);
            if (qLVehicle == null)
            {
                qLVehicle = new QLVehicle();
                formActive = qLVehicle;
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
            TemplateCurrentBn(btnSalesHistory);
            if (salesHistory == null)
            {
                salesHistory = new SalesHistory();
                formActive = salesHistory;
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
            TemplateCurrentBn(btnImportReport);
            if (importHistory == null)
            {
                importHistory = new ImportHistory();
                importHistory.FormClosed += ImportHistory_FormClosed;
                formActive = importHistory;
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
            TemplateCurrentBn(btnAbout);
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

        //================ 5. Settings Event CLick =================
        
        private void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            setting = null;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            TemplateCurrentBn(btnAccountStaff);
            if (account == null)
            {
                account = new FormAccount();
                account.FormClosed += account_FormClosed;
                account.MdiParent = this;
                account.Dock = DockStyle.Fill;
                account.Dn = Dn;
                account.Refresh();
                account.Show();
            }
            else
            {
                account.Activate();
            }
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
            botttomBorder.Location = new Point(btnCreaateInvoice.Location.X, 41);
            if (hoadon == null)
            {
                hoadon = new HoaDon();
                hoadon.FormClosed += hoadon_FormClosed;
                hoadon.MdiParent = this;
                hoadon.Dock = DockStyle.Fill;
                hoadon.Refresh();
                hoadon.Show();
            }
            else
            {
                hoadon.Activate();
            }

        }
        private void hoadon_FormClosed(object sender, FormClosedEventArgs e)
        {
            hoadon = null;

        }

        private void btnAddMotor_Click(object sender, EventArgs e)
        {
            botttomBorder.BackColor = System.Drawing.Color.FromArgb(72, 60, 255);
            botttomBorder.Location = new Point(btnAddMotor.Location.X, 41);
            if(AddMotor == null)
            {
                AddMotor = new FormAddMotor();
                AddMotor.FormClosed += MotorAdd_FormClosed;
                AddMotor.MdiParent = this;
                AddMotor.Dock = DockStyle.Fill;
                AddMotor.Show();
            }
            else
            {
                AddMotor.Activate();
            }

        }
        private void MotorAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            AddMotor = null;

        }
        private void btnAddColor_Click(object sender, EventArgs e)
        {
            if (color == null)
            {
                botttomBorder.BackColor = System.Drawing.Color.FromArgb(72, 60, 255);
                botttomBorder.Location = new Point(btnAddColor.Location.X, 41);
                color = new TableColor();
                color.FormClosed += Color_FormClosed;
                color.MdiParent = this;
                color.Show();
            }
            else
            {
                color.Activate();
            }
        }
        private void Color_FormClosed(object sender, FormClosedEventArgs e)
        {
            color = null;
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            botttomBorder.BackColor = System.Drawing.Color.FromArgb(72, 60, 255);
            botttomBorder.Location = new Point(btnCompany.Location.X, 41);
            if (company == null)
            {
                company = new TableNCC();
                company.FormClosed += NCC_FormClosed;
                company.MdiParent = this;
                company.Dock = DockStyle.Fill;
                company.Show();
            }
            else
            {
                company.Activate();
            }
        }
        private void NCC_FormClosed(object sender, FormClosedEventArgs e)
        {
            company = null;
        }

        private void btnAccountStaff_Click(object sender, EventArgs e)
        {
            TemplateCurrentBn(btnAccountStaff);
            if (account == null)
            {
                account = new FormAccount();
                account.FormClosed += account_FormClosed;
                account.MdiParent = this;
                account.Dock = DockStyle.Fill;
                account.Dn = Dn;
                account.Refresh();
                account.Show();
            }
            else
            {
                account.Activate();
            }
        }
        private void account_FormClosed(object sender, FormClosedEventArgs e)
        {
            account = null;
        }

        private void btnCustomerDeleted_Click(object sender, EventArgs e)
        {
            TemplateCurrentBn(btnCustomerDeleted);
            if (customerDeleted == null)
            {
                customerDeleted = new FormCustomerDeleted();
                customerDeleted.FormClosed += CusDeleted_FormClosed;
                customerDeleted.MdiParent = this;
                customerDeleted.Dock = DockStyle.Fill;
                customerDeleted.Refresh();
                customerDeleted.Show();
            }
            else
            {
                customerDeleted.Activate();
            }
        }
        private void CusDeleted_FormClosed(object sender, FormClosedEventArgs e)
        {
            customerDeleted = null;
        }
        private void btnMotorcycle_Click(object sender, EventArgs e)
        {
            TemplateCurrentBn(btnMotorcycle);
            if (motorDeleted == null)
            {
                motorDeleted = new FormMotorDeleted();
                motorDeleted.FormClosed += MotorDeleted_FormClosed;
                motorDeleted.MdiParent = this;
                motorDeleted.Dock = DockStyle.Fill;
                motorDeleted.Refresh();
                motorDeleted.Show();
            }
            else
            {
                motorDeleted.Activate();
            }
        }
        private void MotorDeleted_FormClosed(object sender, FormClosedEventArgs e)
        {
            motorDeleted = null;
        }
    }
}
