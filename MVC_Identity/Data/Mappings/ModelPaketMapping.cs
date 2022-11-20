using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Identity.Models.Entities;

namespace MVC_Identity.Data.Mappings
{
    public class ModelPaketMapping : IEntityTypeConfiguration<ModelPaket>
    {
        public void Configure(EntityTypeBuilder<ModelPaket> modelPaketBuilder)
        {
            modelPaketBuilder.HasKey(x => x.ModelPaketId);
            modelPaketBuilder.Property(x => x.PaketAdi).IsRequired().HasMaxLength(10);
        }

    }
}
