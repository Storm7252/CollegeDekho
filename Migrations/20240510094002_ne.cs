using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JD.com.Migrations
{
    /// <inheritdoc />
    public partial class ne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Courses_CourseId",
                table: "Exams");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Exams",
                newName: "CourseGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Exams_CourseId",
                table: "Exams",
                newName: "IX_Exams_CourseGroupId");

            migrationBuilder.AddColumn<int>(
                name: "CoursesCourseId",
                table: "Exams",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Exams_CoursesCourseId",
                table: "Exams",
                column: "CoursesCourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_CourseGroup_CourseGroupId",
                table: "Exams",
                column: "CourseGroupId",
                principalTable: "CourseGroup",
                principalColumn: "CourseGroupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Courses_CoursesCourseId",
                table: "Exams",
                column: "CoursesCourseId",
                principalTable: "Courses",
                principalColumn: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_CourseGroup_CourseGroupId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Courses_CoursesCourseId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_CoursesCourseId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "CoursesCourseId",
                table: "Exams");

            migrationBuilder.RenameColumn(
                name: "CourseGroupId",
                table: "Exams",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Exams_CourseGroupId",
                table: "Exams",
                newName: "IX_Exams_CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Courses_CourseId",
                table: "Exams",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
