namespace Project_QLBanXeMay.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xe")]
    public partial class Xe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Xe()
        {
            ChiTietPhieuNhaps = new HashSet<ChiTietPhieuNhap>();
            ChiTietPhieuXuats = new HashSet<ChiTietPhieuXuat>();
            ChiTietXes = new HashSet<ChiTietXe>();
        }

        [Key]
        [StringLength(50)]
        public string MaXe { get; set; }

        [Required]
        [StringLength(50)]
        public string TenXe { get; set; }

        [Required]
        [StringLength(50)]
        public string MauSac { get; set; }

        public int SoLuongTong { get; set; }

        public double DonGia { get; set; }

        public int PhanKhoi { get; set; }

        [Required]
        [StringLength(50)]
        public string LoaiXe { get; set; }

        [StringLength(50)]
        public string AnhXe { get; set; }

        [Required]
        [StringLength(50)]
        public string HangXe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietXe> ChiTietXes { get; set; }
    }
}
