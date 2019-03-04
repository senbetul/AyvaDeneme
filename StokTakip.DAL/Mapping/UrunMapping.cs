using StokTakip.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DAL.Mapping
{
    class UrunMapping : EntityTypeConfiguration<Urun>
    {
        public UrunMapping()
        {
            ToTable("Urunler");
            Property(u=>u.UrunAdi).HasColumnType("varchar").HasMaxLength(40).IsRequired();

            Property(u => u.UrunFiyati).HasColumnType("money");

            //relationShip
            HasRequired(u => u.Kategori).WithMany(k => k.Urunler).HasForeignKey(u => u.KategoriId);
            HasMany(u => u.Tedarikciler).WithMany(t => t.Urunler).Map(m =>
                {
                    m.ToTable("UrunTedarikci_Islem");
                    m.MapLeftKey("UrunId");
                    m.MapRightKey("TesarikciId");
                });
        }
    }
 
}
