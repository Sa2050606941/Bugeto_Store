using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bugeto_Store.Presistance.Migrations
{
    public partial class Add_ViewCount_To_Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ViewCount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2022, 1, 12, 12, 39, 34, 587, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2022, 1, 12, 12, 39, 34, 591, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2022, 1, 12, 12, 39, 34, 591, DateTimeKind.Local).AddTicks(9571));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ViewCount",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2022, 1, 2, 23, 26, 23, 262, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2022, 1, 2, 23, 26, 23, 267, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2022, 1, 2, 23, 26, 23, 267, DateTimeKind.Local).AddTicks(1536));
        }
    }
}
