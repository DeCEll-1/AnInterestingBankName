using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AnInterestingBankName.Models
{
    public partial class AnInterestingBankName_Model : DbContext
    {
        public AnInterestingBankName_Model()
            : base("name=AnInterestingBankName_Model")
        {
        }

        public virtual DbSet<Hesaplar> Hesaplar { get; set; }
        public virtual DbSet<Kartlar> Kartlar { get; set; }
        public virtual DbSet<Musteriler> Musteriler { get; set; }
        public virtual DbSet<SanalPosMusteriler> SanalPosMusteriler { get; set; }
        public virtual DbSet<Logs> Logs{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hesaplar>()
                .HasMany(e => e.Kartlar)
                .WithOptional(e => e.Hesaplar)
                .HasForeignKey(e => e.Hesap_ID);

            modelBuilder.Entity<Musteriler>()
                .HasMany(e => e.Hesaplar)
                .WithOptional(e => e.Musteriler)
                .HasForeignKey(e => e.Musteri_ID);
        }
    }
}
