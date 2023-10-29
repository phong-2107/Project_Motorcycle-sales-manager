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
    public partial class TableColor : Form
    {
        public TableColor()
        {
            InitializeComponent();
        }
        Model1 context = new Model1();
        private void TableColor_Load(object sender, EventArgs e)
        {
            BindGrid(context.MauXes.ToList());
            StyleDatagridview(dgvColors);
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

        private void BindGrid(List<MauXe> list)
        {
            dgvColors.Rows.Clear();
            foreach (var x in list)
            {
                int index = dgvColors.Rows.Add();
                dgvColors.Rows[index].Cells[0].Value = x.MaMau;
                dgvColors.Rows[index].Cells[1].Value = x.TenMau;
            }
        }

        private void dgvColors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvColors.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUpp_Click(object sender, EventArgs e)
        {
            var find = context.MauXes.FirstOrDefault(p => p.MaMau == txtID.Text);
            if(find != null)
            {
                find.TenMau = txtName.Text;
                context.SaveChanges();
                BindGrid(context.MauXes.ToList());
                MessageBox.Show("Update successfully", "Update", MessageBoxButtons.OK);
            }
            else
            {
                MauXe color = new MauXe();
                color.MaMau = txtID.Text;
                color.TenMau = txtName.Text;
                context.MauXes.Add(color);
                context.SaveChanges() ;
                BindGrid(context.MauXes.ToList());
                MessageBox.Show("add new color successfully", "Update", MessageBoxButtons.OK);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var find = context.MauXes.FirstOrDefault(p => p.MaMau == txtID.Text);
            if(find != null)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Delete", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    context.MauXes.Remove(find);
                    context.SaveChanges();
                    MessageBox.Show("Deleted successfully", "Delete", MessageBoxButtons.OK);
                    BindGrid(context.MauXes.ToList());
                }
            }
            else
            {
                MessageBox.Show("Not Found!!", "Delete", MessageBoxButtons.OK);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
