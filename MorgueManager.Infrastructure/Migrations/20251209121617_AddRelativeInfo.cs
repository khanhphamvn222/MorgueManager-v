using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MorgueManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddRelativeInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BelongingsInfo",
                table: "Corpses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HandoverTime",
                table: "Corpses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RelativeAddress",
                table: "Corpses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RelativeName",
                table: "Corpses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RelativePhone",
                table: "Corpses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "SystemConfigs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "SystemConfigs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash" },
                values: new object[] { new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9633), "240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BelongingsInfo",
                table: "Corpses");

            migrationBuilder.DropColumn(
                name: "HandoverTime",
                table: "Corpses");

            migrationBuilder.DropColumn(
                name: "RelativeAddress",
                table: "Corpses");

            migrationBuilder.DropColumn(
                name: "RelativeName",
                table: "Corpses");

            migrationBuilder.DropColumn(
                name: "RelativePhone",
                table: "Corpses");

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "SystemConfigs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "SystemConfigs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash" },
                values: new object[] { new DateTime(2025, 12, 8, 21, 1, 47, 995, DateTimeKind.Local).AddTicks(2175), "Admin@123" });
        }
    }
}
