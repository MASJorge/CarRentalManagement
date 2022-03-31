using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "a99738b1-56ea-4db7-ac87-6accb124c6bb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "a30b452c-f079-43a1-b193-fe6f878c2b3d");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 7, 21, 536, DateTimeKind.Local).AddTicks(5619), new DateTime(2022, 3, 31, 14, 7, 21, 536, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 7, 21, 536, DateTimeKind.Local).AddTicks(5632), new DateTime(2022, 3, 31, 14, 7, 21, 536, DateTimeKind.Local).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 7, 21, 536, DateTimeKind.Local).AddTicks(5892), new DateTime(2022, 3, 31, 14, 7, 21, 536, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 7, 21, 536, DateTimeKind.Local).AddTicks(5895), new DateTime(2022, 3, 31, 14, 7, 21, 536, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 7, 21, 536, DateTimeKind.Local).AddTicks(5996), new DateTime(2022, 3, 31, 14, 7, 21, 536, DateTimeKind.Local).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 7, 21, 536, DateTimeKind.Local).AddTicks(5999), new DateTime(2022, 3, 31, 14, 7, 21, 536, DateTimeKind.Local).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 7, 21, 536, DateTimeKind.Local).AddTicks(6001), new DateTime(2022, 3, 31, 14, 7, 21, 536, DateTimeKind.Local).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 7, 21, 536, DateTimeKind.Local).AddTicks(6002), new DateTime(2022, 3, 31, 14, 7, 21, 536, DateTimeKind.Local).AddTicks(6003) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "9b7e5ea4-1a58-4c94-86c7-3773870f6def");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "3355a513-e1d1-45dd-a56b-e2330ae1b88b");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 6, 52, 400, DateTimeKind.Local).AddTicks(1698), new DateTime(2022, 3, 31, 14, 6, 52, 400, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 6, 52, 400, DateTimeKind.Local).AddTicks(1710), new DateTime(2022, 3, 31, 14, 6, 52, 400, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 6, 52, 400, DateTimeKind.Local).AddTicks(1880), new DateTime(2022, 3, 31, 14, 6, 52, 400, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 6, 52, 400, DateTimeKind.Local).AddTicks(1888), new DateTime(2022, 3, 31, 14, 6, 52, 400, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 6, 52, 400, DateTimeKind.Local).AddTicks(1953), new DateTime(2022, 3, 31, 14, 6, 52, 400, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 6, 52, 400, DateTimeKind.Local).AddTicks(1956), new DateTime(2022, 3, 31, 14, 6, 52, 400, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 6, 52, 400, DateTimeKind.Local).AddTicks(1957), new DateTime(2022, 3, 31, 14, 6, 52, 400, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 6, 52, 400, DateTimeKind.Local).AddTicks(1959), new DateTime(2022, 3, 31, 14, 6, 52, 400, DateTimeKind.Local).AddTicks(1960) });
        }
    }
}
