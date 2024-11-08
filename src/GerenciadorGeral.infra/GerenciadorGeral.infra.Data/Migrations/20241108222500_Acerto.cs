using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorGeral.infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Acerto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "UnidadeMedidaCodigo",
                schema: "dbo",
                table: "Insumo");

            migrationBuilder.AlterColumn<string>(
                name: "CodigoUnidadeMedida",
                schema: "dbo",
                table: "Insumo",
                type: "varchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)");

            migrationBuilder.CreateIndex(
                name: "IX_Insumo_CodigoUnidadeMedida",
                schema: "dbo",
                table: "Insumo",
                column: "CodigoUnidadeMedida");

            migrationBuilder.AddForeignKey(
                name: "FK_Insumo_UnidadeMedida_CodigoUnidadeMedida",
                schema: "dbo",
                table: "Insumo",
                column: "CodigoUnidadeMedida",
                principalSchema: "dbo",
                principalTable: "UnidadeMedida",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insumo_UnidadeMedida_CodigoUnidadeMedida",
                schema: "dbo",
                table: "Insumo");

            migrationBuilder.DropIndex(
                name: "IX_Insumo_CodigoUnidadeMedida",
                schema: "dbo",
                table: "Insumo");

            migrationBuilder.AlterColumn<string>(
                name: "CodigoUnidadeMedida",
                schema: "dbo",
                table: "Insumo",
                type: "varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AddColumn<string>(
                name: "UnidadeMedidaCodigo",
                schema: "dbo",
                table: "Insumo",
                type: "varchar(5)",
                nullable: true);

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
    }
}
