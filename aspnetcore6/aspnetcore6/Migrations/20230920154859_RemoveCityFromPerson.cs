using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetcore6.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCityFromPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Person");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
