using Microsoft.EntityFrameworkCore.Migrations;

namespace ChefsNDishes.Migrations
{
    public partial class FixDishrelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Dishes_CreatorDishId",
                table: "Dishes");

            migrationBuilder.DropIndex(
                name: "IX_Dishes_CreatorDishId",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "CreatorDishId",
                table: "Dishes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatorDishId",
                table: "Dishes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_CreatorDishId",
                table: "Dishes",
                column: "CreatorDishId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Dishes_CreatorDishId",
                table: "Dishes",
                column: "CreatorDishId",
                principalTable: "Dishes",
                principalColumn: "DishId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
