using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class actualizar_tablas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Clientes_CienteClienteId",
                table: "Facturas");

            migrationBuilder.RenameColumn(
                name: "CienteClienteId",
                table: "Facturas",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Facturas_CienteClienteId",
                table: "Facturas",
                newName: "IX_Facturas_ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Clientes_ClienteId",
                table: "Facturas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Clientes_ClienteId",
                table: "Facturas");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Facturas",
                newName: "CienteClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Facturas_ClienteId",
                table: "Facturas",
                newName: "IX_Facturas_CienteClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Clientes_CienteClienteId",
                table: "Facturas",
                column: "CienteClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
