namespace Project_QLBanXeMay.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhuongThucTT")]
    public partial class PhuongThucTT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhuongThucTT()
        {
            PhieuThanhToans = new HashSet<PhieuThanhToan>();
        }

        [Key]
        [StringLength(10)]
        public string PTThanhToanID { get; set; }

        [StringLength(30)]
        public string PTTilte { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuThanhToan> PhieuThanhToans { get; set; }
    }
}
