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
    public partial class QLVehicle : Form
    {
        public QLVehicle()
        {
            InitializeComponent();
            StyleDatagridview();
            populatedatagridview();
        }

        void populatedatagridview()
        {
            dgvMotorcycles.Rows.Add("tacv", 'b', "đasds", "male","3232", "434343 ", "dsdsdsd");
            dgvMotorcycles.Rows.Add("amazing", 'b', 4, "male", "3232", "434343 ", "dsdsdsd");
            dgvMotorcycles.Rows.Add("code", 'b', 4, "male", "3232", "434343 ", "dsdsdsd");
            dgvMotorcycles.Rows.Add("verse", 'b', 4, "male", "3232", "434343 ", "dsdsdsd");
            dgvMotorcycles.Rows.Add("whatever", 'b', 4, "female", "3232", "434343 ", "dsdsdsd");
        }
        void StyleDatagridview()
        {
            dgvMotorcycles.BorderStyle = BorderStyle.None;
            dgvMotorcycles.AlternatingRowsDefaultCellStyle.BackColor =  System.Drawing.Color.FromArgb(238, 239, 249);
            dgvMotorcycles.CellBorderStyle = DataGridViewCellBorderStyle.None;
            //dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
            //dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            //dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(30, 30, 30);
            dgvMotorcycles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dgvMotorcycles.EnableHeadersVisualStyles = false;
            dgvMotorcycles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 12);
            dgvMotorcycles.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(246,246,244);
            dgvMotorcycles.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(41, 39, 163);
        }

        private void QLVehicle_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




    }
}
