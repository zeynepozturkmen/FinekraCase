﻿// <auto-generated />
using System;
using FinekraCase.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinekraCase.Infrastructure.Migrations
{
    [DbContext(typeof(FinekraDbContext))]
    [Migration("20240208160116_AddedBasketTable")]
    partial class AddedBasketTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FinekraCase.Domain.Entities.Baskets", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("PerfumeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 4)
                        .HasColumnType("numeric(18,4)");

                    b.Property<string>("RecordStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserDetailId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PerfumeId");

                    b.HasIndex("UserDetailId");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("FinekraCase.Domain.Entities.Brands", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RecordStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"),
                            BrandName = "Chanel",
                            CreateDate = new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6407),
                            CreatedBy = "Finekra",
                            Description = "Test Description",
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"),
                            BrandName = "Avon",
                            CreateDate = new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6413),
                            CreatedBy = "Finekra",
                            Description = "Test Description",
                            RecordStatus = "Active"
                        });
                });

            modelBuilder.Entity("FinekraCase.Domain.Entities.OrderDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PerfumeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 4)
                        .HasColumnType("numeric(18,4)");

                    b.Property<string>("RecordStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("PerfumeId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("FinekraCase.Domain.Entities.Orders", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RecordStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserDetailId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserDetailId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FinekraCase.Domain.Entities.Perfumes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PerfumeName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PhotoPath")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 4)
                        .HasColumnType("numeric(18,4)");

                    b.Property<string>("RecordStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Perfumes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3459839c-9161-4ffd-a460-b85a1ad18b89"),
                            BrandId = new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"),
                            CreateDate = new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6447),
                            CreatedBy = "Finekra",
                            PerfumeName = "Mademoiselle Kadın Parfüm EDP 50 ml",
                            Price = 500.00m,
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("aae3314b-94ea-44ea-9f3f-ea1b6d991ec6"),
                            BrandId = new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"),
                            CreateDate = new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6451),
                            CreatedBy = "Finekra",
                            PerfumeName = "Chance Kadın Parfüm EDP 50 ml",
                            Price = 600.00m,
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("836f5167-ae29-4993-bd59-8ce26bd6e405"),
                            BrandId = new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"),
                            CreateDate = new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6455),
                            CreatedBy = "Finekra",
                            PerfumeName = "Allure Kadın Parfüm EDP 50 ml",
                            Price = 700.00m,
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("90d9ff49-d2f4-4144-a0a7-f6cd8e3f3cf7"),
                            BrandId = new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"),
                            CreateDate = new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6460),
                            CreatedBy = "Finekra",
                            PerfumeName = "Gabrielle Kadın Parfüm EDP 50 ml",
                            Price = 800.00m,
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("acc320ee-cd84-41c9-b3d4-b79fa879825f"),
                            BrandId = new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"),
                            CreateDate = new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6467),
                            CreatedBy = "Finekra",
                            PerfumeName = "Sensuelle Kadın Parfüm EDP 50 ml",
                            Price = 900.00m,
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("9cbfedc3-4764-4d2b-a228-6fb3b4b477e8"),
                            BrandId = new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"),
                            CreateDate = new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6472),
                            CreatedBy = "Finekra",
                            PerfumeName = "Beyond Kadın Parfüm EDP 50 ml",
                            Price = 350.00m,
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("0a0b984a-6027-4727-9d1a-bd00d63b05e7"),
                            BrandId = new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"),
                            CreateDate = new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6476),
                            CreatedBy = "Finekra",
                            PerfumeName = "Wish Of Love Kadın Parfüm EDP 50 ml",
                            Price = 200.00m,
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("523351fc-e31e-4fce-a728-17fc93230675"),
                            BrandId = new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"),
                            CreateDate = new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6480),
                            CreatedBy = "Finekra",
                            PerfumeName = "Maxime Icon 75 ml",
                            Price = 300.00m,
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("d90e79e3-45e1-408b-a621-620126041218"),
                            BrandId = new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"),
                            CreateDate = new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6487),
                            CreatedBy = "Finekra",
                            PerfumeName = "Incandessence Kadın Parfüm EDP 50 ml",
                            Price = 400.00m,
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("04329e8f-2359-4268-a905-f9a98e59dcc1"),
                            BrandId = new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"),
                            CreateDate = new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6491),
                            CreatedBy = "Finekra",
                            PerfumeName = "Attraction Desire Kadın Parfüm EDP 50 ml",
                            Price = 600.00m,
                            RecordStatus = "Active"
                        });
                });

            modelBuilder.Entity("FinekraCase.Domain.Entities.UserDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("RecordStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("UserDetails");

                    b.HasData(
                        new
                        {
                            Id = new Guid("30ae1194-8378-4cae-94e8-426c435fec7a"),
                            CreateDate = new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6256),
                            CreatedBy = "Finekra",
                            Email = "info@polynomtech.com",
                            FirstName = "Finekra",
                            LastName = "Finekra",
                            Phone = "850 803 31 92",
                            RecordStatus = "Active",
                            UserName = "Finekra"
                        });
                });

            modelBuilder.Entity("FinekraCase.Domain.Entities.Baskets", b =>
                {
                    b.HasOne("FinekraCase.Domain.Entities.Perfumes", "Perfume")
                        .WithMany("Baskets")
                        .HasForeignKey("PerfumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinekraCase.Domain.Entities.UserDetails", "UserDetail")
                        .WithMany("Baskets")
                        .HasForeignKey("UserDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Perfume");

                    b.Navigation("UserDetail");
                });

            modelBuilder.Entity("FinekraCase.Domain.Entities.OrderDetails", b =>
                {
                    b.HasOne("FinekraCase.Domain.Entities.Orders", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinekraCase.Domain.Entities.Perfumes", "Perfume")
                        .WithMany("OrderDetails")
                        .HasForeignKey("PerfumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Perfume");
                });

            modelBuilder.Entity("FinekraCase.Domain.Entities.Orders", b =>
                {
                    b.HasOne("FinekraCase.Domain.Entities.UserDetails", "UserDetail")
                        .WithMany("Orders")
                        .HasForeignKey("UserDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserDetail");
                });

            modelBuilder.Entity("FinekraCase.Domain.Entities.Perfumes", b =>
                {
                    b.HasOne("FinekraCase.Domain.Entities.Brands", "Brand")
                        .WithMany("Perfumes")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("FinekraCase.Domain.Entities.Brands", b =>
                {
                    b.Navigation("Perfumes");
                });

            modelBuilder.Entity("FinekraCase.Domain.Entities.Orders", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("FinekraCase.Domain.Entities.Perfumes", b =>
                {
                    b.Navigation("Baskets");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("FinekraCase.Domain.Entities.UserDetails", b =>
                {
                    b.Navigation("Baskets");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}