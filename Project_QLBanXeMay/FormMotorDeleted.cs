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
    public partial class FormMotorDeleted : Form
    {
        Model1 context = new Model1();
        public FormMotorDeleted()
        {
            InitializeComponent();
        }

        private void FormMotorDeleted_Load(object sender, EventArgs e)
        {
            Model1 context1 = new Model1();
            this.ControlBox = false;
            StyleDatagridview(dgvMotorcycles);
            BindGridXe(context1.Xes.ToList());
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

        }



        private void BindGridXe(List<Xe> list)
        {
            dgvMotorcycles.Rows.Clear();
            foreach (var x in list)
            {
                if (x.HoatDong == 0)
                {
                    int index = dgvMotorcycles.Rows.Add();
                    dgvMotorcycles.Rows[index].Cells[0].Value = x.MaXe;
                    dgvMotorcycles.Rows[index].Cells[1].Value = x.TenXe;
                    dgvMotorcycles.Rows[index].Cells[2].Value = x.MauXe.TenMau;
                    dgvMotorcycles.Rows[index].Cells[3].Value = x.SoLuong;
                    dgvMotorcycles.Rows[index].Cells[4].Value = x.DonGia;
                }

            }
        }

        private void btnKhoiPhuc2_Click(object sender, EventArgs e)
        {
            var find = context.Xes.FirstOrDefault(p => p.MaXe == txtMaXe.Text);
            if (find != null)
            {
                DialogResult res = MessageBox.Show("ban co chac muon khoi phuc", "Confirmation", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    find.HoatDong = 1;
                    context.SaveChanges();
                    MessageBox.Show("Khoi phuc Thanh cong", "khoi phuc", MessageBoxButtons.OK);
                    BindGridXe(context.Xes.ToList());
                }
            }
            else
            {
                MessageBox.Show("khong tim thay xe trong csdl", "khoi phuc", MessageBoxButtons.OK);
            }
        }

        private void dgvMotorcycles_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var list = context.Xes.ToList();
                DataGridViewRow row = new DataGridViewRow();
                row = dgvMotorcycles.Rows[e.RowIndex];
                txtMaXe.Text = row.Cells[0].Value.ToString();
                txtNameMotor.Text = row.Cells[1].Value.ToString();
                cmbColor.Text = row.Cells[2].Value.ToString();
                txtQuantity.Text = row.Cells[3].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString();

                var find = list.FirstOrDefault(p => p.MaXe.Trim() == txtMaXe.Text);
                txtDisplacement.Text = find.PhanKhoi.ToString();
                txtLoai.Text = find.LoaiXe.ToString();
                cmbCompany.Text = find.HangXe.TenHang;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormMotorDeleted_Load(sender, e);
        }
    }
}
