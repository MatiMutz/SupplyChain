using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class thirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoriaOperario",
                table: "CategoriaOperario");

            migrationBuilder.RenameTable(
                name: "CategoriaOperario",
                newName: "CateOperarios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CateOperarios",
                table: "CateOperarios",
                column: "CG_CATEOP");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Usuario = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CateOperarios",
                table: "CateOperarios");

            migrationBuilder.RenameTable(
                name: "CateOperarios",
                newName: "CategoriaOperario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoriaOperario",
                table: "CategoriaOperario",
                column: "CG_CATEOP");
        }
    }
}
