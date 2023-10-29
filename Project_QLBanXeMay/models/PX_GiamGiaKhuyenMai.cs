namespace Project_QLBanXeMay.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PX_GiamGiaKhuyenMai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PX_GiamGiaKhuyenMai()
        {
            PhieuXuats = new HashSet<PhieuXuat>();
        }

        [Key]
        [StringLength(50)]
        public string PromoID { get; set; }

        [StringLength(50)]
        public string Promotilte { get; set; }

        [StringLength(500)]
        public string CTPromo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuXuat> PhieuXuats { get; set; }
    }
}
