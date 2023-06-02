using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ORMDecouverte.Migrations
{
    /// <inheritdoc />
    public partial class EnumLevel2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Level",
                table: "Weapon",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Level",
                table: "Weapon");
        }
    }
}
