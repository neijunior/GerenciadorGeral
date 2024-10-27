using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTable_27102024_1719 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustoProducao",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSKU = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCalculo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustoProducao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustoProducao_SKU_IdSKU",
                        column: x => x.IdSKU,
                        principalSchema: "dbo",
                        principalTable: "SKU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustoProducao_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalSchema: "dbo",
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustoProducaoDetalhe",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCustoProducao = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSKU = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    qtdUtilizada = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    CustoAquisicaoItem = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    ValorCustoProducao = table.Column<decimal>(type: "decimal(16,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustoProducaoDetalhe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustoProducaoDetalhe_CustoProducao_IdCustoProducao",
                        column: x => x.IdCustoProducao,
                        principalSchema: "dbo",
                        principalTable: "CustoProducao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustoProducaoDetalhe_SKU_IdSKU",
                        column: x => x.IdSKU,
                        principalSchema: "dbo",
                        principalTable: "SKU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustoProducao_IdSKU",
                schema: "dbo",
                table: "CustoProducao",
                column: "IdSKU");

            migrationBuilder.CreateIndex(
                name: "IX_CustoProducao_IdUsuario",
                schema: "dbo",
                table: "CustoProducao",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_CustoProducaoDetalhe_IdCustoProducao",
                schema: "dbo",
                table: "CustoProducaoDetalhe",
                column: "IdCustoProducao");

            migrationBuilder.CreateIndex(
                name: "IX_CustoProducaoDetalhe_IdSKU",
                schema: "dbo",
                table: "CustoProducaoDetalhe",
                column: "IdSKU");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustoProducaoDetalhe",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CustoProducao",
                schema: "dbo");
        }
    }
}
