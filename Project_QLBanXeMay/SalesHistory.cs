using Project_QLBanXeMay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
            Model1 context = new Model1();
            var listCTPX = context.ChiTietPhieuXuats.ToList();
            List<ChiTietPhieuXuat> listCT = new List<ChiTietPhieuXuat>();
            foreach(var i in listCTPX)
            {
                if(DateTime.Compare((DateTime)i.PhieuXuat.NgayXuat, DateTime.Today)==0)
                    listCT.Add(i);
            }
            if(listCT.Count() == 0)
            {
                MessageBox.Show("There is no transaction history Today!!", "Manager", MessageBoxButtons.OK);
                BindGrid(listCTPX);
            }
            else
            {
                BindGrid(listCT);
            }                   
        }
        private void btnYesterday_Click(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            var listCTPX = context.ChiTietPhieuXuats.ToList();
            List<ChiTietPhieuXuat> listCT = new List<ChiTietPhieuXuat>();
            foreach (var i in listCTPX)
            {
                if (DateTime.Compare((DateTime)i.PhieuXuat.NgayXuat, DateTime.Today.AddDays(-1)) == 0)
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
            var listCTPX = context.ChiTietPhieuXuats.ToList();
            List<ChiTietPhieuXuat> listCT = new List<ChiTietPhieuXuat>();
            foreach (var i in listCTPX)
            {
                if (DateTime.Compare((DateTime)i.PhieuXuat.NgayXuat, DateTime.Today.AddDays(-7)) > 0 && DateTime.Compare((DateTime)i.PhieuXuat.NgayXuat, DateTime.Today) <=0)
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
            var listCTPX = context.ChiTietPhieuXuats.ToList();
            List<ChiTietPhieuXuat> listCT = new List<ChiTietPhieuXuat>();
            foreach (var i in listCTPX)
            {
                if (i.PhieuXuat.NgayXuat.Value.Year == DateTime.Today.Year && i.PhieuXuat.NgayXuat.Value.Month == DateTime.Today.Month)
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
            var listCTPX = context.ChiTietPhieuXuats.ToList();
            List<ChiTietPhieuXuat> listCT = new List<ChiTietPhieuXuat>();
            foreach (var i in listCTPX)
            {
                if (DateTime.Compare((DateTime)i.PhieuXuat.NgayXuat, dtpFrom.Value) >= 0 && DateTime.Compare((DateTime)i.PhieuXuat.NgayXuat, dtpTo.Value) <= 0)
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

        private void searchLabel_Click(object sender, EventArgs e)
        {
            searchLabel.Visible = false;
        }

        private void SalesHistory_Load(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            var listCTPX = context.ChiTietPhieuXuats.ToList();
            StyleDatagridview(dgvMotorcycles);
            BindGrid(listCTPX);
            
        }

        private void BindGrid(List<ChiTietPhieuXuat> list)
        {
            dgvMotorcycles.Rows.Clear();
            foreach (var x in list)
            {
                int index = dgvMotorcycles.Rows.Add();
                dgvMotorcycles.Rows[index].Cells[0].Value = x.MaPX;
                dgvMotorcycles.Rows[index].Cells[1].Value = x.PhieuXuat.KhachHang.TenKH;
                dgvMotorcycles.Rows[index].Cells[2].Value = x.Xe.TenXe;
                dgvMotorcycles.Rows[index].Cells[3].Value = x.Xe.SoLuongTong;
                dgvMotorcycles.Rows[index].Cells[4].Value = x.Xe.DonGia;
                dgvMotorcycles.Rows[index].Cells[5].Value = x.PhieuXuat.NgayXuat.Value.ToString("dd/MM/yyyy");
            }
        }

        void StyleDatagridview(DataGridView dgvMotor)
        {
            dgvMotor.BorderStyle = BorderStyle.None;
            dgvMotor.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMotor.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dgvMotor.EnableHeadersVisualStyles = false;
            dgvMotor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMotor.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(246, 246, 244);
            dgvMotor.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(41, 39, 163);
            dgvMotor.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 14);
            dgvMotor.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(41, 39, 163);
            dgvMotor.DefaultCellStyle.ForeColor = Color.FromArgb(125, 124, 124);
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            var listCTPX = context.ChiTietPhieuXuats.ToList();
            var listSeach =  listCTPX.Where(x => x.MaPX.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower())).ToList();
            BindGrid(listSeach);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SalesHistory_Load(sender, e);
        }
    }
}
