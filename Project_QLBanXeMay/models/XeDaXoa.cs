namespace Project_QLBanXeMay.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XeDaXoa")]
    public partial class XeDaXoa
    {
        [Key]
        [StringLength(10)]
        public string MaXe { get; set; }

        [StringLength(50)]
        public string TenXe { get; set; }

        [StringLength(50)]
        public string MaMau { get; set; }

        public int? SoLuong { get; set; }

        public double? DonGia { get; set; }

        [StringLength(50)]
        public string NhienLieu { get; set; }

        public int? PhanKhoi { get; set; }

        [StringLength(50)]
        public string LoaiXe { get; set; }

        [StringLength(200)]
        public string AnhXe { get; set; }

        [StringLength(50)]
        public string MaHang { get; set; }

        public DateTime ThoiGianXoa { get; set; }
    }
}
