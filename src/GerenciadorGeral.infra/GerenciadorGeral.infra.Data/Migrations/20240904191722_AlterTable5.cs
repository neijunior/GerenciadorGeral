using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTable5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                schema: "dbo",
                table: "Fornecedor",
                newName: "RazaoSocial");

            migrationBuilder.AlterColumn<string>(
                name: "CpfCnpj",
                schema: "dbo",
                table: "Fornecedor",
                type: "varchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RazaoSocial",
                schema: "dbo",
                table: "Fornecedor",
                newName: "Nome");

            migrationBuilder.AlterColumn<string>(
                name: "CpfCnpj",
                schema: "dbo",
                table: "Fornecedor",
                type: "varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(14)",
                oldMaxLength: 14);
        }
    }
}
