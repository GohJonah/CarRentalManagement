using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Lasstname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "9406de0c-6d42-4de6-b401-4eac1d6188fe", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEKLLUqycQgSkBe5TWrmo7HiqD+QZD+8nsyH7YR+5I5POJx4FS0I161LiwXS+f5gixw==", null, false, "fb88f8b3-e6e4-431b-a853-bf27d96f881a", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 40, 10, 23, DateTimeKind.Local).AddTicks(8634), new DateTime(2023, 11, 22, 11, 40, 10, 23, DateTimeKind.Local).AddTicks(8647), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 40, 10, 23, DateTimeKind.Local).AddTicks(8650), new DateTime(2023, 11, 22, 11, 40, 10, 23, DateTimeKind.Local).AddTicks(8650), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 40, 10, 23, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 11, 22, 11, 40, 10, 23, DateTimeKind.Local).AddTicks(8880), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 40, 10, 23, DateTimeKind.Local).AddTicks(8882), new DateTime(2023, 11, 22, 11, 40, 10, 23, DateTimeKind.Local).AddTicks(8882), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 40, 10, 23, DateTimeKind.Local).AddTicks(9017), new DateTime(2023, 11, 22, 11, 40, 10, 23, DateTimeKind.Local).AddTicks(9017), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 40, 10, 23, DateTimeKind.Local).AddTicks(9019), new DateTime(2023, 11, 22, 11, 40, 10, 23, DateTimeKind.Local).AddTicks(9019), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 22, 11, 40, 10, 23, DateTimeKind.Local).AddTicks(9020), new DateTime(2023, 11, 22, 11, 40, 10, 23, DateTimeKind.Local).AddTicks(9021), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 22, 11, 40, 10, 23, DateTimeKind.Local).AddTicks(9041), new DateTime(2023, 11, 22, 11, 40, 10, 23, DateTimeKind.Local).AddTicks(9042), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
