using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JD.com.Migrations
{
    /// <inheritdoc />
    public partial class n : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExamDescription",
                table: "Exams");

            migrationBuilder.InsertData(
                table: "CourseGroup",
                columns: new[] { "CourseGroupId", "CourseGroupName" },
                values: new object[,]
                {
                    { 1, "Information Technology" },
                    { 2, "Engineering" },
                    { 3, "Science" },
                    { 4, "Hotel Management" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CollegeId", "CourseGroupId", "CourseName" },
                values: new object[,]
                {
                    { 1, 0, 1, "BCA" },
                    { 2, 0, 1, "BscIT" },
                    { 3, 0, 1, "MCA" },
                    { 4, 0, 1, "MSC IT" },
                    { 5, 0, 1, "BTEC COMPUTER" },
                    { 6, 0, 2, "BTECH CIVIL" },
                    { 7, 0, 2, "BTECH MECHINICAL" },
                    { 8, 0, 2, "BTECH ELECTRICAL" },
                    { 9, 0, 2, "MTECH CIVIL" },
                    { 10, 0, 2, "MTECH MECHINICAL" },
                    { 11, 0, 2, "MTECH ELECTRICAL" },
                    { 12, 0, 3, "BSC BIOLOGY" },
                    { 13, 0, 3, "MSC BIOLOGY" },
                    { 14, 0, 3, "BSC Chemistry" },
                    { 15, 0, 3, "MSC Chemistry" },
                    { 16, 0, 3, "MSC Physics" },
                    { 17, 0, 3, "BSC Physics" },
                    { 18, 0, 4, "Bachelor Of Hotel Management." },
                    { 19, 0, 4, "Masters Of Hotel Management." },
                    { 20, 0, 4, "Diploma Of Hotel Management." },
                    { 21, 0, 4, "BSc in Hospitality And Hotel Administration." },
                    { 22, 0, 4, "Diploma in Food and Beverage services." },
                    { 23, 0, 4, "Advanced Diploma in Hospitality Management." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CourseGroup",
                keyColumn: "CourseGroupId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CourseGroup",
                keyColumn: "CourseGroupId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CourseGroup",
                keyColumn: "CourseGroupId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CourseGroup",
                keyColumn: "CourseGroupId",
                keyValue: 4);

            migrationBuilder.AddColumn<string>(
                name: "ExamDescription",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
