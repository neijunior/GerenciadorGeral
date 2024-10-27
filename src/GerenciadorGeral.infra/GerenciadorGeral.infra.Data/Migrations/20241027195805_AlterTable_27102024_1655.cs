using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTable_27102024_1655 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustoProducaoDetalhe",
                schema: "dbo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustoProducaoDetalhe",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustoAquisicaoItem = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    CustoProducaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ValorCustoProducao = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    qtdUtilizada = table.Column<decimal>(type: "decimal(16,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustoProducaoDetalhe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustoProducaoDetalhe_CustoProducao_CustoProducaoId",
                        column: x => x.CustoProducaoId,
                        principalSchema: "dbo",
                        principalTable: "CustoProducao",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustoProducaoDetalhe_CustoProducaoId",
                schema: "dbo",
                table: "CustoProducaoDetalhe",
                column: "CustoProducaoId");
        }
    }
}
