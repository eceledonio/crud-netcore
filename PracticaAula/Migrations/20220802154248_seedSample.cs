using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticaAula.Migrations
{
    public partial class seedSample : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "DateOfAdmission", "FullName", "Position" },
                values: new object[] { 1, new DateTime(2022, 8, 2, 11, 42, 47, 930, DateTimeKind.Local).AddTicks(3024), "Enmanuel Celedonio", "Especialista Software Jr" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
