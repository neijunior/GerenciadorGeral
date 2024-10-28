using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTable_28102024_0000 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "qtdUtilizada",
                schema: "dbo",
                table: "CustoProducaoDetalhe",
                type: "decimal(8,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(16,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "qtdUtilizada",
                schema: "dbo",
                table: "CustoProducaoDetalhe",
                type: "decimal(16,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,4)");
        }
    }
}
