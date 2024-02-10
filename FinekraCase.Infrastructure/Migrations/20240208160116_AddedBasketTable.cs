using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinekraCase.Infrastructure.Migrations
{
    public partial class AddedBasketTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("15d1cf5d-c190-4d3f-8d91-194645d5efec"));

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("310036d8-d36b-43bd-9415-c986a63dc217"));

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("476d0c83-de20-404d-b1c2-47eda190e299"));

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("5500f129-9c8d-4e93-b8f7-5079ec0ceb04"));

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("7336b358-bbab-4426-ad82-4b84b596b328"));

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("8da4be34-777d-4e91-aac9-b04f630db86d"));

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("93d8c829-7d01-40fc-a0a3-49e3a5f0215a"));

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("d3fd01aa-e61f-48bc-9915-3f49c3c0c34b"));

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("f157669e-3bd6-413a-80d8-7ae1b437688c"));

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("ffa5795a-904b-48be-b254-d1bc419ef1fb"));

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: new Guid("7c3bd119-78fd-401e-b3fd-6b1e1fe70c79"));

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Baskets_Perfumes_PerfumeId",
                        column: x => x.PerfumeId,
                        principalTable: "Perfumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Baskets_UserDetails_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "UserDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"),
                column: "CreateDate",
                value: new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"),
                column: "CreateDate",
                value: new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.InsertData(
                table: "Perfumes",
                columns: new[] { "Id", "BrandId", "CreateDate", "CreatedBy", "LastModifiedBy", "PerfumeName", "PhotoPath", "Price", "RecordStatus", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("04329e8f-2359-4268-a905-f9a98e59dcc1"), new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"), new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6491), "Finekra", null, "Attraction Desire Kadın Parfüm EDP 50 ml", null, 600.00m, "Active", null },
                    { new Guid("0a0b984a-6027-4727-9d1a-bd00d63b05e7"), new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"), new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6476), "Finekra", null, "Wish Of Love Kadın Parfüm EDP 50 ml", null, 200.00m, "Active", null },
                    { new Guid("3459839c-9161-4ffd-a460-b85a1ad18b89"), new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"), new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6447), "Finekra", null, "Mademoiselle Kadın Parfüm EDP 50 ml", null, 500.00m, "Active", null },
                    { new Guid("523351fc-e31e-4fce-a728-17fc93230675"), new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"), new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6480), "Finekra", null, "Maxime Icon 75 ml", null, 300.00m, "Active", null },
                    { new Guid("836f5167-ae29-4993-bd59-8ce26bd6e405"), new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"), new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6455), "Finekra", null, "Allure Kadın Parfüm EDP 50 ml", null, 700.00m, "Active", null },
                    { new Guid("90d9ff49-d2f4-4144-a0a7-f6cd8e3f3cf7"), new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"), new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6460), "Finekra", null, "Gabrielle Kadın Parfüm EDP 50 ml", null, 800.00m, "Active", null },
                    { new Guid("9cbfedc3-4764-4d2b-a228-6fb3b4b477e8"), new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"), new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6472), "Finekra", null, "Beyond Kadın Parfüm EDP 50 ml", null, 350.00m, "Active", null },
                    { new Guid("aae3314b-94ea-44ea-9f3f-ea1b6d991ec6"), new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"), new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6451), "Finekra", null, "Chance Kadın Parfüm EDP 50 ml", null, 600.00m, "Active", null },
                    { new Guid("acc320ee-cd84-41c9-b3d4-b79fa879825f"), new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"), new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6467), "Finekra", null, "Sensuelle Kadın Parfüm EDP 50 ml", null, 900.00m, "Active", null },
                    { new Guid("d90e79e3-45e1-408b-a621-620126041218"), new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"), new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6487), "Finekra", null, "Incandessence Kadın Parfüm EDP 50 ml", null, 400.00m, "Active", null }
                });

            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "Id", "Address", "CreateDate", "CreatedBy", "Email", "FirstName", "LastModifiedBy", "LastName", "Phone", "RecordStatus", "UpdateDate", "UserName" },
                values: new object[] { new Guid("30ae1194-8378-4cae-94e8-426c435fec7a"), null, new DateTime(2024, 2, 8, 19, 1, 16, 334, DateTimeKind.Local).AddTicks(6256), "Finekra", "info@polynomtech.com", "Finekra", null, "Finekra", "850 803 31 92", "Active", null, "Finekra" });

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_PerfumeId",
                table: "Baskets",
                column: "PerfumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_UserDetailId",
                table: "Baskets",
                column: "UserDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("04329e8f-2359-4268-a905-f9a98e59dcc1"));

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("0a0b984a-6027-4727-9d1a-bd00d63b05e7"));

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("3459839c-9161-4ffd-a460-b85a1ad18b89"));

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("523351fc-e31e-4fce-a728-17fc93230675"));

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("836f5167-ae29-4993-bd59-8ce26bd6e405"));

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("90d9ff49-d2f4-4144-a0a7-f6cd8e3f3cf7"));

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("9cbfedc3-4764-4d2b-a228-6fb3b4b477e8"));

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("aae3314b-94ea-44ea-9f3f-ea1b6d991ec6"));

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("acc320ee-cd84-41c9-b3d4-b79fa879825f"));

            migrationBuilder.DeleteData(
                table: "Perfumes",
                keyColumn: "Id",
                keyValue: new Guid("d90e79e3-45e1-408b-a621-620126041218"));

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: new Guid("30ae1194-8378-4cae-94e8-426c435fec7a"));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("dc695b3f-ee79-4fca-82c2-b5330765ee26"),
                column: "CreateDate",
                value: new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("ffa7fb5f-7ffe-443e-87ba-b7d88d403012"),
                column: "CreateDate",
                value: new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4408));

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

            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "Id", "Address", "CreateDate", "CreatedBy", "Email", "FirstName", "LastModifiedBy", "LastName", "Phone", "RecordStatus", "UpdateDate", "UserName" },
                values: new object[] { new Guid("7c3bd119-78fd-401e-b3fd-6b1e1fe70c79"), null, new DateTime(2024, 2, 8, 0, 3, 52, 186, DateTimeKind.Local).AddTicks(4228), "Finekra", "info@polynomtech.com", "Finekra", null, "Finekra", "850 803 31 92", "Active", null, "Finekra" });
        }
    }
}
