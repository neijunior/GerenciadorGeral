using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedor",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CpfCnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdEndereco = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SKU",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    UnidadeMedida = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SKU", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdFornecedor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Desconto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compra_Fornecedor_IdFornecedor",
                        column: x => x.IdFornecedor,
                        principalSchema: "dbo",
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompraItem",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCompra = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSku = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnidadeMedida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantidadePorUnidadeMedida = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantidadePorUnidadeMedidaTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantidade = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Desconto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompraItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompraItem_Compra_Id",
                        column: x => x.Id,
                        principalSchema: "dbo",
                        principalTable: "Compra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompraItem_SKU_Id",
                        column: x => x.Id,
                        principalSchema: "dbo",
                        principalTable: "SKU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_Compra_IdFornecedor",
                schema: "dbo",
                table: "Compra",
                column: "IdFornecedor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompraItem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Compra",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SKU",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Fornecedor",
                schema: "dbo");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UnidadeMedida",
                keyColumn: "Codigo",
                keyValue: "G");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UnidadeMedida",
                keyColumn: "Codigo",
                keyValue: "KG");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UnidadeMedida",
                keyColumn: "Codigo",
                keyValue: "L");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UnidadeMedida",
                keyColumn: "Codigo",
                keyValue: "ML");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UnidadeMedida",
                keyColumn: "Codigo",
                keyValue: "UN");
        }
    }
}
