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
    public partial class HoaDon : Form
    {

        Model1 context = new Model1();
        List<ChiTietPhieuXuat> list = new List<ChiTietPhieuXuat>();


        public HoaDon()
        {
            InitializeComponent();
            DisplayNgayXuat();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            StyleDatagridview(dgvMotorcycles);

            FillXe(context.Xes.ToList());
            FillNV(context.NhanViens.ToList());
            FillPTTT(context.PhuongThucTTs.ToList());
            FillKhuyenMai(context.PX_GiamGiaKhuyenMai.ToList());

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

        private void DisplayNgayXuat()
        {
            lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void FillXe(List<Xe> list)
        {
            list.Insert(0, new Xe());
            this.cmbMaXe.DataSource = list;
            this.cmbMaXe.DisplayMember = "MaXe";
            this.cmbMaXe.ValueMember = "MaXe";

        }

        private void FillNV(List<NhanVien> list)
        {
            list.Insert(0, new NhanVien());
            this.cmbStaff.DataSource = list;
            this.cmbStaff.DisplayMember = "TenNV";
            this.cmbStaff.ValueMember = "MaNV";

        }

        private void FillPTTT(List<PhuongThucTT> list)
        {
            this.cmbThanhToan.DataSource = list;
            this.cmbThanhToan.DisplayMember = "PTTilte";
            this.cmbThanhToan.ValueMember = "PTThanhToanID";
        }

        private void FillKhuyenMai(List<PX_GiamGiaKhuyenMai> list)
        {
            this.cmbMaGG.DataSource = list;
            this.cmbMaGG.DisplayMember = "Promotilte";
            this.cmbMaGG.ValueMember = "PromoID";
        }

        private void cmbMaXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            var find = context.Xes.FirstOrDefault(p => p.MaXe == cmbMaXe.Text.Trim());
            if (find != null)
            {
                txtTenXe.Text = find.TenXe.ToString();
                txtColor.Text = find.MauXe.TenMau.ToString();
            }
        }

        private void btnAddXe_Click_1(object sender, EventArgs e)
        {
            try
            {
                ChiTietPhieuXuat x = new ChiTietPhieuXuat();
                var find = list.FirstOrDefault(p => p.MaXe == cmbMaXe.Text);
                if (find != null)
                {
                    find.SoLuong += int.Parse(txtQuantity.Text);
                }
                else
                {
                    PhieuXuat px = new PhieuXuat();

                    x.MaXe = cmbMaXe.Text;
                    x.MaPX = "tmp";
                    x.SoLuong = int.Parse(txtQuantity.Text);
                    list.Add(x);
                }

                BindGrid(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<ChiTietPhieuXuat> list)
        {
            double? sum = 0;
            dgvMotorcycles.Rows.Clear();
            foreach (var x in list)
            {
                int index = dgvMotorcycles.Rows.Add();
                var find = context.Xes.FirstOrDefault(p => p.MaXe == x.MaXe);
                dgvMotorcycles.Rows[index].Cells[0].Value = find.TenXe;
                
                dgvMotorcycles.Rows[index].Cells[1].Value = x.SoLuong;
                var tmp = find.DonGia * x.SoLuong;
                sum += tmp;
                dgvMotorcycles.Rows[index].Cells[2].Value = tmp;
            }
            lbsumCost.Text = sum.ToString();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text != null)
            {
                btnAddXe.Visible = true;
            }
        }

        private void reset()
        {
            txtID.Text = "";
            txtFullName.Text = "";
            txtDT.Text = "";
            txtMail.Text = "";
            TxtAdd.Text = "";
            cmbStaff.Text = "";
            cmbMaXe.Text = "";
            txtQuantity.Text = string.Empty;
            dgvMotorcycles.Rows.Clear();
            lbsumCost.Text = "...$";
        }

        private double? tinhTien(string m, string ID)
        {
            double? sum = 0;
            if (string.IsNullOrEmpty(m)) { return 0; }
            else
            {
                if(ID.Equals("PR001") == true)
                {
                    sum = double.Parse(m) - (double.Parse(m)*0.03);
                }
                else if(ID.Equals("PR002") == true)
                {
                    sum = double.Parse(m) - (double.Parse(m) * 0.15);
                }
                else if (ID.Equals("PR003") == true)
                {
                    sum = double.Parse(m) - (double.Parse(m) * 0.5);
                }
            }
            return sum;
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtFullName.Text == "" || txtMail.Text == "" || cmbThanhToan.Text == "")
            {
                MessageBox.Show("Ban phai nhap day du thong tin");
            }
            else
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var find = context.KhachHangs.FirstOrDefault(p => p.MaKH == txtID.Text);
                        if (find != null)
                        {
                            var findNV = context.NhanViens.FirstOrDefault(p => p.TenNV == cmbStaff.Text.Trim());
                            var findPM = context.PX_GiamGiaKhuyenMai.FirstOrDefault(p => p.Promotilte == cmbMaGG.Text.Trim());
                            PhieuXuat px = new PhieuXuat();
                            px.MaNV = findNV.MaNV;
                            px.MaKH = find.MaKH;
                            px.NgayXuat = DateTime.Parse(lbDate.Text);
                            px.TongThanhTien = tinhTien(lbsumCost.Text, findPM.PromoID);
                            px.PromoID = findPM.PromoID;
                            context.PhieuXuats.Add(px);
                            context.SaveChanges();

                            foreach (var i in list)
                            {
                                ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat();
                                ctpx.MaPX = px.MaPX;
                                ctpx.MaXe = i.MaXe;
                                ctpx.SoLuong = i.SoLuong;
                                context.ChiTietPhieuXuats.Add(ctpx);
                                context.SaveChanges();
                            }

                            foreach (var x in list)
                            {
                                var xe = context.Xes.FirstOrDefault(p => p.MaXe == x.MaXe);
                                if (xe != null)
                                {
                                    xe.SoLuong = xe.SoLuong.Value - x.SoLuong.Value;
                                    context.SaveChanges();
                                }
                            }

                        }
                        else
                        {
                            KhachHang kh = new KhachHang();
                            kh.MaKH = txtID.Text;
                            kh.TenKH = txtFullName.Text;
                            kh.Email = txtMail.Text;
                            kh.DienThoai = txtDT.Text;
                            kh.DiaChi = TxtAdd.Text;
                            context.KhachHangs.Add(kh);
                            context.SaveChanges();

                            var findNV = context.NhanViens.FirstOrDefault(p => p.TenNV == cmbStaff.Text.Trim());
                            var findPM = context.PX_GiamGiaKhuyenMai.FirstOrDefault(p => p.Promotilte == cmbMaGG.Text.Trim());
                            PhieuXuat px = new PhieuXuat();
                            px.MaNV = findNV.MaNV;
                            px.MaKH = txtID.Text;
                            px.NgayXuat = DateTime.Today;
                            px.TongThanhTien = tinhTien(lbsumCost.Text, findPM.PromoID);
                            px.PromoID = findPM.PromoID;
                            context.PhieuXuats.Add(px);
                            context.SaveChanges();

                            foreach (var i in list)
                            {
                                ChiTietPhieuXuat ctpx = new ChiTietPhieuXuat();
                                ctpx.MaPX = px.MaPX;
                                ctpx.MaXe = i.MaXe;
                                ctpx.SoLuong = i.SoLuong;
                                context.ChiTietPhieuXuats.Add(ctpx);
                                context.SaveChanges();
                            }
                            foreach (var x in list)
                            {
                                var xe = context.Xes.FirstOrDefault(p => p.MaXe == x.MaXe);
                                if (xe != null)
                                {
                                    xe.SoLuong = xe.SoLuong.Value - x.SoLuong.Value;
                                    context.SaveChanges();
                                }
                            }
                        }
                        transaction.Commit();
                        MessageBox.Show("Them Thanh Cong");
                        reset();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        transaction.Rollback();
                    }
                }
            }
        }

        
    }
}
