using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManager.Data.Migrations
{
    public partial class addedsubjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentAmount = table.Column<int>(type: "int", nullable: false),
                    RequiredGrade = table.Column<double>(type: "float", nullable: false),
                    RequiredHours = table.Column<double>(type: "float", nullable: false),
                    RequiredTests = table.Column<double>(type: "float", nullable: false),
                    TotalTests = table.Column<double>(type: "float", nullable: false),
                    TotalHours = table.Column<double>(type: "float", nullable: false),
                    MaxAbsentHours = table.Column<int>(type: "int", nullable: false),
                    TeacherCountInClass = table.Column<int>(type: "int", nullable: false),
                    TeacherRegistered = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Students = table.Column<int>(type: "int", nullable: false),
                    Teachers = table.Column<int>(type: "int", nullable: false),
                    Vacancies = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                });
        }
    }
}
