using FinekraCase.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FinekraCase.Infrastructure.Persistence.Configurations
{
    public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.Property<decimal>("Price")
          .HasPrecision(18, 4)
          .HasColumnType("numeric(18,4)");

            builder
            .HasOne(s => s.Perfume)
            .WithMany()
            .HasForeignKey(s => s.PerfumeId);

            builder
            .HasOne(s => s.Order)
            .WithMany()
            .HasForeignKey(s => s.OrderId);
        }
    }
}