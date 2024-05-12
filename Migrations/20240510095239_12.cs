using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JD.com.Migrations
{
    /// <inheritdoc />
    public partial class _12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Courses_CoursesCourseId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_CoursesCourseId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "CoursesCourseId",
                table: "Exams");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CoursesCourseId",
                table: "Exams",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 1,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 2,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 3,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 4,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 5,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 6,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 7,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 8,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 9,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 10,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 11,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 12,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 13,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 14,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 15,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 16,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 17,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 18,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 19,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 20,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 21,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 22,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 23,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 24,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 25,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 26,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 27,
                column: "CoursesCourseId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Exams_CoursesCourseId",
                table: "Exams",
                column: "CoursesCourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Courses_CoursesCourseId",
                table: "Exams",
                column: "CoursesCourseId",
                principalTable: "Courses",
                principalColumn: "CourseId");
        }
    }
}
