using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery.Migrations
{
    /// <inheritdoc />
    public partial class FixtoWeakRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BakingGoods_BakingGood_Packet_PacketBakingGood_Packet_Id",
                table: "BakingGoods");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_BakingGood_BakingGoods_BakingGoodGoodsId",
                table: "Ingredient_BakingGood");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_BakingGood_Ingredients_IngredientsIngredientId",
                table: "Ingredient_BakingGood");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_BakingGood_BakingGoodGoodsId",
                table: "Ingredient_BakingGood");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_BakingGood_IngredientsIngredientId",
                table: "Ingredient_BakingGood");

            migrationBuilder.DropIndex(
                name: "IX_BakingGoods_PacketBakingGood_Packet_Id",
                table: "BakingGoods");

            migrationBuilder.DropColumn(
                name: "BakingGoodGoodsId",
                table: "Ingredient_BakingGood");

            migrationBuilder.DropColumn(
                name: "IngredientsIngredientId",
                table: "Ingredient_BakingGood");

            migrationBuilder.DropColumn(
                name: "PacketBakingGood_Packet_Id",
                table: "BakingGoods");

            migrationBuilder.RenameColumn(
                name: "Ingredient_BakingGoo_Id",
                table: "Ingredient_BakingGood",
                newName: "Ingredient_BakingGood_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_BakingGood_GoodsId",
                table: "Ingredient_BakingGood",
                column: "GoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_BakingGood_IngredientId",
                table: "Ingredient_BakingGood",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_BakingGood_Packet_GoodsId",
                table: "BakingGood_Packet",
                column: "GoodsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BakingGood_Packet_BakingGoods_GoodsId",
                table: "BakingGood_Packet",
                column: "GoodsId",
                principalTable: "BakingGoods",
                principalColumn: "GoodsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_BakingGood_BakingGoods_GoodsId",
                table: "Ingredient_BakingGood",
                column: "GoodsId",
                principalTable: "BakingGoods",
                principalColumn: "GoodsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_BakingGood_Ingredients_IngredientId",
                table: "Ingredient_BakingGood",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "IngredientId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BakingGood_Packet_BakingGoods_GoodsId",
                table: "BakingGood_Packet");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_BakingGood_BakingGoods_GoodsId",
                table: "Ingredient_BakingGood");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_BakingGood_Ingredients_IngredientId",
                table: "Ingredient_BakingGood");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_BakingGood_GoodsId",
                table: "Ingredient_BakingGood");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_BakingGood_IngredientId",
                table: "Ingredient_BakingGood");

            migrationBuilder.DropIndex(
                name: "IX_BakingGood_Packet_GoodsId",
                table: "BakingGood_Packet");

            migrationBuilder.RenameColumn(
                name: "Ingredient_BakingGood_Id",
                table: "Ingredient_BakingGood",
                newName: "Ingredient_BakingGoo_Id");

            migrationBuilder.AddColumn<int>(
                name: "BakingGoodGoodsId",
                table: "Ingredient_BakingGood",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IngredientsIngredientId",
                table: "Ingredient_BakingGood",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PacketBakingGood_Packet_Id",
                table: "BakingGoods",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_BakingGood_BakingGoodGoodsId",
                table: "Ingredient_BakingGood",
                column: "BakingGoodGoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_BakingGood_IngredientsIngredientId",
                table: "Ingredient_BakingGood",
                column: "IngredientsIngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_BakingGoods_PacketBakingGood_Packet_Id",
                table: "BakingGoods",
                column: "PacketBakingGood_Packet_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BakingGoods_BakingGood_Packet_PacketBakingGood_Packet_Id",
                table: "BakingGoods",
                column: "PacketBakingGood_Packet_Id",
                principalTable: "BakingGood_Packet",
                principalColumn: "BakingGood_Packet_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_BakingGood_BakingGoods_BakingGoodGoodsId",
                table: "Ingredient_BakingGood",
                column: "BakingGoodGoodsId",
                principalTable: "BakingGoods",
                principalColumn: "GoodsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_BakingGood_Ingredients_IngredientsIngredientId",
                table: "Ingredient_BakingGood",
                column: "IngredientsIngredientId",
                principalTable: "Ingredients",
                principalColumn: "IngredientId");
        }
    }
}
