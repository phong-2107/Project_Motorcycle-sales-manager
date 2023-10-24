using Project_QLBanXeMay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLBanXeMay
{
    public partial class QLVehicle : Form
    {
        // method
        Model1 context = new Model1();
        string pathImage = "";

        public QLVehicle()
        {
            InitializeComponent();
            StyleDatagridview(dgvMotorcycles);
        }

        private void QLVehicle_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            var listXe = context.Xes.ToList();
            var listMau = context.MauXes.ToList();
            var listHang = context.HangXes.ToList();
            BindGrid(listXe);
            FillColor(listMau);
            FillHangXe(listHang);
            displayNumber();
        }

        private void displayNumber()
        {
            CountMotorModel.Text = dgvMotorcycles.Rows.Count.ToString();
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

        private void BindGrid(List<Xe> list)
        {
            dgvMotorcycles.Rows.Clear();
            foreach (var x in list)
            {
                if(x.HoatDong == 1)
                {
                    int index = dgvMotorcycles.Rows.Add();
                    dgvMotorcycles.Rows[index].Cells[0].Value = x.MaXe;
                    dgvMotorcycles.Rows[index].Cells[1].Value = x.TenXe;
                    dgvMotorcycles.Rows[index].Cells[2].Value = x.MauXe.TenMau;
                    dgvMotorcycles.Rows[index].Cells[3].Value = x.SoLuongTong;
                    dgvMotorcycles.Rows[index].Cells[4].Value = x.DonGia;
                    dgvMotorcycles.Rows[index].Cells[5].Value = x.HangXe.TenHang;
                }
                
            }
        }

        private void FillColor(List<MauXe> list)
        {
            list.Insert(0, new MauXe());
            this.cmbColor.DataSource = list;
            this.cmbColor.DisplayMember = "TenMau";
            this.cmbColor.ValueMember = "MaMau";
        }

        private void FillHangXe(List<HangXe> list)
        {
            list.Insert(0, new HangXe());
            this.cmbCompany.DataSource = list;
            this.cmbCompany.DisplayMember = "TenHang";
            this.cmbCompany.ValueMember = "MaHang";
        }

       private void ShowAvatar(string ImageName)
        {
            try
            {
                if (string.IsNullOrEmpty(ImageName))
                {
                    picMotor.Image = null;
                }
                else
                {
                    string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                    string imagePath = Path.Combine(parentDirectory, "Images", ImageName);
                    picMotor.Image = Image.FromFile(imagePath);
                    picMotor.Refresh();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void SaveImage(string path)
        {
            var folder = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string imagePath = Path.Combine(folder, "Images");
            var img = imagePath + @"\" + path;
            picMotor.Image.Save(img, ImageFormat.Jpeg);
        }

        private void dgvMotorcycles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var list = context.Xes.ToList();
                DataGridViewRow row = new DataGridViewRow();
                row = dgvMotorcycles.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtNameMotor.Text = row.Cells[1].Value.ToString();
                cmbColor.Text = row.Cells[2].Value.ToString();
                txtQuantity.Text = row.Cells[3].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString();
                cmbCompany.Text = row.Cells[5].Value.ToString();
                var find = list.FirstOrDefault(p => p.MaXe.Trim() == txtId.Text);
                txtDisplacement.Text = find.PhanKhoi.ToString();
                txtLoai.Text = find.LoaiXe.ToString();
                ShowAvatar(find.AnhXe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
 
        private void btnAddImg_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog fileOpen = new OpenFileDialog();
                fileOpen.Title = "chon hinh anh Xe";
                fileOpen.Filter = "Hình ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                if (fileOpen.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = fileOpen.FileName;
                    picMotor.Image = Image.FromFile(imageLocation);
                    pathImage = imageLocation.Substring(imageLocation.LastIndexOf("\\"));
                    pathImage = pathImage.Remove(0, 1);
                    var time = DateTime.Now.Ticks.ToString();
                    pathImage = time + "-" + pathImage;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            var listXe = context.Xes.ToList();
            var listSeach = listXe.Where(x => (x.MaXe.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower())) || (x.TenXe.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower()))).ToList();

            BindGrid(listSeach);
        }

        private void btnAddUpp_Click(object sender, EventArgs e)
        {
            try
            {
               
                var find = context.Xes.FirstOrDefault(p => (p.MaXe.Trim() == txtId.Text) && (p.HoatDong == 1));
                if (find != null)
                {
                    find.TenXe = txtNameMotor.Text;
                    find.MauXe.TenMau = cmbColor.Text;
                    find.DonGia = int.Parse(txtPrice.Text);
                    find.SoLuongTong = int.Parse(txtQuantity.Text);
                    find.PhanKhoi = int.Parse(txtDisplacement.Text);
                    find.HangXe.TenHang = cmbCompany.Text;
                    find.LoaiXe = txtLoai.Text;

                    find.AnhXe = pathImage;
                    SaveImage(pathImage);
                    context.SaveChanges();
                    BindGrid(context.Xes.ToList());
                    MessageBox.Show("Update successfully", "Update", MessageBoxButtons.OK);
                }
                else
                {
                    Xe x = new Xe();
                    x.MaXe = txtId.Text;
                    x.TenXe = txtNameMotor.Text;
                    x.MauXe.TenMau = cmbColor.Text;
                    x.SoLuongTong = int.Parse(txtQuantity.Text);
                    x.DonGia = double.Parse(txtPrice.Text);
                    x.PhanKhoi = int.Parse(txtDisplacement.Text);
                    x.HangXe.TenHang = cmbCompany.Text;
                    x.LoaiXe = txtLoai.Text;
                    x.AnhXe = pathImage;
                    x.HoatDong = 1;
                    SaveImage(pathImage);
                    context.Xes.Add(x);
                    context.SaveChanges();
                    MessageBox.Show("Add successfully");
                    BindGrid(context.Xes.ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            var context = new Model1();
            var findxe = context.Xes.FirstOrDefault(p => (p.MaXe == txtId.Text) &&(p.HoatDong == 1));
            //var findc

            if (findxe != null)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {

                    //context.Xes.Remove(findxe);
                    findxe.HoatDong = 0;
                    context.SaveChanges();
                    QLVehicle_Load(sender, e);
                    MessageBox.Show("xoa thanh cong");
                }

            }
            else
            {
                MessageBox.Show("kh tim thay");
            }
        }
    }
}
