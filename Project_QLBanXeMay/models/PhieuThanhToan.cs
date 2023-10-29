namespace Project_QLBanXeMay.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuThanhToan")]
    public partial class PhieuThanhToan
    {
        [Key]
        [StringLength(50)]
        public string MaTT { get; set; }

        [StringLength(50)]
        public string MaPX { get; set; }

        public double? TongThanhTien { get; set; }

        public double? TienDaThu { get; set; }

        public double? TienConThieu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThu { get; set; }

        [StringLength(10)]
        public string PTThanhToanID { get; set; }

        public virtual PhieuXuat PhieuXuat { get; set; }

        public virtual PhuongThucTT PhuongThucTT { get; set; }
    }
}
