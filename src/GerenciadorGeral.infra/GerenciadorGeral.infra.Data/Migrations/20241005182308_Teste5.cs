using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Teste5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SKU",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<string>(type: "varchar(200)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CodigoUnidadeMedida = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    Quantidade = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    IdMarca = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SKU", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SKU_Marca_IdMarca",
                        column: x => x.IdMarca,
                        principalSchema: "dbo",
                        principalTable: "Marca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SKU_UnidadeMedida_CodigoUnidadeMedida",
                        column: x => x.CodigoUnidadeMedida,
                        principalSchema: "dbo",
                        principalTable: "UnidadeMedida",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SKU_CodigoUnidadeMedida",
                schema: "dbo",
                table: "SKU",
                column: "CodigoUnidadeMedida");

            migrationBuilder.CreateIndex(
                name: "IX_SKU_IdMarca",
                schema: "dbo",
                table: "SKU",
                column: "IdMarca");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SKU",
                schema: "dbo");
        }
    }
}
