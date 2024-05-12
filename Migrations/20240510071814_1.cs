using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JD.com.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "College",
                columns: table => new
                {
                    CollegeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollegeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_College", x => x.CollegeId);
                    table.ForeignKey(
                        name: "FK_College_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseGroup",
                columns: table => new
                {
                    CourseGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseGroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CollegeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseGroup", x => x.CourseGroupId);
                    table.ForeignKey(
                        name: "FK_CourseGroup_College_CollegeId",
                        column: x => x.CollegeId,
                        principalTable: "College",
                        principalColumn: "CollegeId");
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CollegeId = table.Column<int>(type: "int", nullable: false),
                    CourseGroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_CourseGroup_CourseGroupId",
                        column: x => x.CourseGroupId,
                        principalTable: "CourseGroup",
                        principalColumn: "CourseGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CollegeCourses",
                columns: table => new
                {
                    CollegeId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegeCourses", x => new { x.CollegeId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_CollegeCourses_College_CourseId",
                        column: x => x.CourseId,
                        principalTable: "College",
                        principalColumn: "CollegeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CollegeCourses_Courses_CollegeId",
                        column: x => x.CollegeId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExamDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.ExamId);
                    table.ForeignKey(
                        name: "FK_Exams_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "StateId", "StateName" },
                values: new object[,]
                {
                    { 1, "J&K" },
                    { 2, "Delhi" },
                    { 4, "Uttarakhand" },
                    { 5, "Punjab" },
                    { 6, "Banglore" }
                });

            migrationBuilder.InsertData(
                table: "College",
                columns: new[] { "CollegeId", "CollegeName", "CourseId", "StateId" },
                values: new object[,]
                {
                    { 1, "BFIT", 0, 4 },
                    { 2, "Baba Farid College", 0, 5 },
                    { 3, "Degree College Baramulla", 0, 1 },
                    { 5, "Dev Bhoomi", 0, 4 },
                    { 6, "Dhoon International", 0, 4 },
                    { 7, "Dolphin College", 0, 4 },
                    { 8, "Guru Nanak College", 0, 4 },
                    { 9, "LPU", 0, 5 },
                    { 10, "Chandigarh College of Hotel Management ", 0, 5 },
                    { 11, "Chandigarh Group of Colleges ", 0, 5 },
                    { 12, "Chandigarh Group of Colleges ", 0, 5 },
                    { 13, "Degree College Pattan", 0, 1 },
                    { 14, "Degree College Singpora", 0, 1 },
                    { 15, "Amar Singh College", 0, 1 },
                    { 16, "NIT", 0, 1 },
                    { 17, "IUST", 0, 1 },
                    { 18, "Degree College Bemina", 0, 1 },
                    { 19, "Banglore College Of technology", 0, 6 },
                    { 20, "Christ University", 0, 6 },
                    { 21, "Bangalore University", 0, 6 },
                    { 22, "Mount Carmel College Autonomous", 0, 6 },
                    { 23, "Indian Institute Of Management–Bangalore", 0, 6 },
                    { 24, "R. V. College of Engineering", 0, 6 },
                    { 25, "Delhi University", 0, 2 },
                    { 26, "Jamia Millia Islamia", 0, 2 },
                    { 27, "Indian Institute Of Technology Delhi", 0, 2 },
                    { 28, "All India Institute Of Medical Sciences Delhi", 0, 2 },
                    { 29, "Delhi Technological University", 0, 2 },
                    { 30, "Jamia Hamdard University", 0, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_College_StateId",
                table: "College",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeCourses_CourseId",
                table: "CollegeCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseGroup_CollegeId",
                table: "CourseGroup",
                column: "CollegeId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseGroupId",
                table: "Courses",
                column: "CourseGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_CourseId",
                table: "Exams",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollegeCourses");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "CourseGroup");

            migrationBuilder.DropTable(
                name: "College");

            migrationBuilder.DropTable(
                name: "State");
        }
    }
}
