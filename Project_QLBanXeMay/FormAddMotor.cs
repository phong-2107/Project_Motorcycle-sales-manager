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
    public partial class FormAddMotor : Form
    {
        Model1 context = new Model1();
        CreateMotor create;

        public FormAddMotor()
        {
            InitializeComponent();
        }

        private void FormAddMotor_Load(object sender, EventArgs e)
        {
            
        }

        private void borderPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            
            if(create == null)
            {
                create = new CreateMotor();
                create.FormClosed += Create_FormClosed;
                create.Dock = DockStyle.Fill;
                create.Refresh();
                create.Show();
            }
            else
            {
                create.Activate();
            }
        }
        private void Create_FormClosed(object sender, FormClosedEventArgs e)
        {
            create = null;
        }
    }
}
