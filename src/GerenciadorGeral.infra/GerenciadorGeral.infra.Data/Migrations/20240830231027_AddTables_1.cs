using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTables_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompraItem_Compra_Id",
                schema: "dbo",
                table: "CompraItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CompraItem_SKU_Id",
                schema: "dbo",
                table: "CompraItem");

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

            migrationBuilder.AddForeignKey(
                name: "FK_CompraItem_Compra_IdCompra",
                schema: "dbo",
                table: "CompraItem",
                column: "IdCompra",
                principalSchema: "dbo",
                principalTable: "Compra",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompraItem_SKU_IdSku",
                schema: "dbo",
                table: "CompraItem",
                column: "IdSku",
                principalSchema: "dbo",
                principalTable: "SKU",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompraItem_Compra_IdCompra",
                schema: "dbo",
                table: "CompraItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CompraItem_SKU_IdSku",
                schema: "dbo",
                table: "CompraItem");

            migrationBuilder.DropIndex(
                name: "IX_CompraItem_IdCompra",
                schema: "dbo",
                table: "CompraItem");

            migrationBuilder.DropIndex(
                name: "IX_CompraItem_IdSku",
                schema: "dbo",
                table: "CompraItem");

            migrationBuilder.AddForeignKey(
                name: "FK_CompraItem_Compra_Id",
                schema: "dbo",
                table: "CompraItem",
                column: "Id",
                principalSchema: "dbo",
                principalTable: "Compra",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompraItem_SKU_Id",
                schema: "dbo",
                table: "CompraItem",
                column: "Id",
                principalSchema: "dbo",
                principalTable: "SKU",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
