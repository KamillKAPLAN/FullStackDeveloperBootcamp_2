using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BootcampAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Bootacamp");

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    GradeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UptatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UptatedBy = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.GradeId);
                });

            migrationBuilder.CreateTable(
                name: "StudentInfo",
                schema: "Bootacamp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nchar(10)", maxLength: 10, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UptatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UptatedBy = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentInfo_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "GradeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfo_GradeId",
                schema: "Bootacamp",
                table: "StudentInfo",
                column: "GradeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentInfo",
                schema: "Bootacamp");

            migrationBuilder.DropTable(
                name: "Grades");
        }
    }
}
