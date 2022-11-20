using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Identity.Models.Entities;

namespace MVC_Identity.Data.Mappings
{
    public class MarkaMapping : IEntityTypeConfiguration<Marka>
    {
        public void Configure(EntityTypeBuilder<Marka> markaBuilder)
        {
            markaBuilder.HasKey(x => x.MarkaKisaltmasi);
            markaBuilder.Property(x => x.MarkaKisaltmasi).HasColumnType("varchar").HasMaxLength(3);
            markaBuilder.Property(x => x.MarkaAdi).IsRequired().HasMaxLength(10);
            markaBuilder.Property(x => x.LogoPath).IsRequired();
        }
    }
}
