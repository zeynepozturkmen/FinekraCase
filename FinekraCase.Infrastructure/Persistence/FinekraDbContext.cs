using FinekraCase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Reflection;

namespace FinekraCase.Infrastructure.Persistence
{
    public class FinekraDbContext : DbContext
    {
        public FinekraDbContext(DbContextOptions<FinekraDbContext> options) : base(options)
        {

        }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<Perfumes> Perfumes { get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Baskets> Baskets { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ConvertEnumColumnsToString(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<UserDetails>().HasData(
             new UserDetails { Id = Guid.NewGuid(), UserName = "Finekra", FirstName = "Finekra", LastName = "Finekra", Phone = "850 803 31 92", Email = "info@polynomtech.com", CreateDate = DateTime.Now, CreatedBy = "Finekra", RecordStatus = Domain.Enums.RecordStatus.Active });

            modelBuilder.Entity<Brands>().HasData(
            new Brands { Id = Guid.Parse("dc695b3f-ee79-4fca-82c2-b5330765ee26"), BrandName = "Chanel", Description = "Test Description", CreateDate = DateTime.Now, CreatedBy = "Finekra" ,RecordStatus = Domain.Enums.RecordStatus.Active },
            new Brands { Id = Guid.Parse("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"), BrandName = "Avon", Description = "Test Description", CreateDate = DateTime.Now, CreatedBy = "Finekra", RecordStatus = Domain.Enums.RecordStatus.Active }
           );


            modelBuilder.Entity<Perfumes>().HasData(
            new Perfumes { Id = Guid.NewGuid(), BrandId = Guid.Parse("dc695b3f-ee79-4fca-82c2-b5330765ee26"), PerfumeName = "Mademoiselle Kadın Parfüm EDP 50 ml", Price = 500.00m, CreateDate = DateTime.Now, CreatedBy = "Finekra", RecordStatus = Domain.Enums.RecordStatus.Active },
            new Perfumes { Id = Guid.NewGuid(), BrandId = Guid.Parse("dc695b3f-ee79-4fca-82c2-b5330765ee26"), PerfumeName = "Chance Kadın Parfüm EDP 50 ml", Price = 600.00m, CreateDate = DateTime.Now, CreatedBy = "Finekra", RecordStatus = Domain.Enums.RecordStatus.Active },
            new Perfumes { Id = Guid.NewGuid(), BrandId = Guid.Parse("dc695b3f-ee79-4fca-82c2-b5330765ee26"), PerfumeName = "Allure Kadın Parfüm EDP 50 ml", Price = 700.00m, CreateDate = DateTime.Now, CreatedBy = "Finekra", RecordStatus = Domain.Enums.RecordStatus.Active },
            new Perfumes { Id = Guid.NewGuid(), BrandId = Guid.Parse("dc695b3f-ee79-4fca-82c2-b5330765ee26"), PerfumeName = "Gabrielle Kadın Parfüm EDP 50 ml", Price = 800.00m, CreateDate = DateTime.Now, CreatedBy = "Finekra", RecordStatus = Domain.Enums.RecordStatus.Active },
            new Perfumes { Id = Guid.NewGuid(), BrandId = Guid.Parse("dc695b3f-ee79-4fca-82c2-b5330765ee26"), PerfumeName = "Sensuelle Kadın Parfüm EDP 50 ml", Price = 900.00m, CreateDate = DateTime.Now, CreatedBy = "Finekra", RecordStatus = Domain.Enums.RecordStatus.Active },

            new Perfumes { Id = Guid.NewGuid(), BrandId = Guid.Parse("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"), PerfumeName = "Beyond Kadın Parfüm EDP 50 ml", Price = 350.00m, CreateDate = DateTime.Now, CreatedBy = "Finekra", RecordStatus = Domain.Enums.RecordStatus.Active },
            new Perfumes { Id = Guid.NewGuid(), BrandId = Guid.Parse("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"), PerfumeName = "Wish Of Love Kadın Parfüm EDP 50 ml", Price = 200.00m, CreateDate = DateTime.Now, CreatedBy = "Finekra", RecordStatus = Domain.Enums.RecordStatus.Active },
            new Perfumes { Id = Guid.NewGuid(), BrandId = Guid.Parse("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"), PerfumeName = "Maxime Icon 75 ml", Price = 300.00m, CreateDate = DateTime.Now, CreatedBy = "Finekra", RecordStatus = Domain.Enums.RecordStatus.Active },
            new Perfumes { Id = Guid.NewGuid(), BrandId = Guid.Parse("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"), PerfumeName = "Incandessence Kadın Parfüm EDP 50 ml", Price = 400.00m, CreateDate = DateTime.Now, CreatedBy = "Finekra", RecordStatus = Domain.Enums.RecordStatus.Active },
            new Perfumes { Id = Guid.NewGuid(), BrandId = Guid.Parse("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"), PerfumeName = "Attraction Desire Kadın Parfüm EDP 50 ml", Price = 600.00m, CreateDate = DateTime.Now, CreatedBy = "Finekra", RecordStatus = Domain.Enums.RecordStatus.Active }
            );
        }

        private static void ConvertEnumColumnsToString(ModelBuilder modelBuilder)
        {
            foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (IMutableProperty property in entityType.GetProperties())
                {
                    if (property.ClrType.IsEnum)
                    {
                        ValueConverter valueConverter = Activator.CreateInstance(typeof(EnumToStringConverter<>).MakeGenericType(property.ClrType), new ConverterMappingHints()) as ValueConverter;
                        property.SetValueConverter(valueConverter);
                        property.SetMaxLength(50);
                    }
                }
            }
        }
    }
}
