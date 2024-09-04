using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTable3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Teste",
                schema: "dbo",
                table: "UnidadeMedida",
                type: "varchar(200)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "UnidadeMedida",
                keyColumn: "Codigo",
                keyValue: "G",
                column: "Teste",
                value: "");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "UnidadeMedida",
                keyColumn: "Codigo",
                keyValue: "KG",
                column: "Teste",
                value: "");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "UnidadeMedida",
                keyColumn: "Codigo",
                keyValue: "L",
                column: "Teste",
                value: "");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "UnidadeMedida",
                keyColumn: "Codigo",
                keyValue: "ML",
                column: "Teste",
                value: "");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "UnidadeMedida",
                keyColumn: "Codigo",
                keyValue: "UN",
                column: "Teste",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Teste",
                schema: "dbo",
                table: "UnidadeMedida");
        }
    }
}
