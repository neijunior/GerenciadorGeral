using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTable_SKU_25102024_1348 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeItemProduzido",
                schema: "dbo",
                table: "CustoProducao");

            migrationBuilder.AddColumn<Guid>(
                name: "IdSKU",
                schema: "dbo",
                table: "CustoProducao",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_CustoProducao_IdSKU",
                schema: "dbo",
                table: "CustoProducao",
                column: "IdSKU");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropIndex(
                name: "IX_CustoProducao_IdSKU",
                schema: "dbo",
                table: "CustoProducao");

            migrationBuilder.DropColumn(
                name: "IdSKU",
                schema: "dbo",
                table: "CustoProducao");

            migrationBuilder.AddColumn<string>(
                name: "NomeItemProduzido",
                schema: "dbo",
                table: "CustoProducao",
                type: "varchar(200)",
                nullable: false,
                defaultValue: "");
        }
    }
}
