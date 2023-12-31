using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Project_QLBanXeMay.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public virtual DbSet<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
        public virtual DbSet<ChiTietXe> ChiTietXes { get; set; }
        public virtual DbSet<DangNhap> DangNhaps { get; set; }
        public virtual DbSet<HangXe> HangXes { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<MauXe> MauXes { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhanCong> PhanCongs { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<PhieuThanhToan> PhieuThanhToans { get; set; }
        public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }
        public virtual DbSet<PhuongThucTT> PhuongThucTTs { get; set; }
        public virtual DbSet<PX_GiamGiaKhuyenMai> PX_GiamGiaKhuyenMai { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Xe> Xes { get; set; }
        public virtual DbSet<XeDaXoa> XeDaXoas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhanCong>()
                .HasMany(e => e.NhanViens)
                .WithOptional(e => e.PhanCong)
                .HasForeignKey(e => e.ChucVu);

            modelBuilder.Entity<PhieuNhap>()
                .HasMany(e => e.ChiTietPhieuNhaps)
                .WithRequired(e => e.PhieuNhap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuThanhToan>()
                .Property(e => e.PTThanhToanID)
                .IsFixedLength();

            modelBuilder.Entity<PhieuXuat>()
                .HasMany(e => e.ChiTietPhieuXuats)
                .WithRequired(e => e.PhieuXuat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhuongThucTT>()
                .Property(e => e.PTThanhToanID)
                .IsFixedLength();

            modelBuilder.Entity<Xe>()
                .HasMany(e => e.ChiTietPhieuNhaps)
                .WithRequired(e => e.Xe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Xe>()
                .HasMany(e => e.ChiTietPhieuXuats)
                .WithRequired(e => e.Xe)
                .WillCascadeOnDelete(false);
        }
    }
}
