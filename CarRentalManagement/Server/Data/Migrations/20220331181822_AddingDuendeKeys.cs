using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddingDuendeKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "a31418a5-6516-43c1-b4f6-92ba45b74417");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "27110e08-1eec-49d9-8c50-c47eba83c87f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71634800-8d8a-4558-80c2-5abf5ae12da9", "AQAAAAEAACcQAAAAECSE+cUw0kReN2X1zAzHEQHmsY1A6sgPodwI4k8COo6QGZY70oJ+MBSsOnu8fom0jw==", "f744bd7c-e1f0-4934-a4fb-5c126239cf8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48fa20fd-58fb-4fee-b98c-5f58806b58dc", "AQAAAAEAACcQAAAAECMEl8d+5O5FIouNY1Uek8fxi3lRZ+ipQ7FnnWIxSnj+v3tq8QgfAAU9sRq2ng2jSw==", "c07fe51e-eaf9-4974-a426-871b6e7f23b6" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 15, 18, 21, 215, DateTimeKind.Local).AddTicks(3102), new DateTime(2022, 3, 31, 15, 18, 21, 215, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 15, 18, 21, 215, DateTimeKind.Local).AddTicks(3114), new DateTime(2022, 3, 31, 15, 18, 21, 215, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 15, 18, 21, 215, DateTimeKind.Local).AddTicks(3279), new DateTime(2022, 3, 31, 15, 18, 21, 215, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 15, 18, 21, 215, DateTimeKind.Local).AddTicks(3282), new DateTime(2022, 3, 31, 15, 18, 21, 215, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 15, 18, 21, 215, DateTimeKind.Local).AddTicks(3340), new DateTime(2022, 3, 31, 15, 18, 21, 215, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 15, 18, 21, 215, DateTimeKind.Local).AddTicks(3342), new DateTime(2022, 3, 31, 15, 18, 21, 215, DateTimeKind.Local).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 15, 18, 21, 215, DateTimeKind.Local).AddTicks(3344), new DateTime(2022, 3, 31, 15, 18, 21, 215, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 3, 31, 15, 18, 21, 215, DateTimeKind.Local).AddTicks(3346), new DateTime(2022, 3, 31, 15, 18, 21, 215, DateTimeKind.Local).AddTicks(3347) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d50472e1-bb6e-4e29-8fd6-84c1e08db176", "AQAAAAEAACcQAAAAENLrB9tQB2K8Xl1kjFTwKf3OqVWmbKI3ATKuuDNYWaJm3q6LTQb9Nlk8bWJ9imiptA==", "5baa9fd6-efcd-42c1-ba5e-0d71f04f803e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b62efc82-7e00-497f-96a5-ca86889af360", "AQAAAAEAACcQAAAAEF7M+SeR50EtZRBObYeSZdu2QdairvXHQmXmLDpttYZbUGFW/91wWy2z/ZN9+ChqLw==", "48f9fa7c-b9f0-4140-834b-9331414e3641" });

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
        }
    }
}
