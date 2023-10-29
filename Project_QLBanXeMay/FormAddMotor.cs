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
        int count = 1;
        int dem = 0;
        int countM = 0;
        private Xe xe = new Xe();

        List<ChiTietPhieuNhap> listCTPN = new List<ChiTietPhieuNhap>();

        public Xe Xe { get => xe; set => xe = value; }

        public FormAddMotor()
        {
            InitializeComponent();
        }

        private void FormAddMotor_Load(object sender, EventArgs e)
        {
            FillXe(context.Xes.ToList());
            FillNCC(context.NhaCungCaps.ToList());
            StyleDatagridview(dgvMotorcycles);
            StyleDatagridview(dgvPay);
        }

        private void FillXe(List<Xe> list)
        {
            foreach (var item in list)
            {
                string dp = item.MaXe.ToString() + "-" + item.TenXe.ToString();
                cmbID.Items.Add(dp);
            }
        }

        private void FillNCC(List<NhaCungCap> list)
        {
            list.Insert(0, new NhaCungCap());
            this.cmbNCC.DataSource = list;
            this.cmbNCC.DisplayMember = "TenNCC";
            this.cmbNCC.ValueMember = "MaNCC";
        } 
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            reset();
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
            showInforMotor(Xe);
        }
        private void Create_FormClosed(object sender, FormClosedEventArgs e)
        {
            create = null;
        }

        private void showInforMotor(Xe x)
        {
            
            txtID.Text = x.MaXe.ToString();
            txtName.Text = x.TenXe.ToString();
            txtColor.Text = x.MauXe.TenMau.ToString();
            pnMotor.Visible = true;
        }

        private void btnAddXe_Click(object sender, EventArgs e)
        {
            if (RangBuoc() == false) return;
            pndetail.Visible = true;
            //count = int.Parse( txtQuantity.Text.Trim());
            ChiTietPhieuNhap ct  =new ChiTietPhieuNhap();
            ct.MaPN = countM.ToString();
            ct.MaXe = txtID.Text;
            ct.SoLuong = int.Parse(txtQuantity.Text);
            var find = context.Xes.FirstOrDefault(p => p.MaXe == txtID.Text);
            ct.DonGia = find.DonGia;
            ct.ThanhTien = find.DonGia * double.Parse(txtQuantity.Text.Trim());
            listCTPN.Add(ct);
            countM++;
        }
        private void cmbID_TextChanged(object sender, EventArgs e)
        {
            var list = cmbID.Text.Trim().Split('-');
            string tmp = list[0];
            var find = context.Xes.FirstOrDefault(p => p.MaXe == tmp);
            if (find != null)
            {
                showInforMotor((Xe)find);
            }
        }
        List<ChiTietXe> CTX = new List<ChiTietXe>();
        private void btnSave_Click(object sender, EventArgs e)
        {
            var check = context.ChiTietXes.FirstOrDefault(p => (p.SoKhung == txtSoKhung.Text.Trim()) || (p.SoMay == txtSoMay.Text.Trim()));
            if(check != null)
            {
                MessageBox.Show("Data đã có trong cơ sở dữ liệu", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                count++;
                lbCount.Text = (count).ToString();
                ChiTietXe ct = new ChiTietXe();
                ct.MaCT = dem;
                ct.MaXe = txtID.Text;
                ct.SoKhung = txtSoKhung.Text;
                ct.SoMay = txtSoMay.Text;
                ct.Active = false;
                CTX.Add(ct);
                clearCT();
                dem++;
                BindGrid(CTX);
                if (count == int.Parse(txtQuantity.Text))
                {

                    DialogResult res = MessageBox.Show("Thêm Hoàn tất, bạn Có Muốn tiếp tục thêm xe?", "Add Motor", MessageBoxButtons.YesNo);

                    if (res == DialogResult.Yes)
                    {
                        reset();
                    }
                    else if (res == DialogResult.No)
                    {
                        PnThanhToan.Visible = true;
                        BindGridCT(listCTPN);
                        reset();
                    }
                }
                
            }
            
        }

        private void BindGridCT(List<ChiTietPhieuNhap> list)
        {
            
            if(list.Count != 0)
            {
                double? sum = 0;
                dgvPay.Rows.Clear();
                foreach (var x in list)
                {
                    int index = dgvPay.Rows.Add();
                    dgvPay.Rows[index].Cells[0].Value = x.MaXe;
                    dgvPay.Rows[index].Cells[1].Value = x.SoLuong;
                    dgvPay.Rows[index].Cells[2].Value = x.ThanhTien;
                    sum += x.ThanhTien;
                }
                lbsumCost.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("khong co gia tri");
            }
        }

        private void reset()
        {
            cmbID.Text = "";
            txtID.Text = "";
            txtName.Text = "";
            txtColor.Text = "";
            pndetail.Visible = false;
            clearCT();
            pnMotor.Visible = false;
            txtQuantity.Text = "";
            cmbNCC.Text = "";
            count = 1;

        }

        private void clearCT()
        {
            txtSoKhung.Text = "";
            txtSoMay.Text = "";
        }

        private bool RangBuoc()
        {
            if(txtID.Text == "" || txtName.Text == "" || txtColor.Text == "" || txtQuantity.Text == "" || cmbNCC.Text == "")
            {
                MessageBox.Show("Ban Can nhap Day Du thong Tin", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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

        private void BindGrid(List<ChiTietXe> list)
        {
            dgvMotorcycles.Rows.Clear();
            foreach (var x in list)
            {
                var find = context.Xes.FirstOrDefault(p => p.MaXe == x.MaXe);
                int index = dgvMotorcycles.Rows.Add();
                dgvMotorcycles.Rows[index].Cells[0].Value = x.MaCT;
                dgvMotorcycles.Rows[index].Cells[1].Value = find.MaXe;
                dgvMotorcycles.Rows[index].Cells[2].Value = x.SoKhung;
                dgvMotorcycles.Rows[index].Cells[3].Value = x.SoMay;
                dgvMotorcycles.Rows[index].Cells[4].Value = find.DonGia;
                dgvMotorcycles.Rows[index].Cells[5].Value = x.Active;
            }
        }

        private void dgvMotorcycles_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
