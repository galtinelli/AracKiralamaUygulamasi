using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_Identity.Models.Entities;

namespace MVC_Identity.Data.Mappings
{
    public class ModelMapping : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> modelBuilder)
        {
            modelBuilder.HasKey(x => x.ModelId);
            modelBuilder.Property(x => x.ModelAdi).IsRequired().HasMaxLength(20);
        }
    }
}
