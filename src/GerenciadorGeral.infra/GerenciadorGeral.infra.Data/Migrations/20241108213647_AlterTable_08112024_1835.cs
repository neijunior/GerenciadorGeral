using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTable_08112024_1835 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "IdSKU",
                schema: "dbo",
                table: "CustoProducaoDetalhe",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "IdInsumo",
                schema: "dbo",
                table: "CustoProducaoDetalhe",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustoProducaoDetalhe_IdInsumo",
                schema: "dbo",
                table: "CustoProducaoDetalhe",
                column: "IdInsumo");

            migrationBuilder.AddForeignKey(
                name: "FK_CustoProducaoDetalhe_Insumo_IdInsumo",
                schema: "dbo",
                table: "CustoProducaoDetalhe",
                column: "IdInsumo",
                principalSchema: "dbo",
                principalTable: "Insumo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustoProducaoDetalhe_Insumo_IdInsumo",
                schema: "dbo",
                table: "CustoProducaoDetalhe");

            migrationBuilder.DropIndex(
                name: "IX_CustoProducaoDetalhe_IdInsumo",
                schema: "dbo",
                table: "CustoProducaoDetalhe");

            migrationBuilder.DropColumn(
                name: "IdInsumo",
                schema: "dbo",
                table: "CustoProducaoDetalhe");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdSKU",
                schema: "dbo",
                table: "CustoProducaoDetalhe",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);
        }
    }
}
