using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoList.Migrations
{
    public partial class NameChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TaskItems",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "ColumnName",
                table: "TaskItems",
                newName: "Column");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "Column",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "TaskItems",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Column",
                table: "TaskItems",
                newName: "ColumnName");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "ColumnName",
                value: 2);
        }
    }
}
