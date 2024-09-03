using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "UnidadeMedida",
                newName: "UnidadeMedida",
                newSchema: "dbo");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                schema: "dbo",
                table: "UnidadeMedida",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                schema: "dbo",
                table: "UnidadeMedida",
                type: "varchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UnidadeMedida",
                columns: new[] { "Id", "Codigo", "Descricao" },
                values: new object[,]
                {
                    { 1, "KG", "Quilograma" },
                    { 2, "G", "Grama" },
                    { 3, "UN", "Unidade" },
                    { 4, "L", "Litro" },
                    { 5, "ML", "Mililitro" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UnidadeMedida",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UnidadeMedida",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UnidadeMedida",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UnidadeMedida",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UnidadeMedida",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.RenameTable(
                name: "UnidadeMedida",
                schema: "dbo",
                newName: "UnidadeMedida");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "UnidadeMedida",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "UnidadeMedida",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldMaxLength: 5);
        }
    }
}
