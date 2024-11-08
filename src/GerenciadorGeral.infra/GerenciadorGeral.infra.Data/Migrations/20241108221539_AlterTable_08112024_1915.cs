using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTable_08112024_1915 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustoProducaoDetalhe_SKU_IdSKU",
                schema: "dbo",
                table: "CustoProducaoDetalhe");

            migrationBuilder.DropIndex(
                name: "IX_CustoProducaoDetalhe_IdSKU",
                schema: "dbo",
                table: "CustoProducaoDetalhe");

            migrationBuilder.DropColumn(
                name: "IdSKU",
                schema: "dbo",
                table: "CustoProducaoDetalhe");

            migrationBuilder.RenameColumn(
                name: "qtdUtilizada",
                schema: "dbo",
                table: "CustoProducaoDetalhe",
                newName: "QuantidadeUtilizada");

            migrationBuilder.AddColumn<string>(
                name: "CodigoUnidadeMedida",
                schema: "dbo",
                table: "Insumo",
                type: "varchar(200)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UnidadeMedidaCodigo",
                schema: "dbo",
                table: "Insumo",
                type: "varchar(5)",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdInsumo",
                schema: "dbo",
                table: "CustoProducaoDetalhe",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Insumo_UnidadeMedidaCodigo",
                schema: "dbo",
                table: "Insumo",
                column: "UnidadeMedidaCodigo");

            migrationBuilder.AddForeignKey(
                name: "FK_Insumo_UnidadeMedida_UnidadeMedidaCodigo",
                schema: "dbo",
                table: "Insumo",
                column: "UnidadeMedidaCodigo",
                principalSchema: "dbo",
                principalTable: "UnidadeMedida",
                principalColumn: "Codigo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insumo_UnidadeMedida_UnidadeMedidaCodigo",
                schema: "dbo",
                table: "Insumo");

            migrationBuilder.DropIndex(
                name: "IX_Insumo_UnidadeMedidaCodigo",
                schema: "dbo",
                table: "Insumo");

            migrationBuilder.DropColumn(
                name: "CodigoUnidadeMedida",
                schema: "dbo",
                table: "Insumo");

            migrationBuilder.DropColumn(
                name: "UnidadeMedidaCodigo",
                schema: "dbo",
                table: "Insumo");

            migrationBuilder.RenameColumn(
                name: "QuantidadeUtilizada",
                schema: "dbo",
                table: "CustoProducaoDetalhe",
                newName: "qtdUtilizada");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdInsumo",
                schema: "dbo",
                table: "CustoProducaoDetalhe",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "IdSKU",
                schema: "dbo",
                table: "CustoProducaoDetalhe",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustoProducaoDetalhe_IdSKU",
                schema: "dbo",
                table: "CustoProducaoDetalhe",
                column: "IdSKU");

            migrationBuilder.AddForeignKey(
                name: "FK_CustoProducaoDetalhe_SKU_IdSKU",
                schema: "dbo",
                table: "CustoProducaoDetalhe",
                column: "IdSKU",
                principalSchema: "dbo",
                principalTable: "SKU",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
