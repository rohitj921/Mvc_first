using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_First.Migrations
{
    /// <inheritdoc />
    public partial class newfields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Employee",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "dob",
                table: "Employee",
                newName: "Dob");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Employee",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "Employee",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Employee",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employee",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Dob",
                table: "Employee",
                newName: "dob");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Employee",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Employee",
                newName: "age");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employee",
                newName: "id");
        }
    }
}
