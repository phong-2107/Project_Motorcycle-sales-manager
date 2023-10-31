using Project_QLBanXeMay.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Project_QLBanXeMay
{
    public partial class HoaDon : Form
    {

        Model1 context = new Model1();
        List<ChiTietPhieuXuat> list = new List<ChiTietPhieuXuat>();
        List<ChiTietXe> CTX = new List<ChiTietXe>();
        private NhanVien dn = new NhanVien();
        public NhanVien Dn { get => dn; set => dn = value; }
        int dem = 0;

        public HoaDon()
        {
            InitializeComponent();
            DisplayNgayXuat();
        }
        #region giaoDien

        private void HoaDon_Load(object sender, EventArgs e)
        {
            Model1 context1 = new Model1();
            StyleDatagridview(dgvMotorcycles);
            StyleDatagridview(dgvCTX);
            lbStaff.Text = Dn.TenNV.ToString();
            FillHangXe(context1.HangXes.ToList());
            FillPTTT(context1.PhuongThucTTs.ToList());
            restart();
            reset();
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
            foreach (Xe i in list)
            {
                if (i.HoatDong == 1)
                {
                    cmbMaXe.Items.Add(i.MaXe);
                }
            }

        }
        private void FillHangXe(List<HangXe> list)
        {
            this.cmbHangXe.DataSource = list;
            this.cmbHangXe.DisplayMember = "TenHang";
            this.cmbHangXe.ValueMember = "MaHang";
            cmbHangXe.SelectedIndex = 0;
        }
        private void FillPTTT(List<PhuongThucTT> list)
        {
            this.cmbThanhToan.DataSource = list;
            this.cmbThanhToan.DisplayMember = "PTTilte";
            this.cmbThanhToan.ValueMember = "PTThanhToanID";
        }
        private void cmbHangXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            var find = context.HangXes.FirstOrDefault(p => p.TenHang == cmbHangXe.Text.Trim());
            if (find != null)
            {
                cmbMaXe.Items.Clear();
                List<Xe> listXe = new List<Xe>();
                listXe = context.Xes.Where(p => p.MaHang == find.MaHang).ToList();
                if (listXe.Count != 0)
                {
                    FillXe(listXe);
                }
                else
                {
                    MessageBox.Show("Chưa có Xe trong hang");
                }

                cmbMaXe.Enabled = true;
            }
            restart();
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
                            PhieuXuat px = new PhieuXuat();
                            px.MaPX = txtPX.Text.Trim();
                            px.MaNV = Dn.MaNV;
                            px.MaKH = find.MaKH;
                            px.NgayXuat = DateTime.Today;
                            px.TongThanhTien = double.Parse(lbsumCost.Text.Trim());
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

                            foreach (var i in CTX)
                            {
                                i.Active = true;
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
                            kh.HoatDong = 1;
                            context.KhachHangs.Add(kh);
                            context.SaveChanges();


                            PhieuXuat px = new PhieuXuat();
                            px.MaPX = txtPX.Text.Trim();
                            px.MaNV = Dn.MaNV;
                            px.MaKH = txtID.Text.Trim();
                            px.NgayXuat = DateTime.Today;
                            px.TongThanhTien = double.Parse(lbsumCost.Text.Trim());
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

                            foreach (var i in CTX)
                            {
                                i.Active = true;
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

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFullName.Focus();
                e.Handled = true;
            }
        }

        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDT.Focus();
                e.Handled = true;
            }
        }

        private void txtDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMail.Focus();
                e.Handled = true;
            }
        }

        private void txtMail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtAdd.Focus();
                e.Handled = true;
            }
        }

        private void TxtAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPX.Focus();
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            reset();
            //restart();

        }
        #endregion 
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Model1 context = new Model1();
                var listKHHD = context.KhachHangs.Where(p => p.HoatDong == 1).ToList();
                var Search = listKHHD.FirstOrDefault(x =>
                                        (x.MaKH.Trim().ToLower().Contains(txtSearch.Text.Trim().ToLower()))
                                        || (x.DienThoai.Contains(txtSearch.Text.Trim()))
                                        || (x.Email.Contains(txtSearch.Text.Trim())));

                if (Search != null)
                {
                    txtID.Text = Search.MaKH;
                    txtFullName.Text = Search.TenKH;
                    txtDT.Text = Search.DienThoai;
                    txtMail.Text = Search.Email;
                    TxtAdd.Text = Search.DiaChi;
                }
                else
                {

                    DialogResult res = MessageBox.Show("Khách Hàng Không tồn tại hoặc nhập sai cú pháp, Thêm mới?", "Confirmation", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        btnAddNew_Click(sender, e);

                    }
                }
            }
        }

        private void dgvMotorcycles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = new DataGridViewRow();

                row = dgvMotorcycles.Rows[e.RowIndex];
                cmbMaXe.Text = row.Cells[0].Value.ToString();
                var name = row.Cells[0].Value.ToString();
                var findXe = context.Xes.FirstOrDefault(p => p.TenXe == name);
                cmbHangXe.Text = findXe.HangXe.TenHang;
                if (findXe != null)
                {
                    txtTenXe.Text = findXe.TenXe;
                    txtColor.Text = findXe.MauXe.MaMau;
                    txtQuantity.Text = row.Cells[1].Value.ToString();
                    var findCTX = CTX.Where(p => p.MaXe == findXe.MaXe).ToList();
                    BindGridCTX(findCTX);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        int sl = 0;

        private void checkSl(Xe find ,int sl) {
            if (sl <= find.SoLuong)
            {
                var listCTX = context.ChiTietXes.Where(p => (p.MaXe == cmbMaXe.Text.Trim()) && (p.Active == false)).ToList();

                string selectedModel = cmbMaXe.Text.Trim();
                int numberOfXeToAdd = sl;

                var xeList = context.ChiTietXes
                    .Where(x => x.MaXe == selectedModel && x.Active == false)
                    .OrderBy(x => x.SoKhung)
                    .Take(numberOfXeToAdd)
                    .ToList();
                foreach (var xe in xeList)
                {

                    var findSK = CTX.FirstOrDefault(p => p.SoKhung == xe.SoKhung);
                    if (findSK == null)
                    {
                        dgvCTX.Rows.Add(xe.SoKhung, xe.SoMay);
                        CTX.Add(xe);
                    }
                }
            }
            else
            {
                MessageBox.Show("Số xe không đủ ");
            }
        }

        private void btnAddXe_Click(object sender, EventArgs e)
        {
            try
            {
                
                var find = context.Xes.FirstOrDefault(p => p.MaXe == cmbMaXe.Text.Trim());
                var findTT = list.FirstOrDefault(p => p.MaXe == cmbMaXe.Text);
                
                if (find != null)
                {
                    if (list.Count() == 0)
                    {
                        ChiTietPhieuXuat ct = new ChiTietPhieuXuat();
                        ct.MaPX = txtPX.Text.Trim();
                        ct.MaXe = cmbMaXe.Text.Trim();
                        ct.SoLuong = int.Parse(txtQuantity.Text.Trim());
                        list.Add(ct);
                    }
                    else
                    {
                        var findMa = list.FirstOrDefault(p => p.MaXe == cmbMaXe.Text);
                        if (findTT != null)
                        {
                            findMa.SoLuong += sl;
                        }
                        else
                        {
                            ChiTietPhieuXuat ct = new ChiTietPhieuXuat();
                            ct.MaPX = txtPX.Text.Trim();
                            ct.MaXe = cmbMaXe.Text.Trim();
                            ct.SoLuong = int.Parse(txtQuantity.Text.Trim());
                            list.Add(ct);
                        }
                    }



                    if (dgvCTX.Rows.Count ==0)
                    {
                        sl = int.Parse(txtQuantity.Text.Trim());
                        checkSl(find, sl);

                    }
                   else if ( dgvCTX.Rows.Count != null)
                    {
                        
                        var tmp = int.Parse(txtQuantity.Text.Trim());
                        sl += tmp;
                        checkSl(find, sl);
                    }
                }

                else
                {
                    var ctx = context.ChiTietXes.Where(p => p.MaXe == cmbMaXe.Text).ToList();
                    if (ctx.Count != 0)
                    {
                        MessageBox.Show("Loại Xe Hiện Không Còn Hàng");
                        restart();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            /*
            if (list.Count() == 0)
            {
                ChiTietPhieuXuat ct = new ChiTietPhieuXuat();
                ct.MaPX = txtPX.Text.Trim();
                ct.MaXe = cmbMaXe.Text.Trim();
                ct.SoLuong = sl;
                list.Add(ct);
                BindGrid(list);


                BindGrid(list);
                restart();
            }
            else
            {
                var findTT = list.FirstOrDefault(p => p.MaXe == cmbMaXe.Text);
                if (findTT != null)
                {
                    findTT.SoLuong += sl;
                    BindGrid(list);
                    restart();
                }
            }
            */
            if(list.Count != 0)
            {
                BindGrid(list);
                sl = 0;
            }

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtFullName.ReadOnly = false;
            txtDT.ReadOnly = false;
            txtMail.ReadOnly = false;
            TxtAdd.ReadOnly = false;
            var lastRow = context.KhachHangs.OrderByDescending(x => x.MaKH).FirstOrDefault();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
        private void restart()
        {
            dgvCTX.Rows.Clear();
            txtTenXe.Text = "";
            txtColor.Text = "";
            txtQuantity.Text = "";
            cmbMaXe.Text = "";
            sl = 0;
        }

        private void BindGridCTX(List<ChiTietXe> list)
        {
            dgvCTX.Rows.Clear();
            
            foreach (var x in list)
            {
                int index = dgvCTX.Rows.Add();
                var find = context.Xes.FirstOrDefault(p => p.MaXe == x.MaXe);
                dgvCTX.Rows[index].Cells[0].Value = x.SoKhung;
                dgvCTX.Rows[index].Cells[1].Value = x.SoMay;
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
            else if (txtQuantity.Text.Trim() == "")
            {
                btnAddXe.Visible = false;
            }
        }

        private void reset()
        {
            txtID.Text = "";
            txtFullName.Text = "";
            txtDT.Text = "";
            txtMail.Text = "";
            TxtAdd.Text = "";
            cmbMaXe.Text = "";
            txtTenXe.Text = "";
            txtColor.Text = "";
            txtQuantity.Text = string.Empty;
            dgvMotorcycles.Rows.Clear();
            lbsumCost.Text = "...$";
            dgvCTX.Rows.Clear();
            sl = 0;
            list.Clear();
            CTX.Clear();
            
        }


        
    }
    /*
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new YourDbContext()) // Thay thế YourDbContext bằng tên của lớp DbContext của bạn
            {
                // Lưu thay đổi vào cơ sở dữ liệu
                context.SaveChanges();
            }
        }

       */

    
}
