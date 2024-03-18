using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BakingGood_Packet_BakingGoods_GoodsId",
                table: "BakingGood_Packet");

            migrationBuilder.DropForeignKey(
                name: "FK_BakingGood_Packet_Packets_PacketId",
                table: "BakingGood_Packet");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_BakingGood_BakingGoods_GoodsId",
                table: "Ingredient_BakingGood");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_BakingGood_Ingredients_IngredientId",
                table: "Ingredient_BakingGood");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredient_BakingGood",
                table: "Ingredient_BakingGood");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_BakingGood_GoodsId",
                table: "Ingredient_BakingGood");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_BakingGood_IngredientId",
                table: "Ingredient_BakingGood");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BakingGood_Packet",
                table: "BakingGood_Packet");

            migrationBuilder.DropIndex(
                name: "IX_BakingGood_Packet_GoodsId",
                table: "BakingGood_Packet");

            migrationBuilder.DropColumn(
                name: "Ingredient_BakingGood_Id",
                table: "Ingredient_BakingGood");

            migrationBuilder.DropColumn(
                name: "BakingGood_Packet_Id",
                table: "BakingGood_Packet");

            migrationBuilder.RenameTable(
                name: "Ingredient_BakingGood",
                newName: "IngredientBakingGoods");

            migrationBuilder.RenameTable(
                name: "BakingGood_Packet",
                newName: "BakingGoodPackets");

            migrationBuilder.RenameIndex(
                name: "IX_BakingGood_Packet_PacketId",
                table: "BakingGoodPackets",
                newName: "IX_BakingGoodPackets_PacketId");

            migrationBuilder.AddColumn<int>(
                name: "BakingGoodGoodsId",
                table: "IngredientBakingGoods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IngredientsIngredientId",
                table: "IngredientBakingGoods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BakingGoodGoodsId",
                table: "BakingGoodPackets",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngredientBakingGoods",
                table: "IngredientBakingGoods",
                columns: new[] { "GoodsId", "IngredientId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BakingGoodPackets",
                table: "BakingGoodPackets",
                columns: new[] { "GoodsId", "PacketId" });

            migrationBuilder.CreateTable(
                name: "BakingGoodPacket",
                columns: table => new
                {
                    BakingGoodsGoodsId = table.Column<int>(type: "int", nullable: false),
                    PacketsPacketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BakingGoodPacket", x => new { x.BakingGoodsGoodsId, x.PacketsPacketId });
                    table.ForeignKey(
                        name: "FK_BakingGoodPacket_BakingGoods_BakingGoodsGoodsId",
                        column: x => x.BakingGoodsGoodsId,
                        principalTable: "BakingGoods",
                        principalColumn: "GoodsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BakingGoodPacket_Packets_PacketsPacketId",
                        column: x => x.PacketsPacketId,
                        principalTable: "Packets",
                        principalColumn: "PacketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientBakingGoods_BakingGoodGoodsId",
                table: "IngredientBakingGoods",
                column: "BakingGoodGoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientBakingGoods_IngredientsIngredientId",
                table: "IngredientBakingGoods",
                column: "IngredientsIngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_BakingGoodPackets_BakingGoodGoodsId",
                table: "BakingGoodPackets",
                column: "BakingGoodGoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_BakingGoodPacket_PacketsPacketId",
                table: "BakingGoodPacket",
                column: "PacketsPacketId");

            migrationBuilder.AddForeignKey(
                name: "FK_BakingGoodPackets_BakingGoods_BakingGoodGoodsId",
                table: "BakingGoodPackets",
                column: "BakingGoodGoodsId",
                principalTable: "BakingGoods",
                principalColumn: "GoodsId");

            migrationBuilder.AddForeignKey(
                name: "FK_BakingGoodPackets_Packets_PacketId",
                table: "BakingGoodPackets",
                column: "PacketId",
                principalTable: "Packets",
                principalColumn: "PacketId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientBakingGoods_BakingGoods_BakingGoodGoodsId",
                table: "IngredientBakingGoods",
                column: "BakingGoodGoodsId",
                principalTable: "BakingGoods",
                principalColumn: "GoodsId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientBakingGoods_Ingredients_IngredientsIngredientId",
                table: "IngredientBakingGoods",
                column: "IngredientsIngredientId",
                principalTable: "Ingredients",
                principalColumn: "IngredientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BakingGoodPackets_BakingGoods_BakingGoodGoodsId",
                table: "BakingGoodPackets");

            migrationBuilder.DropForeignKey(
                name: "FK_BakingGoodPackets_Packets_PacketId",
                table: "BakingGoodPackets");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientBakingGoods_BakingGoods_BakingGoodGoodsId",
                table: "IngredientBakingGoods");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientBakingGoods_Ingredients_IngredientsIngredientId",
                table: "IngredientBakingGoods");

            migrationBuilder.DropTable(
                name: "BakingGoodPacket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngredientBakingGoods",
                table: "IngredientBakingGoods");

            migrationBuilder.DropIndex(
                name: "IX_IngredientBakingGoods_BakingGoodGoodsId",
                table: "IngredientBakingGoods");

            migrationBuilder.DropIndex(
                name: "IX_IngredientBakingGoods_IngredientsIngredientId",
                table: "IngredientBakingGoods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BakingGoodPackets",
                table: "BakingGoodPackets");

            migrationBuilder.DropIndex(
                name: "IX_BakingGoodPackets_BakingGoodGoodsId",
                table: "BakingGoodPackets");

            migrationBuilder.DropColumn(
                name: "BakingGoodGoodsId",
                table: "IngredientBakingGoods");

            migrationBuilder.DropColumn(
                name: "IngredientsIngredientId",
                table: "IngredientBakingGoods");

            migrationBuilder.DropColumn(
                name: "BakingGoodGoodsId",
                table: "BakingGoodPackets");

            migrationBuilder.RenameTable(
                name: "IngredientBakingGoods",
                newName: "Ingredient_BakingGood");

            migrationBuilder.RenameTable(
                name: "BakingGoodPackets",
                newName: "BakingGood_Packet");

            migrationBuilder.RenameIndex(
                name: "IX_BakingGoodPackets_PacketId",
                table: "BakingGood_Packet",
                newName: "IX_BakingGood_Packet_PacketId");

            migrationBuilder.AddColumn<int>(
                name: "Ingredient_BakingGood_Id",
                table: "Ingredient_BakingGood",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "BakingGood_Packet_Id",
                table: "BakingGood_Packet",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredient_BakingGood",
                table: "Ingredient_BakingGood",
                column: "Ingredient_BakingGood_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BakingGood_Packet",
                table: "BakingGood_Packet",
                column: "BakingGood_Packet_Id");

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
                name: "FK_BakingGood_Packet_Packets_PacketId",
                table: "BakingGood_Packet",
                column: "PacketId",
                principalTable: "Packets",
                principalColumn: "PacketId",
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
    }
}
