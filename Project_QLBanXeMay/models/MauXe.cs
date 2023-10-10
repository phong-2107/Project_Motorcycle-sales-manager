namespace Project_QLBanXeMay.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MauXe")]
    public partial class MauXe
    {
        [Key]
        [StringLength(50)]
        public string MaMau { get; set; }

        [StringLength(50)]
        public string TenMau { get; set; }
    }
}
