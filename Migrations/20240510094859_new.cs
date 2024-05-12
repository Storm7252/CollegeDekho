using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JD.com.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "ExamId", "CourseGroupId", "CoursesCourseId", "ExamName" },
                values: new object[,]
                {
                    { 1, 1, null, "NIMCET" },
                    { 2, 1, null, "C-CAT" },
                    { 3, 1, null, "UGAT" },
                    { 4, 1, null, "BITSAT" },
                    { 5, 1, null, "GATE" },
                    { 6, 2, null, "BITSAT" },
                    { 7, 2, null, "VITEE" },
                    { 8, 2, null, "JEE MAIN" },
                    { 9, 2, null, "JEE ADVANCED" },
                    { 10, 2, null, "MHT CET" },
                    { 11, 2, null, "SRM JEEE" },
                    { 12, 3, null, "CUET" },
                    { 13, 3, null, "NEET" },
                    { 14, 3, null, "NATA" },
                    { 15, 3, null, "SAT" },
                    { 16, 3, null, "AILET" },
                    { 17, 3, null, "AP EAMCET" },
                    { 18, 3, null, "CLAT" },
                    { 19, 3, null, "NEST" },
                    { 20, 4, null, "UGAT" },
                    { 21, 4, null, "CUET" },
                    { 22, 4, null, "PUTHAT" },
                    { 23, 4, null, "NCHMCT" },
                    { 24, 4, null, "oberoi STEP" },
                    { 25, 4, null, "BVPCET" },
                    { 26, 4, null, "IPU" },
                    { 27, 4, null, "MAH HM CET" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "ExamId",
                keyValue: 27);
        }
    }
}
