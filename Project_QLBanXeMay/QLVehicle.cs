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
            dataGridView1.Rows.Add("tacv", 'b', "đasds", "male","3232", "434343 ", "dsdsdsd");
            dataGridView1.Rows.Add("amazing", 'b', 4, "male", "3232", "434343 ", "dsdsdsd");
            dataGridView1.Rows.Add("code", 'b', 4, "male", "3232", "434343 ", "dsdsdsd");
            dataGridView1.Rows.Add("verse", 'b', 4, "male", "3232", "434343 ", "dsdsdsd");
            dataGridView1.Rows.Add("whatever", 'b', 4, "female", "3232", "434343 ", "dsdsdsd");
        }
        void StyleDatagridview()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor =  System.Drawing.Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            //dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
            //dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            //dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(30, 30, 30);
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 12);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(246,246,244);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(41, 39, 163);
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
