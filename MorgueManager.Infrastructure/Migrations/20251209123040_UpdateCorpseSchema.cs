using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MorgueManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCorpseSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "CreatedDate",
                value: new DateTime(2025, 12, 9, 19, 16, 16, 189, DateTimeKind.Local).AddTicks(9633));
        }
    }
}
