namespace Project_QLBanXeMay.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietXe")]
    public partial class ChiTietXe
    {
        [Key]
        public int MaCT { get; set; }

        [StringLength(50)]
        public string MaXe { get; set; }

        [StringLength(50)]
        public string SoKhung { get; set; }

        [StringLength(50)]
        public string SoMay { get; set; }

        public bool? Active { get; set; }

        [StringLength(50)]
        public string MaPN { get; set; }

        [StringLength(50)]
        public string MaPX { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; }

        public virtual PhieuXuat PhieuXuat { get; set; }

        public virtual Xe Xe { get; set; }
    }
}
