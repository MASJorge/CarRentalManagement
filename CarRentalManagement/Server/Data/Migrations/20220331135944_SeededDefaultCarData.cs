using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", "System", new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2184), "Black", "System", new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2193) },
                    { "2", "System", new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2196), "Blue", "System", new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2196) }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", "System", new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2393), "BMW", "System", new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2393) },
                    { "2", "System", new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2395), "Toyota", "System", new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2396) }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { "1", "System", new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2462), "Prius", "System", new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2462) },
                    { "2", "System", new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2463), "Corolla", "System", new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2464) },
                    { "3", "System", new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2466), "3 Series", "System", new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2467) },
                    { "4", "System", new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2467), "X2", "System", new DateTime(2022, 3, 31, 10, 59, 44, 131, DateTimeKind.Local).AddTicks(2468) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "4");
        }
    }
}
