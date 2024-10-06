using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Teste2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "alter",
                schema: "dbo",
                table: "SKU",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "alter",
                schema: "dbo",
                table: "SKU");
        }
    }
}
