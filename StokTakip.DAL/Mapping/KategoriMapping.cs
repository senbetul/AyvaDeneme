using StokTakip.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DAL.Mapping
{
    class KategoriMapping:EntityTypeConfiguration<Kategori>
    {
        public KategoriMapping()
        {
            ToTable("Kategoriler");
            Property(k => k.Aciklama).HasColumnType("varchar").HasMaxLength(50);

            Property(k => k.KategoriAdi).HasColumnType("varchar").HasMaxLength(30).IsRequired();
        }


    }
}
