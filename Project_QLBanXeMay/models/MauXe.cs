namespace Project_QLBanXeMay.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MauXe")]
    public partial class MauXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MauXe()
        {
            Xes = new HashSet<Xe>();
        }

        [Key]
        [StringLength(50)]
        public string MaMau { get; set; }

        [StringLength(50)]
        public string TenMau { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Xe> Xes { get; set; }
    }
}
