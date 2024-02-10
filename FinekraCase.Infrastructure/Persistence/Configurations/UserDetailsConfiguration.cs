using FinekraCase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinekraCase.Infrastructure.Persistence.Configurations
{
    public class UserDetailsConfiguration : IEntityTypeConfiguration<UserDetails>
    {
        public void Configure(EntityTypeBuilder<UserDetails> builder)
        {
            builder.Property(b => b.UserName).IsRequired().HasMaxLength(100);
            builder.Property(b => b.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(b => b.LastName).HasMaxLength(100);
            builder.Property(b => b.Email).HasMaxLength(200);
            builder.Property(b => b.Phone).HasMaxLength(15);


            builder
            .HasMany(b => b.Orders)
            .WithOne(b => b.UserDetail)
            .HasForeignKey(s => s.UserDetailId)
            .IsRequired();

            builder
            .HasMany(b => b.Baskets)
            .WithOne(b => b.UserDetail)
            .HasForeignKey(s => s.UserDetailId)
            .IsRequired();

        }
    }
}