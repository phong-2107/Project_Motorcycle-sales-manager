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
            /*
            var str = countStaff(listPX);
            var nv = listNV.FirstOrDefault(p => p.MaNV == str);
            lbName.Text = nv.TenNV;*/

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

        private string countStaff(List<PhieuXuat> list)
        {
            int count = 0;
            var most = list.GroupBy(x => x.MaNV).OrderByDescending(p => p.Count()).Select(gp => gp.Key).First();
            return most;
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
            dgvMotor.DefaultCellStyle.ForeColor = Color.FromArgb(125, 124, 124);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
        }
    }
}
