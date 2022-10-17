using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkProject.Migrations
{
    public partial class AddHeaderAndFooterTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Footers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Links = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Footers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Headers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Logo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 10, 17, 11, 59, 5, 300, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 10, 17, 11, 59, 5, 301, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 10, 17, 11, 59, 5, 301, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.InsertData(
                table: "Footers",
                columns: new[] { "Id", "IsDeleted", "Links" },
                values: new object[,]
                {
                    { 1, false, "https://www.facebook.com/cenab.akberoff" },
                    { 2, false, "https://www.instagram.com/cenab.akberoff/" },
                    { 3, false, "https://www.instagram.com/cenab.akberoff/" }
                });

            migrationBuilder.InsertData(
                table: "Headers",
                columns: new[] { "Id", "IsDeleted", "Logo" },
                values: new object[] { 1, false, "logo.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Footers");

            migrationBuilder.DropTable(
                name: "Headers");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 10, 17, 11, 36, 27, 728, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 10, 17, 11, 36, 27, 731, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 10, 17, 11, 36, 27, 731, DateTimeKind.Local).AddTicks(789));
        }
    }
}
