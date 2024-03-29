﻿using Microsoft.EntityFrameworkCore.Migrations;

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
                table: "BakingGoodIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_BakingGood_Ingredients_IngredientsIngredientId",
                table: "BakingGoodIngredient");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_BakingGood_BakingGoodGoodsId",
                table: "BakingGoodIngredient");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_BakingGood_IngredientsIngredientId",
                table: "BakingGoodIngredient");

            migrationBuilder.DropIndex(
                name: "IX_BakingGoods_PacketBakingGood_Packet_Id",
                table: "BakingGoods");

            migrationBuilder.DropColumn(
                name: "BakingGoodGoodsId",
                table: "BakingGoodIngredient");

            migrationBuilder.DropColumn(
                name: "IngredientsIngredientId",
                table: "BakingGoodIngredient");

            migrationBuilder.DropColumn(
                name: "PacketBakingGood_Packet_Id",
                table: "BakingGoods");

            migrationBuilder.RenameColumn(
                name: "Ingredient_BakingGoo_Id",
                table: "BakingGoodIngredient",
                newName: "Ingredient_BakingGood_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_BakingGood_GoodsId",
                table: "BakingGoodIngredient",
                column: "GoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_BakingGood_IngredientId",
                table: "BakingGoodIngredient",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_BakingGood_Packet_GoodsId",
                table: "BakingGoodPacket",
                column: "GoodsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BakingGood_Packet_BakingGoods_GoodsId",
                table: "BakingGoodPacket",
                column: "GoodsId",
                principalTable: "BakingGoods",
                principalColumn: "GoodsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_BakingGood_BakingGoods_GoodsId",
                table: "BakingGoodIngredient",
                column: "GoodsId",
                principalTable: "BakingGoods",
                principalColumn: "GoodsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_BakingGood_Ingredients_IngredientId",
                table: "BakingGoodIngredient",
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
                table: "BakingGoodPacket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_BakingGood_BakingGoods_GoodsId",
                table: "BakingGoodIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_BakingGood_Ingredients_IngredientId",
                table: "BakingGoodIngredient");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_BakingGood_GoodsId",
                table: "BakingGoodIngredient");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_BakingGood_IngredientId",
                table: "BakingGoodIngredient");

            migrationBuilder.DropIndex(
                name: "IX_BakingGood_Packet_GoodsId",
                table: "BakingGoodPacket");

            migrationBuilder.RenameColumn(
                name: "Ingredient_BakingGood_Id",
                table: "BakingGoodIngredient",
                newName: "Ingredient_BakingGoo_Id");

            migrationBuilder.AddColumn<int>(
                name: "BakingGoodGoodsId",
                table: "BakingGoodIngredient",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IngredientsIngredientId",
                table: "BakingGoodIngredient",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PacketBakingGood_Packet_Id",
                table: "BakingGoods",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_BakingGood_BakingGoodGoodsId",
                table: "BakingGoodIngredient",
                column: "BakingGoodGoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_BakingGood_IngredientsIngredientId",
                table: "BakingGoodIngredient",
                column: "IngredientsIngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_BakingGoods_PacketBakingGood_Packet_Id",
                table: "BakingGoods",
                column: "PacketBakingGood_Packet_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BakingGoods_BakingGood_Packet_PacketBakingGood_Packet_Id",
                table: "BakingGoods",
                column: "PacketBakingGood_Packet_Id",
                principalTable: "BakingGoodPacket",
                principalColumn: "BakingGood_Packet_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_BakingGood_BakingGoods_BakingGoodGoodsId",
                table: "BakingGoodIngredient",
                column: "BakingGoodGoodsId",
                principalTable: "BakingGoods",
                principalColumn: "GoodsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_BakingGood_Ingredients_IngredientsIngredientId",
                table: "BakingGoodIngredient",
                column: "IngredientsIngredientId",
                principalTable: "Ingredients",
                principalColumn: "IngredientId");
        }
    }
}
