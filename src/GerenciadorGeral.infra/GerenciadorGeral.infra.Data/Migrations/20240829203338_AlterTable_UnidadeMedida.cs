using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTable_UnidadeMedida : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UnidadeMedidas",
                table: "UnidadeMedidas");

            migrationBuilder.RenameTable(
                name: "UnidadeMedidas",
                newName: "UnidadeMedida");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnidadeMedida",
                table: "UnidadeMedida",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UnidadeMedida",
                table: "UnidadeMedida");

            migrationBuilder.RenameTable(
                name: "UnidadeMedida",
                newName: "UnidadeMedidas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnidadeMedidas",
                table: "UnidadeMedidas",
                column: "Id");
        }
    }
}
