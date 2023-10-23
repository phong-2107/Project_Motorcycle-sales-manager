using Project_QLBanXeMay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            StyleDatagridview(dgvMotor);
            StyleDatagridview(dgvTransaction);
        }

        SalesHistory salesHistory;
        Home home;
        QLVehicle qLVehicle;
        private static string username;
        public string Username { get => username; set => username = value; }

        private DangNhap dn = new DangNhap();
        public DangNhap Dn { get => dn; set => dn = value; }

        private void Overview_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            txtusername.Text = Dn.TaiKhoan;

            Model1 context = new Model1();
            var listXe = context.Xes.ToList();
            var listSales = context.PhieuXuats.ToList();
            BindGridXe(listXe);
            BindGridTransaction(listSales);
            DisplayIncome(listSales);

        }
        private void BindGridXe(List<Xe> list)
        {
            dgvMotor.Rows.Clear();
            foreach (var x in list)
            {
                int index = dgvMotor.Rows.Add();
                dgvMotor.Rows[index].Cells[0].Value = x.TenXe;
                dgvMotor.Rows[index].Cells[1].Value = x.DonGia;
                dgvMotor.Rows[index].Cells[2].Value = x.HangXe.TenHang;
   
            }
        }



        private void BindGridTransaction(List<PhieuXuat> list)
        {
            dgvTransaction.Rows.Clear();
            foreach (var x in list)
            {
                if (dgvTransaction.Rows.Count < 5)
                {
                    int index = dgvTransaction.Rows.Add();
                    dgvTransaction.Rows[index].Cells[0].Value = x.MaPX;
                    dgvTransaction.Rows[index].Cells[1].Value = x.NhanVien.TenNV;
                    dgvTransaction.Rows[index].Cells[2].Value = x.KhachHang.TenKH;
                    dgvTransaction.Rows[index].Cells[3].Value = x.NgayXuat.Value.ToString("dd/MM/yyyy");
                    dgvTransaction.Rows[index].Cells[4].Value = x.TongTien;
                }
            }
        }

        private void DisplayIncome(List<PhieuXuat> listPX)
        {
            double? sumTotal = 0;
            double? sumDay = 0;
            int count = 0;
            foreach (var x in listPX)
            {
                sumTotal += x.TongTien;
                DateTime? date = x.NgayXuat;
                if(date.Value.Day == DateTime.Today.Day && date.Value.Year == DateTime.Today.Year && date.Value.Month == DateTime.Today.Month)
                {
                    sumDay += x.TongTien;
                }
                count++;
            }
            txtTotalCost.Text = sumTotal.ToString();
            txtIncomeToday.Text = sumDay.ToString();
            txtMoborSold.Text = count.ToString();
        }


        private void ShowAvatar(String ImageName, object picAvatar)
        {
            if (string.IsNullOrEmpty(ImageName)) picAvatar = null;
            else
            {
                string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string imagePath = Path.Combine(parentDirectory, "Images", ImageName);
                picAvatar = Image.FromFile(imagePath);
            }

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

        private void lbSales_Click(object sender, EventArgs e)
        {
            if(salesHistory == null)
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

        void StyleDatagridview(DataGridView dgvMotor)
        {
            dgvMotor.BorderStyle = BorderStyle.None;
            dgvMotor.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMotor.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dgvMotor.EnableHeadersVisualStyles = false;
            dgvMotor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMotor.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dgvMotor.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(246, 246, 244);
            dgvMotor.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(41, 39, 163);
            dgvMotor.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 14);
            dgvMotor.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(41, 39, 163);
            dgvMotor.DefaultCellStyle.ForeColor = Color.FromArgb(125, 124, 124);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Overview_Load(sender, e);
        }

        
    }
}
