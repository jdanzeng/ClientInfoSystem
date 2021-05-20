using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ChangeColName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interactions_Employees_EmployeeId",
                table: "Interactions");

            migrationBuilder.DropIndex(
                name: "IX_Clients_Name",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Interactions",
                newName: "EmplId");

            migrationBuilder.RenameIndex(
                name: "IX_Interactions_EmployeeId",
                table: "Interactions",
                newName: "IX_Interactions_EmplId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interactions_Employees_EmplId",
                table: "Interactions",
                column: "EmplId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interactions_Employees_EmplId",
                table: "Interactions");

            migrationBuilder.RenameColumn(
                name: "EmplId",
                table: "Interactions",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Interactions_EmplId",
                table: "Interactions",
                newName: "IX_Interactions_EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_Name",
                table: "Clients",
                column: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Interactions_Employees_EmployeeId",
                table: "Interactions",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
