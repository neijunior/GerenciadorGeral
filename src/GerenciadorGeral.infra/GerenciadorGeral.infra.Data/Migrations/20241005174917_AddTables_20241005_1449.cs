using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTables_20241005_1449 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CpfCnpj = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    RazaoSocial = table.Column<string>(type: "varchar(200)", nullable: false),
                    IdEndereco = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPai = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    styleCss = table.Column<string>(type: "varchar(200)", nullable: true),
                    Titulo = table.Column<string>(type: "varchar(75)", maxLength: 75, nullable: false),
                    Url = table.Column<string>(type: "varchar(200)", nullable: true),
                    Nivel = table.Column<int>(type: "int", nullable: false),
                    Ordem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnidadeMedida",
                schema: "dbo",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeMedida", x => x.Codigo);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UnidadeMedida",
                columns: new[] { "Codigo", "Descricao" },
                values: new object[,]
                {
                    { "G", "Grama" },
                    { "KG", "Quilograma" },
                    { "L", "Litro" },
                    { "ML", "Mililitro" },
                    { "UN", "Unidade" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fornecedor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Marca",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Menu",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UnidadeMedida",
                schema: "dbo");
        }
    }
}
