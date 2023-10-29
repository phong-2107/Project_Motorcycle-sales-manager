namespace Project_QLBanXeMay.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuXuat")]
    public partial class ChiTietPhieuXuat
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaPX { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaXe { get; set; }

        public int? SoLuong { get; set; }

        public virtual PhieuXuat PhieuXuat { get; set; }

        public virtual Xe Xe { get; set; }
    }
}
