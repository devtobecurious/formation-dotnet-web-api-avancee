using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace ORMDecouverte.Migrations
{
    /// <inheritdoc />
    public partial class WookieeWeapon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WeaponId",
                table: "Wookies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Wookies_WeaponId",
                table: "Wookies",
                column: "WeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wookies_Weapon_WeaponId",
                table: "Wookies",
                column: "WeaponId",
                principalTable: "Weapon",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wookies_Weapon_WeaponId",
                table: "Wookies");

            migrationBuilder.DropTable(
                name: "Weapon");

            migrationBuilder.DropIndex(
                name: "IX_Wookies_WeaponId",
                table: "Wookies");

            migrationBuilder.DropColumn(
                name: "WeaponId",
                table: "Wookies");
        }
    }
}
