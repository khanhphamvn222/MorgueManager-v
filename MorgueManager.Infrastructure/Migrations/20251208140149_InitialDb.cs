using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MorgueManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Zone = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemConfigs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Corpses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    StorageId = table.Column<int>(type: "int", nullable: true),
                    IdentityCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CauseOfDeath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HealthTags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentPaths = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceptionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeathTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corpses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Corpses_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StorageId = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PerformedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaintenanceLogs_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalBelongings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorpseId = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsReturned = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalBelongings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalBelongings_Corpses_CorpseId",
                        column: x => x.CorpseId,
                        principalTable: "Corpses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "LocationCode", "State", "UpdatedDate", "Zone" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2321), false, "A-01", 0, null, 0 },
                    { 2, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2324), false, "A-02", 0, null, 0 },
                    { 3, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2327), false, "A-03", 0, null, 0 },
                    { 4, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2329), false, "A-04", 0, null, 0 },
                    { 5, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2331), false, "A-05", 0, null, 0 },
                    { 6, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2333), false, "A-06", 0, null, 0 },
                    { 7, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2335), false, "A-07", 0, null, 0 },
                    { 8, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2341), false, "A-08", 0, null, 0 },
                    { 9, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2343), false, "A-09", 0, null, 0 },
                    { 10, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2354), false, "A-10", 0, null, 0 },
                    { 11, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2358), false, "B-01", 0, null, 1 },
                    { 12, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2361), false, "B-02", 0, null, 1 },
                    { 13, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2362), false, "B-03", 0, null, 1 },
                    { 14, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2364), false, "B-04", 0, null, 1 },
                    { 15, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2366), false, "B-05", 0, null, 1 },
                    { 16, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2367), false, "B-06", 0, null, 1 },
                    { 17, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2368), false, "B-07", 0, null, 1 },
                    { 18, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2371), false, "B-08", 0, null, 1 },
                    { 19, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2372), false, "B-09", 0, null, 1 },
                    { 20, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2374), false, "B-10", 0, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "SystemConfigs",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Key", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2250), "Giá lưu kho mỗi ngày (VND)", false, "PricePerDay", null, "500000" },
                    { 2, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2252), "Cảnh báo lưu lâu quá (ngày)", false, "WarningThreshold", null, "30" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "FullName", "IsActive", "IsDeleted", "PasswordHash", "Role", "UpdatedDate", "Username" },
                values: new object[] { 1, new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2175), null, "System Administrator", true, false, "Admin@123", 0, null, "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Corpses_IdentityNumber",
                table: "Corpses",
                column: "IdentityNumber",
                unique: true,
                filter: "[IdentityNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Corpses_StorageId",
                table: "Corpses",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceLogs_StorageId",
                table: "MaintenanceLogs",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalBelongings_CorpseId",
                table: "PersonalBelongings",
                column: "CorpseId");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_LocationCode",
                table: "Storages",
                column: "LocationCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaintenanceLogs");

            migrationBuilder.DropTable(
                name: "PersonalBelongings");

            migrationBuilder.DropTable(
                name: "SystemConfigs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Corpses");

            migrationBuilder.DropTable(
                name: "Storages");
        }
    }
}
