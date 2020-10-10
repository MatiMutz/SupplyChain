using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Operarios",
                columns: table => new
                {
                    CG_OPER = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DES_OPER = table.Column<string>(maxLength: 500, nullable: true),
                    CG_TURNO = table.Column<int>(nullable: true),
                    RENDIM = table.Column<decimal>(nullable: true),
                    FE_FINAL = table.Column<DateTime>(nullable: true),
                    HS_FINAL = table.Column<int>(nullable: true),
                    CG_CATEOP = table.Column<string>(maxLength: 20, nullable: true),
                    VALOR_HORA = table.Column<decimal>(nullable: true),
                    MONEDA = table.Column<string>(maxLength: 20, nullable: true),
                    ACTIVO = table.Column<bool>(nullable: false),
                    CG_CIA = table.Column<int>(nullable: true),
                    USUARIO = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operarios", x => x.CG_OPER);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Operarios");
        }
    }
}
