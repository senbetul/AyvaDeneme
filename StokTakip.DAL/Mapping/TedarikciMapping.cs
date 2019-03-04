using StokTakip.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DAL.Mapping
{
    class TedarikciMapping:EntityTypeConfiguration<Tedarikci>
    {
        public TedarikciMapping()
        {
            ToTable("Tedarikciler");
            Property(t => t.Adres).HasColumnType("varchar").HasMaxLength(300);

            Property(t => t.Eposta).HasColumnType("varchar").HasMaxLength(50);

            Property(t => t.FirmaAdi).HasColumnType("varchar").HasMaxLength(30).IsRequired();

            Property(t => t.Telefon).HasColumnType("char").HasMaxLength(10).IsFixedLength().IsRequired();

            //relationships
            //Ürünle olan ilişkisi UrunMapping class inda işlenmiştir.
        }
    }
}
