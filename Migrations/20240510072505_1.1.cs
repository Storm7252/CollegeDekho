using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JD.com.Migrations
{
    /// <inheritdoc />
    public partial class _11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseGroup_College_CollegeId",
                table: "CourseGroup");

            migrationBuilder.DropIndex(
                name: "IX_CourseGroup_CollegeId",
                table: "CourseGroup");

            migrationBuilder.DropColumn(
                name: "CollegeId",
                table: "CourseGroup");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CollegeId",
                table: "CourseGroup",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseGroup_CollegeId",
                table: "CourseGroup",
                column: "CollegeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseGroup_College_CollegeId",
                table: "CourseGroup",
                column: "CollegeId",
                principalTable: "College",
                principalColumn: "CollegeId");
        }
    }
}
