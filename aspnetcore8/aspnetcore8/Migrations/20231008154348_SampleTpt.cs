using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetcore8.Migrations
{
    /// <inheritdoc />
    public partial class SampleTpt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonTpt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTpt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentsTpt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    StudentCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsTpt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentsTpt_PersonTpt_Id",
                        column: x => x.Id,
                        principalTable: "PersonTpt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeachersTpt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    PropertyX = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachersTpt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeachersTpt_PersonTpt_Id",
                        column: x => x.Id,
                        principalTable: "PersonTpt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsTpt");

            migrationBuilder.DropTable(
                name: "TeachersTpt");

            migrationBuilder.DropTable(
                name: "PersonTpt");
        }
    }
}
