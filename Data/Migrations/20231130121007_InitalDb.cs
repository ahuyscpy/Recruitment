using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InitalDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("670e2b28-d5f4-4264-bdca-e1a113a2e40e"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ba1d1035-a824-49c9-9169-d71e3049611b"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e1026231-9435-43ab-8c94-b25d682da123"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("95e0a3f8-95d6-407a-b625-e2d5fcd557ba"), new Guid("670e2b28-d5f4-4264-bdca-e1a113a2e40e") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("95e0a3f8-95d6-407a-b625-e2d5fcd557ba"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Notifications",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 30, 19, 10, 6, 937, DateTimeKind.Local).AddTicks(5151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 24, 15, 48, 20, 124, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "CurriculumVitaes",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 30, 19, 10, 6, 933, DateTimeKind.Local).AddTicks(8251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 24, 15, 48, 20, 120, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Chats",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 30, 19, 10, 6, 920, DateTimeKind.Local).AddTicks(748),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 24, 15, 48, 20, 107, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("e7f5ef78-08ea-4c75-921c-8f22572a16b6"), "5575a8aa-69b0-49ef-89d0-534cc947a18e", "Company role", "company", "company" },
                    { new Guid("6d765d88-4759-4a66-8e5c-0caeb73e8a9b"), "bc3bd9a0-5096-4710-9d33-a8a444b20d8a", "User role", "user", "user" },
                    { new Guid("75c6dc5a-392d-41fd-8e93-7d11d31bdf1a"), "6368fcc4-04a5-4c1d-9b52-84ada0847a03", "Admin role", "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("2e149124-07a9-4d78-922c-4037e74737ea"), new Guid("75c6dc5a-392d-41fd-8e93-7d11d31bdf1a") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("2e149124-07a9-4d78-922c-4037e74737ea"), 0, "25359cbc-3939-4627-b9d0-ade847254913", new DateTime(2023, 11, 30, 19, 10, 6, 970, DateTimeKind.Local).AddTicks(2507), "hoangthanh01022000@gmail.com", true, false, null, "hoangthanh01022000@gmail.com", "admin", "AQAAAAEAACcQAAAAEHZjyC/FgEuEMl/qBNi4Ks0YuPOaSFwhaV2FuiJ99Re3OPICtUY3UzypUabyKxmYIQ==", "11111", false, "", false, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("6d765d88-4759-4a66-8e5c-0caeb73e8a9b"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("75c6dc5a-392d-41fd-8e93-7d11d31bdf1a"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e7f5ef78-08ea-4c75-921c-8f22572a16b6"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("2e149124-07a9-4d78-922c-4037e74737ea"), new Guid("75c6dc5a-392d-41fd-8e93-7d11d31bdf1a") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e149124-07a9-4d78-922c-4037e74737ea"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 24, 15, 48, 20, 124, DateTimeKind.Local).AddTicks(2098),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 11, 30, 19, 10, 6, 937, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "CurriculumVitaes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 24, 15, 48, 20, 120, DateTimeKind.Local).AddTicks(6799),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 11, 30, 19, 10, 6, 933, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Chats",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 24, 15, 48, 20, 107, DateTimeKind.Local).AddTicks(6477),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 11, 30, 19, 10, 6, 920, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("ba1d1035-a824-49c9-9169-d71e3049611b"), "0e46037c-f2dc-4859-b70d-51d8c6a25d12", "Company role", "company", "company" },
                    { new Guid("e1026231-9435-43ab-8c94-b25d682da123"), "f06f9db8-6104-4677-88cd-75da11549961", "User role", "user", "user" },
                    { new Guid("670e2b28-d5f4-4264-bdca-e1a113a2e40e"), "89a179ff-e9dc-4c61-ae77-b6ee50e3e4cf", "Admin role", "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("95e0a3f8-95d6-407a-b625-e2d5fcd557ba"), new Guid("670e2b28-d5f4-4264-bdca-e1a113a2e40e") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("95e0a3f8-95d6-407a-b625-e2d5fcd557ba"), 0, "521fa893-0afd-4136-926b-c966bb7e2afb", new DateTime(2023, 9, 24, 15, 48, 20, 144, DateTimeKind.Local).AddTicks(2588), "hoangthanh01022000@gmail.com", true, false, null, "hoangthanh01022000@gmail.com", "admin", "AQAAAAEAACcQAAAAEMYjP8moPfwK4YFMlPkNHs1gRI+3qAKoK8KtmrLGjgv5QXrK49IwPf4xri6kf0CMaw==", "11111", false, "", false, "admin" });
        }
    }
}
