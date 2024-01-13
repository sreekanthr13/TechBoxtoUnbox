using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechBoxtoUnbox.Migrations
{
    /// <inheritdoc />
    public partial class updated_cfee_double_to_float : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "CFee",
                table: "Courses",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "CFee",
                table: "Courses",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
