using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticaAula.Migrations
{
    public partial class seedSample01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAdmission",
                value: new DateTime(2022, 8, 2, 15, 57, 28, 634, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.InsertData(
                table: "Vacations",
                columns: new[] { "Id", "DateOfAdmission", "DepartureDate", "EmployeeId" },
                values: new object[] { 1, new DateTime(2022, 8, 2, 15, 57, 28, 636, DateTimeKind.Local).AddTicks(4376), new DateTime(2022, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vacations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAdmission",
                value: new DateTime(2022, 8, 2, 11, 42, 47, 930, DateTimeKind.Local).AddTicks(3024));
        }
    }
}
