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
    public partial class QLKhachHang : Form
    {
        public QLKhachHang()
        {
            InitializeComponent();
        }
        Model1 context = new Model1();
        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            var listCustomer = context.KhachHangs.ToList();
            this.ControlBox = false;
            StyleDatagridview(dgvCustomer);
            BindGrid(listCustomer);
            displayNumber();
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

        private void BindGrid(List<KhachHang> list)
        {
            dgvCustomer.Rows.Clear();
            foreach (var x in list)
            {
                if(x.HoatDong == 1)
                {
                    int index = dgvCustomer.Rows.Add();
                    dgvCustomer.Rows[index].Cells[0].Value = x.MaKH;
                    dgvCustomer.Rows[index].Cells[1].Value = x.TenKH;
                    dgvCustomer.Rows[index].Cells[2].Value = x.Email;
                    dgvCustomer.Rows[index].Cells[3].Value = x.DiaChi;
                    dgvCustomer.Rows[index].Cells[4].Value = x.DienThoai;
                }
            }
                
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
        }


        private void searchLabel_Click(object sender, EventArgs e)
        {
            searchLabel.Visible = false;
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var list = context.KhachHangs.ToList();
                DataGridViewRow row = new DataGridViewRow();
                row = dgvCustomer.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
                txtPhone.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddUpp_Click(object sender, EventArgs e)
        {
            try
            {
                var find = context.KhachHangs.FirstOrDefault(p => p.MaKH.Trim() == txtID.Text);
                if (find != null)
                {
                    find.MaKH = txtID.Text;
                    find.TenKH = txtName.Text;
                    find.Email = txtEmail.Text;
                    find.DiaChi = txtAddress.Text;
                    find.DienThoai = txtPhone.Text;
                    context.SaveChanges();
                    BindGrid(context.KhachHangs.ToList());
                    MessageBox.Show("Update successfully", "Update", MessageBoxButtons.OK);
                }
                else
                {
                    KhachHang x = new KhachHang();
                    x.MaKH = txtID.Text;
                    x.TenKH = txtName.Text;
                    x.Email = txtEmail.Text;
                    x.DiaChi = txtAddress.Text;
                    x.DienThoai = txtPhone.Text;
                    x.HoatDong = 1;
                    context.KhachHangs.Add(x);
                    context.SaveChanges();
                    MessageBox.Show("Add successfully");
                    BindGrid(context.KhachHangs.ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var findKH = context.KhachHangs.FirstOrDefault(p => p.MaKH == txtID.Text);
            
            

            if (findKH != null)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    findKH.HoatDong = 0;
                    
                    context.SaveChanges();
                    BindGrid(context.KhachHangs.ToList());
                    MessageBox.Show("xoa thanh cong");
                }

            }
            else
            {
                MessageBox.Show("kh tim thay");
            }
        }

        private void displayNumber()
        {
            int count = dgvCustomer.Rows.Count;
            lBCustomer.Text = count.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            QLKhachHang_Load(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            var listKHHD = context.KhachHangs.Where(p => p.HoatDong == 1).ToList();
            var listSeach = listKHHD.Where(x => (x.MaKH.Trim().ToLower().Contains(textBox1.Text.Trim().ToLower())) || (x.TenKH.Trim().ToLower().Contains(textBox1.Text.Trim().ToLower()))).ToList();
            BindGrid(listSeach);
        }
    }
}
