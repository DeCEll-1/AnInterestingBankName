namespace AnInterestingBankName.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kartlar")]
    public partial class Kartlar
    {
        public int ID { get; set; }

        public int? Hesap_ID { get; set; }

        [StringLength(16)]
        public string KartNo { get; set; }

        [StringLength(2)]
        public string SonKullanmaAy { get; set; }

        [StringLength(2)]
        public string SonKullanmaYil { get; set; }

        [StringLength(4)]
        public string CVCKodu { get; set; }

        public virtual Hesaplar Hesaplar { get; set; }
    }
}
