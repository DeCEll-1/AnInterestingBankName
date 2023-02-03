namespace AnInterestingBankName.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanalPosMusteriler")]
    public partial class SanalPosMusteriler
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string FirmaAdi { get; set; }

        [StringLength(12)]
        public string SaticiKodu { get; set; }

        [StringLength(10)]
        public string Sifre { get; set; }

        public bool? IsActive { get; set; }
    }
}
