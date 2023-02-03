namespace AnInterestingBankName.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Musteriler")]
    public partial class Musteriler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musteriler()
        {
            Hesaplar = new HashSet<Hesaplar>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Isim { get; set; }

        [StringLength(50)]
        public string Soyisim { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DogumTarihi { get; set; }

        public bool? IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hesaplar> Hesaplar { get; set; }
    }
}
