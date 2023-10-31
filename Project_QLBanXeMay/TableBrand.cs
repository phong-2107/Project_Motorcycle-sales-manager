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
    public partial class TableBrand : Form
    {
        public TableBrand()
        {
            InitializeComponent();
        }
        Model1 context = new Model1();
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        }

        private void BindGrid(List<HangXe> list)
        {
            dgvBrands.Rows.Clear();
            foreach (var x in list)
            {
                int index = dgvBrands.Rows.Add();
                dgvBrands.Rows[index].Cells[0].Value = x.MaHang;
                dgvBrands.Rows[index].Cells[1].Value = x.TenHang;
            }
        }


        private void btnAddUpp_Click(object sender, EventArgs e)
        {
            var find = context.HangXes.FirstOrDefault(p => p.MaHang == txtID.Text);
            if (find != null)
            {
                find.TenHang = txtName.Text;
                context.SaveChanges();
                BindGrid(context.HangXes.ToList());
                MessageBox.Show("Update successfully", "Update", MessageBoxButtons.OK);
            }
            else
            {
                HangXe color = new HangXe();
                color.MaHang = txtID.Text;
                color.TenHang = txtName.Text;
                context.HangXes.Add(color);
                context.SaveChanges();
                BindGrid(context.HangXes.ToList());
                MessageBox.Show("add new color successfully", "Update", MessageBoxButtons.OK);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var find = context.HangXes.FirstOrDefault(p => p.MaHang == txtID.Text);
            if (find != null)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Delete", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    context.HangXes.Remove(find);
                    context.SaveChanges();
                    MessageBox.Show("Deleted successfully", "Delete", MessageBoxButtons.OK);
                    BindGrid(context.HangXes.ToList());
                }
            }
            else
            {
                MessageBox.Show("Not Found!!", "Delete", MessageBoxButtons.OK);
            }
        }

        private void TableBrand_Load(object sender, EventArgs e)
        {
            StyleDatagridview(dgvBrands);
            BindGrid(context.HangXes.ToList());
        }

        private void dgvBrands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvBrands.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
