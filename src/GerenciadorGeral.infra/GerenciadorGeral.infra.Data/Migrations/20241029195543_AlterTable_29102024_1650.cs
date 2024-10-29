using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTable_29102024_1650 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdInsumo",
                schema: "dbo",
                table: "SKU",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "InsumoId",
                schema: "dbo",
                table: "SKU",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SKU_InsumoId",
                schema: "dbo",
                table: "SKU",
                column: "InsumoId");

            migrationBuilder.AddForeignKey(
                name: "FK_SKU_Insumo_InsumoId",
                schema: "dbo",
                table: "SKU",
                column: "InsumoId",
                principalSchema: "dbo",
                principalTable: "Insumo",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SKU_Insumo_InsumoId",
                schema: "dbo",
                table: "SKU");

            migrationBuilder.DropIndex(
                name: "IX_SKU_InsumoId",
                schema: "dbo",
                table: "SKU");

            migrationBuilder.DropColumn(
                name: "IdInsumo",
                schema: "dbo",
                table: "SKU");

            migrationBuilder.DropColumn(
                name: "InsumoId",
                schema: "dbo",
                table: "SKU");
        }
    }
}
