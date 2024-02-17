using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfilionStudentManagement.Migrations
{
    /// <inheritdoc />
    public partial class _170220241 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class",
                table: "TblStudents");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Class",
                table: "TblStudents",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
