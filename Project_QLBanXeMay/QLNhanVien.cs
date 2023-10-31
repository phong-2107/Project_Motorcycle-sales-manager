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

namespace Project_QLBanXeMay
{
    public partial class QLNhanVien : Form
    {
        public QLNhanVien()
        {
            InitializeComponent();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            StyleDatagridview(dgvStaff);
            Model1 context = new Model1();
            List<NhanVien> listNV = context.NhanViens.ToList();
            List<PhieuXuat> listPX = context.PhieuXuats.ToList();
            BindGridStaff(listNV);
       

            countTotalStaff.Text = listNV.Count().ToString();
        }

        private void BindGridStaff(List<NhanVien> list)
        {
            dgvStaff.Rows.Clear();
            foreach (var x in list)
            {
                int index = dgvStaff.Rows.Add();
                dgvStaff.Rows[index].Cells[0].Value = x.MaNV;
                dgvStaff.Rows[index].Cells[1].Value = x.TenNV;
                dgvStaff.Rows[index].Cells[2].Value = x.GioiTinh;
                dgvStaff.Rows[index].Cells[3].Value = x.DienThoai;
                dgvStaff.Rows[index].Cells[4].Value = x.Email;
                dgvStaff.Rows[index].Cells[5].Value = x.DiaChi;

            }
        }

        void StyleDatagridview(DataGridView dgvMotor)
        {
            dgvMotor.BorderStyle = BorderStyle.None;
            dgvMotor.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMotor.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dgvMotor.EnableHeadersVisualStyles = false;
            dgvMotor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMotor.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 12);
            dgvMotor.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(246, 246, 244);
            dgvMotor.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(41, 39, 163);
            dgvMotor.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 14);
            dgvMotor.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(41, 39, 163);
            dgvMotor.DefaultCellStyle.ForeColor = Color.FromArgb(92,84,122);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Model1 context1 = new Model1();
            var listSeach = context1.NhanViens.Where(x =>
                                    (x.MaNV.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower()))
                                    || (x.TenNV.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower()))
            || (x.DienThoai.Contains(txtSearch.Text.Trim()))
                                    || (x.Email.Contains(txtSearch.Text.Trim()))).ToList();
            if (txtSearch.Text.Trim() == "")
                BindGridStaff(context1.NhanViens.ToList());
            else
                BindGridStaff(listSeach);
            
        }
    }
}
