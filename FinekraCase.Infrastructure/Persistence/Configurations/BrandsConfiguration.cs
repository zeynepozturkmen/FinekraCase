using FinekraCase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinekraCase.Infrastructure.Persistence.Configurations
{
    public class BrandsConfiguration : IEntityTypeConfiguration<Brands>
    {
        public void Configure(EntityTypeBuilder<Brands> builder)
        {
            builder.Property(b => b.BrandName).IsRequired().HasMaxLength(150);
            builder.Property(b => b.Description).HasMaxLength(300);


            builder
            .HasMany(b => b.Perfumes)
            .WithOne(b => b.Brand)
            .HasForeignKey(s => s.BrandId)
            .IsRequired();

        }
    }
}