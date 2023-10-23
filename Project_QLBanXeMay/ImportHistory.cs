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

namespace Project_QLBanXeMay
{
    public partial class ImportHistory : Form
    {
        public ImportHistory()
        {
            InitializeComponent();
        }

        private void ImportHistory_Load(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            var listCTPN = context.ChiTietPhieuNhaps.ToList();
            StyleDatagridview(dgvMotorcycles);
            BindGrid(listCTPN);
            Countmotor(listCTPN);
        }

        private void BindGrid(List<ChiTietPhieuNhap> list)
        {
            dgvMotorcycles.Rows.Clear();
            foreach (var x in list)
            {
                int index = dgvMotorcycles.Rows.Add();
                dgvMotorcycles.Rows[index].Cells[0].Value = x.MaPN;
                dgvMotorcycles.Rows[index].Cells[1].Value = x.Xe.TenXe;
                dgvMotorcycles.Rows[index].Cells[2].Value = x.Xe.HangXe.TenHang;
                dgvMotorcycles.Rows[index].Cells[3].Value = x.SoLuong;
                dgvMotorcycles.Rows[index].Cells[4].Value = x.Xe.DonGia;
                dgvMotorcycles.Rows[index].Cells[5].Value = x.PhieuNhap.NgayNhap.Value.ToString("dd/MM/yyyy");
            }
        }

        private void Countmotor(List<ChiTietPhieuNhap> list)
        {
            int? count = 0;
            foreach (var x in list)
            {
                count += x.SoLuong;
            }
            lbNumber.Text = count.ToString();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            SearchByDate.Visible = true;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            SearchByDate.Visible = false;
            Model1 context = new Model1();
            var listCTPN = context.ChiTietPhieuNhaps.ToList();
            List<ChiTietPhieuNhap> listCT = new List<ChiTietPhieuNhap>();
            foreach (var i in listCTPN)
            {
                if (DateTime.Compare((DateTime)i.PhieuNhap.NgayNhap, DateTime.Today) == 0)
                    listCT.Add(i);
            }
            if (listCT.Count() == 0)
            {
                MessageBox.Show("There is no transaction history Today!!", "Manager", MessageBoxButtons.OK);
                BindGrid(listCTPN);
            }
            else
            {
                BindGrid(listCT);
            }
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            var listCTPX = context.ChiTietPhieuNhaps.ToList();
            List<ChiTietPhieuNhap> listCT = new List<ChiTietPhieuNhap>();
            foreach (var i in listCTPX)
            {
                if (DateTime.Compare((DateTime)i.PhieuNhap.NgayNhap, DateTime.Today.AddDays(-1)) == 0)
                    listCT.Add(i);
            }
            if (listCT.Count() == 0)
            {
                MessageBox.Show("There is no transaction history Yesterday!!", "Manager", MessageBoxButtons.OK);
                BindGrid(listCTPX);
            }
            else
            {
                BindGrid(listCT);
            }
            SearchByDate.Visible = false;
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            var listCTPX = context.ChiTietPhieuNhaps.ToList();
            List<ChiTietPhieuNhap> listCT = new List<ChiTietPhieuNhap>();
            foreach (var i in listCTPX)
            {
                if (DateTime.Compare((DateTime)i.PhieuNhap.NgayNhap, DateTime.Today.AddDays(-7)) > 0 
                    && DateTime.Compare((DateTime)i.PhieuNhap.NgayNhap, DateTime.Today) <= 0)
                    listCT.Add(i);
            }
            if (listCT.Count() == 0)
            {
                MessageBox.Show("There is no transaction history Week!!", "Manager", MessageBoxButtons.OK);

                BindGrid(listCTPX);
            }
            else
            {
                BindGrid(listCT);
            }
        }
         
        private void btnMonth_Click(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            var listCTPX = context.ChiTietPhieuNhaps.ToList();
            List<ChiTietPhieuNhap> listCT = new List<ChiTietPhieuNhap>();
            foreach (var i in listCTPX)
            {
                if (i.PhieuNhap.NgayNhap.Value.Year == DateTime.Today.Year && i.PhieuNhap.NgayNhap.Value.Month == DateTime.Today.Month)
                    listCT.Add(i);
            }
            if (listCT.Count() == 0)
            {
                MessageBox.Show("There is no transaction history Month!!", "Manager", MessageBoxButtons.OK);

                BindGrid(listCTPX);
            }
            else
            {
                BindGrid(listCT);
            }
        }

        private void btnSearchDay_Click(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            var listCTPX = context.ChiTietPhieuNhaps.ToList();
            List<ChiTietPhieuNhap> listCT = new List<ChiTietPhieuNhap>();
            foreach (var i in listCTPX)
            {
                if (DateTime.Compare((DateTime)i.PhieuNhap.NgayNhap, dtpFrom.Value) >= 0 && DateTime.Compare((DateTime)i.PhieuNhap.NgayNhap, dtpTo.Value) <= 0)
                    listCT.Add(i);
            }
            if (listCT.Count() == 0)
            {
                MessageBox.Show($"There is no transaction history from {dtpFrom.Value.ToShortDateString().ToString()} to {dtpTo.Value.ToShortDateString().ToString()}!!", "Manager", MessageBoxButtons.OK);

                BindGrid(listCTPX);
            }
            else
            {
                BindGrid(listCT);
            }
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
            dgvMotor.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 13);
            dgvMotor.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(41, 39, 163);
            dgvMotor.DefaultCellStyle.ForeColor = Color.FromArgb(125, 124, 124);
        }


        

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            var listCTPN = context.ChiTietPhieuNhaps.ToList();
            var listSeach = listCTPN.Where(x => x.MaPN.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower())).ToList();
            BindGrid(listSeach);
        }

        private void borderPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void borderPanel2_Click(object sender, EventArgs e)
        {
            searchLabel.Visible = false;
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            searchLabel.Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ImportHistory_Load(sender, e);
        }
    }
}
