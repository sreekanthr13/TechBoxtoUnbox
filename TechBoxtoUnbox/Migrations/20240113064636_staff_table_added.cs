using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechBoxtoUnbox.Migrations
{
    /// <inheritdoc />
    public partial class staff_table_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    St_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    St_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    St_Gender = table.Column<bool>(type: "bit", nullable: false),
                    St_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    St_phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    St_DOJ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    St_DOE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.St_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
