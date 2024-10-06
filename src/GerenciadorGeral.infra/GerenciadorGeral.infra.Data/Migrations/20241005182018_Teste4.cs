using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Teste4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SKU",
                schema: "dbo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SKU",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MarcaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnidadeMedidaCodigo = table.Column<string>(type: "varchar(5)", nullable: true),
                    Codigo = table.Column<string>(type: "varchar(200)", nullable: false),
                    CodigoUnidadeMedida = table.Column<string>(type: "varchar(200)", nullable: false),
                    IdMarca = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Quantidade = table.Column<decimal>(type: "decimal(16,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SKU", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SKU_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalSchema: "dbo",
                        principalTable: "Marca",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SKU_UnidadeMedida_UnidadeMedidaCodigo",
                        column: x => x.UnidadeMedidaCodigo,
                        principalSchema: "dbo",
                        principalTable: "UnidadeMedida",
                        principalColumn: "Codigo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SKU_MarcaId",
                schema: "dbo",
                table: "SKU",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_SKU_UnidadeMedidaCodigo",
                schema: "dbo",
                table: "SKU",
                column: "UnidadeMedidaCodigo");
        }
    }
}
