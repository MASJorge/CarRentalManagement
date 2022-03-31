using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "0311bce7-467c-4aef-97c3-619d96b3c487");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "7e0621ba-e416-44cc-a222-3a4ec94ef33b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "d50472e1-bb6e-4e29-8fd6-84c1e08db176", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAENLrB9tQB2K8Xl1kjFTwKf3OqVWmbKI3ATKuuDNYWaJm3q6LTQb9Nlk8bWJ9imiptA==", null, false, "5baa9fd6-efcd-42c1-ba5e-0d71f04f803e", false, "admin@localhost.com" },
                    { "9e224968-33e4-4652-b7b7-8574d048cdb9", 0, "b62efc82-7e00-497f-96a5-ca86889af360", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEF7M+SeR50EtZRBObYeSZdu2QdairvXHQmXmLDpttYZbUGFW/91wWy2z/ZN9+ChqLw==", null, false, "48f9fa7c-b9f0-4140-834b-9331414e3641", false, "User@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 45, 47, 800, DateTimeKind.Local).AddTicks(7523), new DateTime(2022, 3, 31, 14, 45, 47, 800, DateTimeKind.Local).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 45, 47, 800, DateTimeKind.Local).AddTicks(7537), new DateTime(2022, 3, 31, 14, 45, 47, 800, DateTimeKind.Local).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 45, 47, 800, DateTimeKind.Local).AddTicks(7713), new DateTime(2022, 3, 31, 14, 45, 47, 800, DateTimeKind.Local).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 45, 47, 800, DateTimeKind.Local).AddTicks(7716), new DateTime(2022, 3, 31, 14, 45, 47, 800, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 45, 47, 800, DateTimeKind.Local).AddTicks(7782), new DateTime(2022, 3, 31, 14, 45, 47, 800, DateTimeKind.Local).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 45, 47, 800, DateTimeKind.Local).AddTicks(7784), new DateTime(2022, 3, 31, 14, 45, 47, 800, DateTimeKind.Local).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 45, 47, 800, DateTimeKind.Local).AddTicks(7785), new DateTime(2022, 3, 31, 14, 45, 47, 800, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 14, 45, 47, 800, DateTimeKind.Local).AddTicks(7786), new DateTime(2022, 3, 31, 14, 45, 47, 800, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9");

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
    }
}
