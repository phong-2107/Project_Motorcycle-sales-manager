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
    public partial class FormSetting : Form
    {
        private NhanVien dn = new NhanVien();
        public NhanVien Dn { get => dn; set => dn = value; }

        Model1 context = new Model1();
        string pathImage = "";
        public FormSetting()
        {
            InitializeComponent();
            
        }


        private void FormSetting_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            fillCmbSex(context.NhanViens.ToList());
            DisplayAccount();
            BindGrid(context.KhachHangs.ToList());
            StyleDatagridview(dgvCustomer);
            StyleDatagridview(dgvMotorcycles);
            BindGridXe(context.Xes.ToList());
        }

        private void DisplayAccount()
        {
            txtAccount.Text = Dn.DangNhap.TaiKhoan;
            txtPass.Text = Dn.DangNhap.MatKhau;
            txtQuyen.Text = Dn.DangNhap.Quyen.ToString();

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
                if(find.Anh != null && find.Anh != pathImage)
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
            catch(Exception ex)
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormSetting_Load(sender, e);
        }


        void StyleDatagridview(DataGridView dgvMotor)
        {
            dgvMotor.BorderStyle = BorderStyle.None;
            dgvMotor.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMotor.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dgvMotor.EnableHeadersVisualStyles = false;
            dgvMotor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMotor.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 12);
            dgvMotor.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(246, 246, 244);
            dgvMotor.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(41, 39, 163);
            dgvMotor.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 14);
            dgvMotor.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(41, 39, 163);

        }

        private void BindGrid(List<KhachHang> list)
        {
            dgvCustomer.Rows.Clear();
            foreach (var x in list)
            {
                if (x.HoatDong == 0)
                {
                    int index = dgvCustomer.Rows.Add();
                    dgvCustomer.Rows[index].Cells[0].Value = x.MaKH;
                    dgvCustomer.Rows[index].Cells[1].Value = x.TenKH;
                    dgvCustomer.Rows[index].Cells[2].Value = x.Email;
                    dgvCustomer.Rows[index].Cells[3].Value = x.DiaChi;
                    dgvCustomer.Rows[index].Cells[4].Value = x.DienThoai;
                }
            }

        }


        private void dgvCustomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                var list = context.KhachHangs.ToList();
                DataGridViewRow row = new DataGridViewRow();
                row = dgvCustomer.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
                txtPhone.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnkhoiPhuc1_Click(object sender, EventArgs e)
        {
            var find = context.KhachHangs.FirstOrDefault(p => p.MaKH == txtId.Text);
            if(find!= null)
            {
                find.HoatDong = 1;
                context.SaveChanges();
                MessageBox.Show("Khoi phuc Thanh cong", "khoi phuc", MessageBoxButtons.OK);
                BindGrid(context.KhachHangs.ToList());
            }
            else
            {
                MessageBox.Show("khong tim thay xe trong csdl", "khoi phuc", MessageBoxButtons.OK);
            }
        }

        private void BindGridXe(List<Xe> list)
        {
            dgvMotorcycles.Rows.Clear();
            foreach (var x in list)
            {
                if (x.HoatDong == 0)
                {
                    int index = dgvMotorcycles.Rows.Add();
                    dgvMotorcycles.Rows[index].Cells[0].Value = x.MaXe;
                    dgvMotorcycles.Rows[index].Cells[1].Value = x.TenXe;
                    dgvMotorcycles.Rows[index].Cells[2].Value = x.MauXe.TenMau;
                    dgvMotorcycles.Rows[index].Cells[3].Value = x.SoLuongTong;
                    dgvMotorcycles.Rows[index].Cells[4].Value = x.DonGia;
                }

            }
        }

        private void btnKhoiPhuc2_Click(object sender, EventArgs e)
        {
            var find = context.Xes.FirstOrDefault(p => p.MaXe == txtMaXe.Text);
            if (find != null)
            {
                DialogResult res = MessageBox.Show("ban co chac muon khoi phuc", "Confirmation", MessageBoxButtons.YesNo);
                if(res == DialogResult.Yes)
                {
                    find.HoatDong = 1;
                    context.SaveChanges();
                    MessageBox.Show("Khoi phuc Thanh cong", "khoi phuc", MessageBoxButtons.OK);
                    BindGridXe(context.Xes.ToList());
                }
            }
            else
            {
                MessageBox.Show("khong tim thay xe trong csdl", "khoi phuc", MessageBoxButtons.OK);
            }
        }

        private void dgvMotorcycles_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var list = context.Xes.ToList();
                DataGridViewRow row = new DataGridViewRow();
                row = dgvMotorcycles.Rows[e.RowIndex];
                txtMaXe.Text = row.Cells[0].Value.ToString();
                txtNameMotor.Text = row.Cells[1].Value.ToString();
                cmbColor.Text = row.Cells[2].Value.ToString();
                txtQuantity.Text = row.Cells[3].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString();

                var find = list.FirstOrDefault(p => p.MaXe.Trim() == txtMaXe.Text);
                txtDisplacement.Text = find.PhanKhoi.ToString();
                txtLoai.Text = find.LoaiXe.ToString();
                cmbCompany.Text = find.HangXe.TenHang;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
