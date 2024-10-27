using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTable_27102024_1919 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Insumo",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insumo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeParaInsumoSKU",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSKU = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdInsumo = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeParaInsumoSKU", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeParaInsumoSKU_Insumo_IdInsumo",
                        column: x => x.IdInsumo,
                        principalSchema: "dbo",
                        principalTable: "Insumo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeParaInsumoSKU_SKU_IdSKU",
                        column: x => x.IdSKU,
                        principalSchema: "dbo",
                        principalTable: "SKU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeParaInsumoSKU_IdInsumo",
                schema: "dbo",
                table: "DeParaInsumoSKU",
                column: "IdInsumo");

            migrationBuilder.CreateIndex(
                name: "IX_DeParaInsumoSKU_IdSKU",
                schema: "dbo",
                table: "DeParaInsumoSKU",
                column: "IdSKU");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeParaInsumoSKU",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Insumo",
                schema: "dbo");
        }
    }
}
