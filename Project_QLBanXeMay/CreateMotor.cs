using Project_QLBanXeMay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLBanXeMay
{
    public partial class CreateMotor : Form
    {
        Model1 context = new Model1();
        string pathImage = "";
        public CreateMotor()
        {
            InitializeComponent();
        }


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
            catch (Exception ex)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
           

                var find = context.Xes.FirstOrDefault(p => (p.MaXe.Trim() == txtId.Text) && (p.HoatDong == 1));
                if (find != null)
                {
                    MessageBox.Show("This ID is already in database", "Create Motor", MessageBoxButtons.OK);
                }
                else
                {
                    
                    
                    Xe x = new Xe();
                    x.MaXe = txtId.Text;
                    x.TenXe = txtNameMotor.Text;
                    var color = context.MauXes.FirstOrDefault(p => (p.TenMau == cmbColor.Text.Trim()));
                    if(color != null)
                    {
                        x.MaMau = color.MaMau;
                    }
                    x.SoLuong = 0;
                    x.DonGia = double.Parse(txtPrice.Text);
                    x.NhienLieu = txtFuel.Text;
                    //x.PhanKhoi = 120;    //int.Parse(txtDisplacement.Text.Trim());
                    x.LoaiXe = txtLoai.Text;
                    x.AnhXe = pathImage;
                    var Hang = context.HangXes.FirstOrDefault(p => p.TenHang == cmbCompany.Text.Trim());
                    if(Hang != null)
                        x.MaHang = Hang.MaHang;
                    x.HoatDong = 1;
                    SaveImage(pathImage);
                    //FormAddMotor formAddMotor = new FormAddMotor();
                    //formAddMotor.Xe = x;
                    context.Xes.Add(x);
                    context.SaveChanges();
                    MessageBox.Show("Add successfully", "Create Motor", MessageBoxButtons.OK);
                    this.Close();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateMotor_Load(object sender, EventArgs e)
        {
            FillColor(context.MauXes.ToList());
            FillHangXe(context.HangXes.ToList());
        }
    }
}
