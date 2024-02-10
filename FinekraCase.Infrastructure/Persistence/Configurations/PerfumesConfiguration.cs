using FinekraCase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinekraCase.Infrastructure.Persistence.Configurations
{
    public class PerfumesConfiguration : IEntityTypeConfiguration<Perfumes>
    {
        public void Configure(EntityTypeBuilder<Perfumes> builder)
        {
            builder.Property(b => b.PerfumeName).IsRequired().HasMaxLength(150);
            builder.Property(b => b.PhotoPath).HasMaxLength(300);
            builder.Property<decimal>("Price")
          .HasPrecision(18, 4)
          .HasColumnType("numeric(18,4)");


            builder
            .HasMany(b => b.OrderDetails)
            .WithOne(b => b.Perfume)
            .HasForeignKey(s => s.PerfumeId)
            .IsRequired();

            builder
             .HasMany(b => b.Baskets)
             .WithOne(b => b.Perfume)
             .HasForeignKey(s => s.PerfumeId)
             .IsRequired();

            builder
            .HasOne(s => s.Brand)
            .WithMany(s => s.Perfumes)
            .HasForeignKey(s => s.BrandId);
        }
    }
}