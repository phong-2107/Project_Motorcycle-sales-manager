namespace Project_QLBanXeMay.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HangXe")]
    public partial class HangXe
    {
        [Key]
        [StringLength(50)]
        public string MaHang { get; set; }

        [StringLength(50)]
        public string TenHang { get; set; }
    }
}
