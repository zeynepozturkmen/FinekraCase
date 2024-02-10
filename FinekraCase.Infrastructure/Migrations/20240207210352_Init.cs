using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinekraCase.Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RecordStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RecordStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perfumes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PerfumeName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Price = table.Column<decimal>(type: "numeric(18,4)", precision: 18, scale: 4, nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RecordStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfumes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perfumes_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipAddress = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RecordStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_UserDetails_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "UserDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(18,4)", precision: 18, scale: 4, nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    PerfumeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RecordStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Perfumes_PerfumeId",
                        column: x => x.PerfumeId,
                        principalTable: "Perfumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandName", "CreateDate", "CreatedBy", "Description", "LastModifiedBy", "RecordStatus", "UpdateDate" },
                values: new object[] { new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"), "Chanel", new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4401), "Finekra", "Test Description", null, "Active", null });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandName", "CreateDate", "CreatedBy", "Description", "LastModifiedBy", "RecordStatus", "UpdateDate" },
                values: new object[] { new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"), "Avon", new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4408), "Finekra", "Test Description", null, "Active", null });

            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "Id", "Address", "CreateDate", "CreatedBy", "Email", "FirstName", "LastModifiedBy", "LastName", "Phone", "RecordStatus", "UpdateDate", "UserName" },
                values: new object[] { new Guid("7c3bd119-78fd-401e-b3fd-6b1e1fe70c79"), null, new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4228), "Finekra", "info@polynomtech.com", "Finekra", null, "Finekra", "850 803 31 92", "Active", null, "Finekra" });

            migrationBuilder.InsertData(
                table: "Perfumes",
                columns: new[] { "Id", "BrandId", "CreateDate", "CreatedBy", "LastModifiedBy", "PerfumeName", "PhotoPath", "Price", "RecordStatus", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("15d1cf5d-c190-4d3f-8d91-194645d5efec"), new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"), new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4486), "Finekra", null, "Wish Of Love Kadın Parfüm EDP 50 ml", null, 200.00m, "Active", null },
                    { new Guid("310036d8-d36b-43bd-9415-c986a63dc217"), new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"), new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4505), "Finekra", null, "Attraction Desire Kadın Parfüm EDP 50 ml", null, 600.00m, "Active", null },
                    { new Guid("476d0c83-de20-404d-b1c2-47eda190e299"), new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"), new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4497), "Finekra", null, "Incandessence Kadın Parfüm EDP 50 ml", null, 400.00m, "Active", null },
                    { new Guid("5500f129-9c8d-4e93-b8f7-5079ec0ceb04"), new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"), new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4492), "Finekra", null, "Maxime Icon 75 ml", null, 300.00m, "Active", null },
                    { new Guid("7336b358-bbab-4426-ad82-4b84b596b328"), new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"), new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4456), "Finekra", null, "Chance Kadın Parfüm EDP 50 ml", null, 600.00m, "Active", null },
                    { new Guid("8da4be34-777d-4e91-aac9-b04f630db86d"), new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"), new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4481), "Finekra", null, "Beyond Kadın Parfüm EDP 50 ml", null, 350.00m, "Active", null },
                    { new Guid("93d8c829-7d01-40fc-a0a3-49e3a5f0215a"), new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"), new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4467), "Finekra", null, "Gabrielle Kadın Parfüm EDP 50 ml", null, 800.00m, "Active", null },
                    { new Guid("d3fd01aa-e61f-48bc-9915-3f49c3c0c34b"), new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"), new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4472), "Finekra", null, "Sensuelle Kadın Parfüm EDP 50 ml", null, 900.00m, "Active", null },
                    { new Guid("f157669e-3bd6-413a-80d8-7ae1b437688c"), new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"), new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4435), "Finekra", null, "Mademoiselle Kadın Parfüm EDP 50 ml", null, 500.00m, "Active", null },
                    { new Guid("ffa5795a-904b-48be-b254-d1bc419ef1fb"), new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"), new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4462), "Finekra", null, "Allure Kadın Parfüm EDP 50 ml", null, 700.00m, "Active", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_PerfumeId",
                table: "OrderDetails",
                column: "PerfumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserDetailId",
                table: "Orders",
                column: "UserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfumes_BrandId",
                table: "Perfumes",
                column: "BrandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Perfumes");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
