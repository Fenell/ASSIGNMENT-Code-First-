using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_DAL.Migrations
{
    public partial class up2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Grades_IdStudent",
                table: "Grades");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_IdStudent",
                table: "Grades",
                column: "IdStudent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Grades_IdStudent",
                table: "Grades");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_IdStudent",
                table: "Grades",
                column: "IdStudent",
                unique: true);
        }
    }
}
