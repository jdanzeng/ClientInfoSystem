using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class UpdateClientTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Employees_EmployeeId",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Clients",
                newName: "AddedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_EmployeeId",
                table: "Clients",
                newName: "IX_Clients_AddedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Employees_AddedBy",
                table: "Clients",
                column: "AddedBy",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Employees_AddedBy",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "AddedBy",
                table: "Clients",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_AddedBy",
                table: "Clients",
                newName: "IX_Clients_EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Employees_EmployeeId",
                table: "Clients",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
