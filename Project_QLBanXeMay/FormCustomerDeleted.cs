using Project_QLBanXeMay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLBanXeMay
{
    public partial class FormCustomerDeleted : Form
    {
        Model1 context = new Model1();
        public FormCustomerDeleted()
        {
            InitializeComponent();
        }

        private void FormCustomerDeleted_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            BindGrid(context.KhachHangs.ToList());
            StyleDatagridview(dgvCustomer);
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
                if (x.HoatDong == 0)
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
        private void dgvCustomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                var list = context.KhachHangs.ToList();
                DataGridViewRow row = new DataGridViewRow();
                row = dgvCustomer.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
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

        private void btnkhoiPhuc1_Click(object sender, EventArgs e)
        {
            var find = context.KhachHangs.FirstOrDefault(p => p.MaKH == txtId.Text);
            if (find != null)
            {
                find.HoatDong = 1;
                context.SaveChanges();
                MessageBox.Show("Khoi phuc Thanh cong", "khoi phuc", MessageBoxButtons.OK);
                BindGrid(context.KhachHangs.ToList());
            }
            else
            {
                MessageBox.Show("khong tim thay khach hang trong csdl", "khoi phuc", MessageBoxButtons.OK);
            }
        }
    }
}
