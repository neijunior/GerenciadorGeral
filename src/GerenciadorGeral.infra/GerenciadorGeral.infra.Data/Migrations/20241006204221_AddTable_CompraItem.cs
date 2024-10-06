using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTable_CompraItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompraItem",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCompra = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSku = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    Quantidade = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    Desconto = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(16,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompraItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompraItem_Compra_IdCompra",
                        column: x => x.IdCompra,
                        principalSchema: "dbo",
                        principalTable: "Compra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompraItem_SKU_IdSku",
                        column: x => x.IdSku,
                        principalSchema: "dbo",
                        principalTable: "SKU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompraItem_IdCompra",
                schema: "dbo",
                table: "CompraItem",
                column: "IdCompra");

            migrationBuilder.CreateIndex(
                name: "IX_CompraItem_IdSku",
                schema: "dbo",
                table: "CompraItem",
                column: "IdSku");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompraItem",
                schema: "dbo");
        }
    }
}
