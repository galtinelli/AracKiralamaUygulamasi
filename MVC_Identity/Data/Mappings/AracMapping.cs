using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Identity.Models.Entities;

namespace MVC_Identity.Data.Mappings
{
    public class AracMapping : IEntityTypeConfiguration<Arac>
    {
        public void Configure(EntityTypeBuilder<Arac> aracBuilder)
        {
            aracBuilder.HasKey(x => x.AracSaseNo);
            aracBuilder.Property(x => x.AracSaseNo).HasMaxLength(17);
            aracBuilder.Property(x => x.SunRoofDurumu).IsRequired();
            aracBuilder.Property(x => x.OtomatikKlimaDurumu).IsRequired();
            aracBuilder.Property(x => x.UretimYili).IsRequired();

            aracBuilder.HasOne(x => x.Renk).WithMany(x => x.Araclar).HasForeignKey(x => x.RenkId);

            aracBuilder.HasOne(x => x.Marka).WithMany(x => x.Araclar).HasForeignKey(x => x.MarkaKisaltmasi);

            aracBuilder.HasOne(x => x.Model).WithMany(x => x.Araclar).HasForeignKey(x => x.ModelId);

            aracBuilder.HasOne(x => x.ModelPaket).WithMany(x => x.Araclar).HasForeignKey(x => x.ModelPaketId);
        }
    }
}
