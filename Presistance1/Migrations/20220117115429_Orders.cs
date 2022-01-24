using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bugeto_Store.Presistance.Migrations
{
    public partial class Orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2022, 1, 17, 15, 24, 28, 826, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2022, 1, 17, 15, 24, 28, 832, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2022, 1, 17, 15, 24, 28, 832, DateTimeKind.Local).AddTicks(4074));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2022, 1, 17, 14, 45, 4, 593, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2022, 1, 17, 14, 45, 4, 601, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2022, 1, 17, 14, 45, 4, 601, DateTimeKind.Local).AddTicks(921));
        }
    }
}
