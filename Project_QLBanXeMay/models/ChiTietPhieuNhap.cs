namespace Project_QLBanXeMay.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuNhap")]
    public partial class ChiTietPhieuNhap
    {
        [Key]
        public int MaCTPN { get; set; }

        [StringLength(50)]
        public string MaPN { get; set; }

        [StringLength(50)]
        public string MaXe { get; set; }

        public int? SoLuong { get; set; }

        public double? DonGia { get; set; }

        public double? ThanhTien { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; }

        public virtual Xe Xe { get; set; }
    }
}
