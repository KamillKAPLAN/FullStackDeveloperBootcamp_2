using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BootcampAPI.Migrations
{
    public partial class i2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentInfo_Grades_GradeId",
                schema: "Bootacamp",
                table: "StudentInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentInfo",
                schema: "Bootacamp",
                table: "StudentInfo");

            migrationBuilder.RenameTable(
                name: "StudentInfo",
                schema: "Bootacamp",
                newName: "Students");

            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Students",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_StudentInfo_GradeId",
                table: "Students",
                newName: "IX_Students_GradeId");

            migrationBuilder.AlterColumn<string>(
                name: "GradeName",
                table: "Grades",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddColumn<decimal>(
                name: "Height",
                table: "Students",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Grades_GradeId",
                table: "Students",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Grades_GradeId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Students");

            migrationBuilder.EnsureSchema(
                name: "Bootacamp");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "StudentInfo",
                newSchema: "Bootacamp");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "Bootacamp",
                table: "StudentInfo",
                newName: "StudentName");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GradeId",
                schema: "Bootacamp",
                table: "StudentInfo",
                newName: "IX_StudentInfo_GradeId");

            migrationBuilder.AlterColumn<string>(
                name: "GradeName",
                table: "Grades",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "StudentName",
                schema: "Bootacamp",
                table: "StudentInfo",
                type: "nchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentInfo",
                schema: "Bootacamp",
                table: "StudentInfo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentInfo_Grades_GradeId",
                schema: "Bootacamp",
                table: "StudentInfo",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
