using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetcore7.Migrations
{
    /// <inheritdoc />
    public partial class addtwoProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty1",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty2",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty1",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "MyProperty2",
                table: "Category");
        }
    }
}
