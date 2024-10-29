using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTable_29102024_1736 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdInsumo",
                schema: "dbo",
                table: "SKU",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SKU_IdInsumo",
                schema: "dbo",
                table: "SKU",
                column: "IdInsumo");

            migrationBuilder.AddForeignKey(
                name: "FK_SKU_Insumo_IdInsumo",
                schema: "dbo",
                table: "SKU",
                column: "IdInsumo",
                principalSchema: "dbo",
                principalTable: "Insumo",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SKU_Insumo_IdInsumo",
                schema: "dbo",
                table: "SKU");

            migrationBuilder.DropIndex(
                name: "IX_SKU_IdInsumo",
                schema: "dbo",
                table: "SKU");

            migrationBuilder.DropColumn(
                name: "IdInsumo",
                schema: "dbo",
                table: "SKU");
        }
    }
}
