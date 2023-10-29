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
    public partial class TableNCC : Form
    {
        public TableNCC()
        {
            InitializeComponent();
        }
        Model1 context = new Model1();
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

        }

        private void dgvCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvCompany.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtAddress.Text = row.Cells[2].Value.ToString();
                txtPhone.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid(List<NhaCungCap> list)
        {
            dgvCompany.Rows.Clear();
            foreach (var x in list)
            {
                int index = dgvCompany.Rows.Add();
                dgvCompany.Rows[index].Cells[0].Value = x.MaNCC;
                dgvCompany.Rows[index].Cells[1].Value = x.TenNCC;
                dgvCompany.Rows[index].Cells[2].Value = x.DiaChi;
                dgvCompany.Rows[index].Cells[3].Value = x.DienThoai;
                dgvCompany.Rows[index].Cells[4].Value = x.Email;

            }
        }

        private void TableNCC_Load(object sender, EventArgs e)
        {
            StyleDatagridview(dgvCompany);
            BindGrid(context.NhaCungCaps.ToList());
        }

        private void btnAddUpp_Click(object sender, EventArgs e)
        {
            try
            {
                var find = context.NhaCungCaps.FirstOrDefault(p => p.MaNCC == txtID.Text);
                if (find != null)
                {
                    find.TenNCC = txtName.Text;
                    find.DiaChi = txtAddress.Text;
                    find.Email = txtEmail.Text;
                    find.DienThoai = txtPhone.Text;
                    context.SaveChanges();
                    BindGrid(context.NhaCungCaps.ToList());
                    MessageBox.Show("Update successfully", "Update", MessageBoxButtons.OK);
                }
                else
                {
                    NhaCungCap ncc = new NhaCungCap();
                    ncc.MaNCC = txtID.Text;
                    ncc.TenNCC = txtName.Text;
                    ncc.DiaChi = txtAddress.Text;
                    ncc.Email = txtEmail.Text;
                    ncc.DienThoai = txtPhone.Text;
                    context.NhaCungCaps.Add(ncc);
                    context.SaveChanges();
                    BindGrid(context.NhaCungCaps.ToList());
                    MessageBox.Show("add new color successfully", "Update", MessageBoxButtons.OK);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var find = context.NhaCungCaps.FirstOrDefault(p => p.MaNCC == txtID.Text);
            if (find != null)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Delete", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    context.NhaCungCaps.Remove(find);
                    context.SaveChanges();
                    MessageBox.Show("Deleted successfully", "Delete", MessageBoxButtons.OK);
                    BindGrid(context.NhaCungCaps.ToList());
                }
            }
            else
            {
                MessageBox.Show("Not Found!!", "Delete", MessageBoxButtons.OK);
            }
        }
    }
}
