using FinekraCase.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FinekraCase.Infrastructure.Persistence.Configurations
{
    public class OrdersConfiguration : IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> builder)
        {
            builder.Property(b => b.ShipAddress).IsRequired().HasMaxLength(300);


            builder
            .HasMany(b => b.OrderDetails)
            .WithOne(b => b.Order)
            .HasForeignKey(s => s.OrderId)
            .IsRequired();

            builder
            .HasOne(s => s.UserDetail)
            .WithMany()
            .HasForeignKey(s => s.UserDetailId);
        }
    }
}
