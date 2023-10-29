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
    public partial class FormAccount : Form
    {

        private NhanVien dn = new NhanVien();
        public NhanVien Dn { get => dn; set => dn = value; }

        Model1 context = new Model1();
        string pathImage = "";

        public FormAccount()
        {
            InitializeComponent();
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {

            this.ControlBox = false;
            fillCmbSex(context.NhanViens.ToList());
            DisplayAccount();
        }

        private void DisplayAccount()
        {
            txtAccount.Text = Dn.DangNhap.TaiKhoan;
            txtPass.Text = Dn.DangNhap.MatKhau;
            txtQuyen.Text = Dn.DangNhap.TenQuyen.ToString();

            txtFullName.Text = Dn.TenNV;
            txtMail.Text = Dn.Email;
            TxtAdd.Text = Dn.DiaChi;
            txtDT.Text = Dn.DienThoai;
            txtPosition.Text = Dn.ChucVu;
            cmbSex.Text = Dn.GioiTinh;
            ShowAvatar(Dn.Anh);
        }

        private void fillCmbSex(List<NhanVien> list)
        {
            list.Insert(0, new NhanVien());
            this.cmbSex.DataSource = list;
            this.cmbSex.DisplayMember = "GioiTinh";
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnAddUpp_Click(object sender, EventArgs e)
        {
            var find = context.NhanViens.FirstOrDefault(p => p.MaNV == Dn.MaNV);

            if (find != null)
            {
                find.TenNV = txtFullName.Text;
                find.Email = txtMail.Text;
                find.DiaChi = TxtAdd.Text;
                find.DienThoai = txtDT.Text;
                find.ChucVu = txtPosition.Text;
                find.GioiTinh = cmbSex.Text;
                if (find.Anh != pathImage)
                {
                    find.Anh = pathImage;
                }
                context.SaveChanges();
                SaveImage(pathImage);
                MessageBox.Show("Update successfully", "Update", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Update Fail", "Update", MessageBoxButtons.OK);
            }
        }


        private void ShowAvatar(string ImageName)
        {
            try
            {
                if (string.IsNullOrEmpty(ImageName))
                {
                    picAvatar.Image = null;
                }
                else
                {
                    string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                    string imagePath = Path.Combine(parentDirectory, "Images", ImageName);
                    picAvatar.Image = Image.FromFile(imagePath);
                    picAvatar.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }

        }

        public void SaveImage(string path)
        {

            var folder = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string imagePath = Path.Combine(folder, "Images");
            var img = imagePath + @"\" + path;
            picAvatar.Image.Save(img, ImageFormat.Jpeg);
        }

        private void btnAddImage_Click(object sender, EventArgs e)
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
                    picAvatar.Image = Image.FromFile(imageLocation);
                    pathImage = imageLocation.Substring(imageLocation.LastIndexOf("\\"));
                    pathImage = pathImage.Remove(0, 1);
                    var time = DateTime.Now.Ticks.ToString();
                    lbNameImg.Text = pathImage;
                    pathImage = time + "-" + pathImage;
                }
                ShowAvatar(pathImage);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
