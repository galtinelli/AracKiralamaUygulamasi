using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_Identity.Data.Mappings;
using MVC_Identity.Models.Entities;

namespace MVC_Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Arac> Aracs { get; set; }
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<ModelPaket> ModelPakets { get; set; }
        public DbSet<Renk> Renks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AracMapping());
            builder.ApplyConfiguration(new MarkaMapping());
            builder.ApplyConfiguration(new ModelMapping());
            builder.ApplyConfiguration(new ModelPaketMapping());
        }
    }
}