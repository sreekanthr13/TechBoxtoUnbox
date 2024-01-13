using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechBoxtoUnbox.Migrations
{
    /// <inheritdoc />
    public partial class updted_cfee_float_to_double : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "CFee",
                table: "Courses",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "CFee",
                table: "Courses",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
