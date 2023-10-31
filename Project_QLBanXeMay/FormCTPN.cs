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
    public partial class FormCTPN : Form
    {
        public FormCTPN()
        {
            InitializeComponent();
        }
         List<ChiTietXe> ctx = new List<ChiTietXe>();

        public List<ChiTietXe> Ctx { get => ctx; set => ctx = value; }

        private void FormCTPN_Load(object sender, EventArgs e)
        {
            StyleDatagridview(dgvMotorcycles);
            BindGrid(Ctx);
            if(Ctx.Count() != 0)
            {
                lbName.Text = Ctx.First().MaPN;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BindGrid(List<ChiTietXe> list)
        {
            dgvMotorcycles.Rows.Clear();
            foreach (var x in list)
            {
                int index = dgvMotorcycles.Rows.Add();
                dgvMotorcycles.Rows[index].Cells[0].Value = x.MaPN;
                dgvMotorcycles.Rows[index].Cells[1].Value = x.Xe.TenXe;
                dgvMotorcycles.Rows[index].Cells[2].Value = x.SoKhung;
                dgvMotorcycles.Rows[index].Cells[3].Value = x.SoMay;
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
    }
}
