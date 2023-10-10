namespace Project_QLBanXeMay.models
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
        public int MaCTPX { get; set; }

        [StringLength(50)]
        public string MaPX { get; set; }

        [StringLength(50)]
        public string MaXe { get; set; }

        [StringLength(50)]
        public string SoKhung { get; set; }

        [StringLength(50)]
        public string SoMay { get; set; }

        public double? DonGia { get; set; }

        public virtual PhieuXuat PhieuXuat { get; set; }

        public virtual Xe Xe { get; set; }
    }
}
