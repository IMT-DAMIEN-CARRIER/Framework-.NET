using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp1.Migrations
{
    public partial class addcommandetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Commandes_CommandeId",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_CommandeId",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "CommandeId",
                table: "Pizzas");

            migrationBuilder.AddColumn<int>(
                name: "PizzaId",
                table: "Commandes",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_PizzaId",
                table: "Commandes",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commandes_Pizzas_PizzaId",
                table: "Commandes",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commandes_Pizzas_PizzaId",
                table: "Commandes");

            migrationBuilder.DropIndex(
                name: "IX_Commandes_PizzaId",
                table: "Commandes");

            migrationBuilder.DropColumn(
                name: "PizzaId",
                table: "Commandes");

            migrationBuilder.AddColumn<int>(
                name: "CommandeId",
                table: "Pizzas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CommandeId",
                table: "Pizzas",
                column: "CommandeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Commandes_CommandeId",
                table: "Pizzas",
                column: "CommandeId",
                principalTable: "Commandes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
