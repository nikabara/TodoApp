using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Todo.Migrations
{
    /// <inheritdoc />
    public partial class AddedDataToTodoListTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TodoList",
                columns: new[] { "Id", "Description", "DueDate", "Header", "SubHeader", "SubmissionsDate" },
                values: new object[,]
                {
                    { 1, "Don't forget to revise", new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test", "Test in Physics", new DateTime(2024, 2, 22, 2, 17, 7, 418, DateTimeKind.Local).AddTicks(6631) },
                    { 2, "Don't forget to revise", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test", "Test in Chemistry", new DateTime(2024, 2, 22, 2, 17, 7, 418, DateTimeKind.Local).AddTicks(6802) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoList",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TodoList",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
