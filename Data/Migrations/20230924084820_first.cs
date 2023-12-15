using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("65272a1f-fa97-4d8c-bf8f-2754f55ed9f8"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("a380ed16-a9c7-4918-82e8-c676baede1d1"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f7cde378-6cff-4a68-81ba-34675d108a5c"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("a747074e-8a93-471f-a542-21d3fea814a5"), new Guid("a380ed16-a9c7-4918-82e8-c676baede1d1") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a747074e-8a93-471f-a542-21d3fea814a5"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Notifications",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 24, 15, 48, 20, 124, DateTimeKind.Local).AddTicks(2098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 9, 13, 16, 54, 992, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "CurriculumVitaes",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 24, 15, 48, 20, 120, DateTimeKind.Local).AddTicks(6799),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 9, 13, 16, 54, 987, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Chats",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 24, 15, 48, 20, 107, DateTimeKind.Local).AddTicks(6477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 9, 13, 16, 54, 965, DateTimeKind.Local).AddTicks(6948));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 9, 13, 16, 54, 992, DateTimeKind.Local).AddTicks(6958),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 9, 24, 15, 48, 20, 124, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "CurriculumVitaes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 9, 13, 16, 54, 987, DateTimeKind.Local).AddTicks(1547),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 9, 24, 15, 48, 20, 120, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Chats",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 9, 13, 16, 54, 965, DateTimeKind.Local).AddTicks(6948),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 9, 24, 15, 48, 20, 107, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("65272a1f-fa97-4d8c-bf8f-2754f55ed9f8"), "fda77e60-c267-4252-ba3f-2a6d735690ee", "Company role", "company", "company" },
                    { new Guid("f7cde378-6cff-4a68-81ba-34675d108a5c"), "9913bba0-8c62-4e89-abb1-fb4494223da8", "User role", "user", "user" },
                    { new Guid("a380ed16-a9c7-4918-82e8-c676baede1d1"), "0d405517-c20f-4a1d-a66c-ddaa43ef5311", "Admin role", "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("a747074e-8a93-471f-a542-21d3fea814a5"), new Guid("a380ed16-a9c7-4918-82e8-c676baede1d1") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a747074e-8a93-471f-a542-21d3fea814a5"), 0, "72b4da9f-d81f-4a3b-9a3b-5beffd0c5e0c", new DateTime(2022, 4, 9, 13, 16, 55, 22, DateTimeKind.Local).AddTicks(911), "hoangthanh01022000@gmail.com", true, false, null, "hoangthanh01022000@gmail.com", "admin", "AQAAAAEAACcQAAAAEPXd7r/Q25a96mw2Fy4bME/3klJxqd51tlStcRXuwA+w8iMcpTiKwjXU9SUzenTQrQ==", "11111", false, "", false, "admin" });
        }
    }
}
