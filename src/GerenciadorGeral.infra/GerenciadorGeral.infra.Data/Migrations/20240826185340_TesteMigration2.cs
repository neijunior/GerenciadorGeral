using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class TesteMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_sku",
                schema: "dbo",
                table: "sku");

            migrationBuilder.RenameTable(
                name: "sku",
                schema: "dbo",
                newName: "Sku",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sku",
                schema: "dbo",
                table: "Sku",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sku",
                schema: "dbo",
                table: "Sku");

            migrationBuilder.RenameTable(
                name: "Sku",
                schema: "dbo",
                newName: "sku",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sku",
                schema: "dbo",
                table: "sku",
                column: "Id");
        }
    }
}
