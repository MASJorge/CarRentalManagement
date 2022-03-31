using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9b7e5ea4-1a58-4c94-86c7-3773870f6def", "User", "USER" },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "3355a513-e1d1-45dd-a56b-e2330ae1b88b", "Administrator", "ADMINISTRATOR" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2184), new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2196), new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2393), new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2395), new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2462), new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2463), new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2466), new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2467), new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2468) });
        }
    }
}
