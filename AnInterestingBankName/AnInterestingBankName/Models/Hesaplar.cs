namespace AnInterestingBankName.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hesaplar")]
    public partial class Hesaplar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hesaplar()
        {
            Kartlar = new HashSet<Kartlar>();
        }

        public int ID { get; set; }

        public int? Musteri_ID { get; set; }

        [StringLength(50)]
        public string IBAN { get; set; }

        public decimal? Bakiye { get; set; }

        public bool? IsActive { get; set; }

        public virtual Musteriler Musteriler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kartlar> Kartlar { get; set; }
    }
}
