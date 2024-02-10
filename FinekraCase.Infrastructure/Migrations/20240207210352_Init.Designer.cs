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
    [Migration("20240207210352_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
                            CreateDate = new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4401),
                            CreatedBy = "Finekra",
                            Description = "Test Description",
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"),
                            BrandName = "Avon",
                            CreateDate = new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4408),
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
                            Id = new Guid("f157669e-3bd6-413a-80d8-7ae1b437688c"),
                            BrandId = new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"),
                            CreateDate = new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4435),
                            CreatedBy = "Finekra",
                            PerfumeName = "Mademoiselle Kadın Parfüm EDP 50 ml",
                            Price = 500.00m,
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("7336b358-bbab-4426-ad82-4b84b596b328"),
                            BrandId = new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"),
                            CreateDate = new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4456),
                            CreatedBy = "Finekra",
                            PerfumeName = "Chance Kadın Parfüm EDP 50 ml",
                            Price = 600.00m,
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("ffa5795a-904b-48be-b254-d1bc419ef1fb"),
                            BrandId = new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"),
                            CreateDate = new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4462),
                            CreatedBy = "Finekra",
                            PerfumeName = "Allure Kadın Parfüm EDP 50 ml",
                            Price = 700.00m,
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("93d8c829-7d01-40fc-a0a3-49e3a5f0215a"),
                            BrandId = new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"),
                            CreateDate = new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4467),
                            CreatedBy = "Finekra",
                            PerfumeName = "Gabrielle Kadın Parfüm EDP 50 ml",
                            Price = 800.00m,
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("d3fd01aa-e61f-48bc-9915-3f49c3c0c34b"),
                            BrandId = new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"),
                            CreateDate = new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4472),
                            CreatedBy = "Finekra",
                            PerfumeName = "Sensuelle Kadın Parfüm EDP 50 ml",
                            Price = 900.00m,
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("8da4be34-777d-4e91-aac9-b04f630db86d"),
                            BrandId = new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"),
                            CreateDate = new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4481),
                            CreatedBy = "Finekra",
                            PerfumeName = "Beyond Kadın Parfüm EDP 50 ml",
                            Price = 350.00m,
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("15d1cf5d-c190-4d3f-8d91-194645d5efec"),
                            BrandId = new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"),
                            CreateDate = new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4486),
                            CreatedBy = "Finekra",
                            PerfumeName = "Wish Of Love Kadın Parfüm EDP 50 ml",
                            Price = 200.00m,
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("5500f129-9c8d-4e93-b8f7-5079ec0ceb04"),
                            BrandId = new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"),
                            CreateDate = new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4492),
                            CreatedBy = "Finekra",
                            PerfumeName = "Maxime Icon 75 ml",
                            Price = 300.00m,
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("476d0c83-de20-404d-b1c2-47eda190e299"),
                            BrandId = new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"),
                            CreateDate = new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4497),
                            CreatedBy = "Finekra",
                            PerfumeName = "Incandessence Kadın Parfüm EDP 50 ml",
                            Price = 400.00m,
                            RecordStatus = "Active"
                        },
                        new
                        {
                            Id = new Guid("310036d8-d36b-43bd-9415-c986a63dc217"),
                            BrandId = new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"),
                            CreateDate = new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4505),
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
                            Id = new Guid("7c3bd119-78fd-401e-b3fd-6b1e1fe70c79"),
                            CreateDate = new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4228),
                            CreatedBy = "Finekra",
                            Email = "info@polynomtech.com",
                            FirstName = "Finekra",
                            LastName = "Finekra",
                            Phone = "850 803 31 92",
                            RecordStatus = "Active",
                            UserName = "Finekra"
                        });
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
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("FinekraCase.Domain.Entities.UserDetails", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
