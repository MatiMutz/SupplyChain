using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Operarios",
                table: "Operarios");

            migrationBuilder.RenameTable(
                name: "Operarios",
                newName: "Operario");

            migrationBuilder.AlterColumn<decimal>(
                name: "VALOR_HORA",
                table: "Operario",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RENDIM",
                table: "Operario",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HS_FINAL",
                table: "Operario",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CG_TURNO",
                table: "Operario",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CG_CIA",
                table: "Operario",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Operario",
                table: "Operario",
                column: "CG_OPER");

            migrationBuilder.CreateTable(
                name: "CategoriaOperario",
                columns: table => new
                {
                    CG_CATEOP = table.Column<string>(maxLength: 20, nullable: false),
                    DES_CATEOP = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaOperario", x => x.CG_CATEOP);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaOperario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Operario",
                table: "Operario");

            migrationBuilder.RenameTable(
                name: "Operario",
                newName: "Operarios");

            migrationBuilder.AlterColumn<decimal>(
                name: "VALOR_HORA",
                table: "Operarios",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "RENDIM",
                table: "Operarios",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<int>(
                name: "HS_FINAL",
                table: "Operarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CG_TURNO",
                table: "Operarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CG_CIA",
                table: "Operarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Operarios",
                table: "Operarios",
                column: "CG_OPER");
        }
    }
}
