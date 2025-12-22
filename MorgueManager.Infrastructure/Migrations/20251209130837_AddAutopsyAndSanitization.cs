using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MorgueManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAutopsyAndSanitization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutopsyRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorpseId = table.Column<int>(type: "int", nullable: false),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerformedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResultSummary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailedReport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutopsyRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutopsyRecord_Corpses_CorpseId",
                        column: x => x.CorpseId,
                        principalTable: "Corpses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "SystemConfigs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "SystemConfigs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 20, 8, 36, 774, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.CreateIndex(
                name: "IX_AutopsyRecord_CorpseId",
                table: "AutopsyRecord",
                column: "CorpseId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutopsyRecord");

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "SystemConfigs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "SystemConfigs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 30, 40, 725, DateTimeKind.Local).AddTicks(8159));
        }
    }
}
