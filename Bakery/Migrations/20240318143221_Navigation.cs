using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery.Migrations
{
    /// <inheritdoc />
    public partial class Navigation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BakingGoodIngredients_BakingGoods_BakingGoodsGoodId",
                table: "BakingGoodIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_BakingGoodIngredients_Ingredients_IngredientsIngredientId",
                table: "BakingGoodIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_BakingGoodPackets_BakingGoods_BakingGoodGoodId",
                table: "BakingGoodPackets");

            migrationBuilder.DropTable(
                name: "BakingGoodPacket");

            migrationBuilder.DropTable(
                name: "IngredientBakingGoods");

            migrationBuilder.DropIndex(
                name: "IX_BakingGoodPackets_BakingGoodGoodId",
                table: "BakingGoodPackets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BakingGoodIngredients",
                table: "BakingGoodIngredients");

            migrationBuilder.DropIndex(
                name: "IX_BakingGoodIngredients_IngredientsIngredientId",
                table: "BakingGoodIngredients");

            migrationBuilder.DropColumn(
                name: "BakingGoodGoodId",
                table: "BakingGoodPackets");

            migrationBuilder.RenameColumn(
                name: "IngredientsIngredientId",
                table: "BakingGoodIngredients",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "BakingGoodsGoodId",
                table: "BakingGoodIngredients",
                newName: "IngredientId");

            migrationBuilder.AddColumn<int>(
                name: "GoodId",
                table: "BakingGoodIngredients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BakingGoodIngredients",
                table: "BakingGoodIngredients",
                columns: new[] { "GoodId", "IngredientId" });

            migrationBuilder.CreateIndex(
                name: "IX_BakingGoodIngredients_IngredientId",
                table: "BakingGoodIngredients",
                column: "IngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_BakingGoodIngredients_BakingGoods_GoodId",
                table: "BakingGoodIngredients",
                column: "GoodId",
                principalTable: "BakingGoods",
                principalColumn: "GoodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BakingGoodIngredients_Ingredients_IngredientId",
                table: "BakingGoodIngredients",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "IngredientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BakingGoodPackets_BakingGoods_GoodId",
                table: "BakingGoodPackets",
                column: "GoodId",
                principalTable: "BakingGoods",
                principalColumn: "GoodId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BakingGoodIngredients_BakingGoods_GoodId",
                table: "BakingGoodIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_BakingGoodIngredients_Ingredients_IngredientId",
                table: "BakingGoodIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_BakingGoodPackets_BakingGoods_GoodId",
                table: "BakingGoodPackets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BakingGoodIngredients",
                table: "BakingGoodIngredients");

            migrationBuilder.DropIndex(
                name: "IX_BakingGoodIngredients_IngredientId",
                table: "BakingGoodIngredients");

            migrationBuilder.DropColumn(
                name: "GoodId",
                table: "BakingGoodIngredients");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "BakingGoodIngredients",
                newName: "IngredientsIngredientId");

            migrationBuilder.RenameColumn(
                name: "IngredientId",
                table: "BakingGoodIngredients",
                newName: "BakingGoodsGoodId");

            migrationBuilder.AddColumn<int>(
                name: "BakingGoodGoodId",
                table: "BakingGoodPackets",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BakingGoodIngredients",
                table: "BakingGoodIngredients",
                columns: new[] { "BakingGoodsGoodId", "IngredientsIngredientId" });

            migrationBuilder.CreateTable(
                name: "BakingGoodPacket",
                columns: table => new
                {
                    BakingGoodsGoodId = table.Column<int>(type: "int", nullable: false),
                    PacketsPacketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BakingGoodPacket", x => new { x.BakingGoodsGoodId, x.PacketsPacketId });
                    table.ForeignKey(
                        name: "FK_BakingGoodPacket_BakingGoods_BakingGoodsGoodId",
                        column: x => x.BakingGoodsGoodId,
                        principalTable: "BakingGoods",
                        principalColumn: "GoodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BakingGoodPacket_Packets_PacketsPacketId",
                        column: x => x.PacketsPacketId,
                        principalTable: "Packets",
                        principalColumn: "PacketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientBakingGoods",
                columns: table => new
                {
                    GoodId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    BakingGoodGoodId = table.Column<int>(type: "int", nullable: true),
                    IngredientsIngredientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientBakingGoods", x => new { x.GoodId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_IngredientBakingGoods_BakingGoods_BakingGoodGoodId",
                        column: x => x.BakingGoodGoodId,
                        principalTable: "BakingGoods",
                        principalColumn: "GoodId");
                    table.ForeignKey(
                        name: "FK_IngredientBakingGoods_Ingredients_IngredientsIngredientId",
                        column: x => x.IngredientsIngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BakingGoodPackets_BakingGoodGoodId",
                table: "BakingGoodPackets",
                column: "BakingGoodGoodId");

            migrationBuilder.CreateIndex(
                name: "IX_BakingGoodIngredients_IngredientsIngredientId",
                table: "BakingGoodIngredients",
                column: "IngredientsIngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_BakingGoodPacket_PacketsPacketId",
                table: "BakingGoodPacket",
                column: "PacketsPacketId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientBakingGoods_BakingGoodGoodId",
                table: "IngredientBakingGoods",
                column: "BakingGoodGoodId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientBakingGoods_IngredientsIngredientId",
                table: "IngredientBakingGoods",
                column: "IngredientsIngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_BakingGoodIngredients_BakingGoods_BakingGoodsGoodId",
                table: "BakingGoodIngredients",
                column: "BakingGoodsGoodId",
                principalTable: "BakingGoods",
                principalColumn: "GoodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BakingGoodIngredients_Ingredients_IngredientsIngredientId",
                table: "BakingGoodIngredients",
                column: "IngredientsIngredientId",
                principalTable: "Ingredients",
                principalColumn: "IngredientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BakingGoodPackets_BakingGoods_BakingGoodGoodId",
                table: "BakingGoodPackets",
                column: "BakingGoodGoodId",
                principalTable: "BakingGoods",
                principalColumn: "GoodId");
        }
    }
}
