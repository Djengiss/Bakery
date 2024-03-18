using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery.Migrations
{
    /// <inheritdoc />
    public partial class Names : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressDispatchRoute_Addresses_AddressesOnRouteAddressId",
                table: "AddressDispatchRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_BakingGoodPacket_BakingGoods_BakingGoodsGoodsId",
                table: "BakingGoodPacket");

            migrationBuilder.DropForeignKey(
                name: "FK_BakingGoodPackets_BakingGoods_BakingGoodGoodsId",
                table: "BakingGoodPackets");

            migrationBuilder.DropForeignKey(
                name: "FK_Bathces_BakingGoods_BakingGoodGoodsId",
                table: "Bathces");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientBakingGoods_BakingGoods_BakingGoodGoodsId",
                table: "IngredientBakingGoods");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Addresses_DeliveryAddressAddressId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "DeliveryAddressAddressId",
                table: "Orders",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_DeliveryAddressAddressId",
                table: "Orders",
                newName: "IX_Orders_AddressId");

            migrationBuilder.RenameColumn(
                name: "BakingGoodGoodsId",
                table: "IngredientBakingGoods",
                newName: "BakingGoodGoodId");

            migrationBuilder.RenameColumn(
                name: "GoodsId",
                table: "IngredientBakingGoods",
                newName: "GoodId");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientBakingGoods_BakingGoodGoodsId",
                table: "IngredientBakingGoods",
                newName: "IX_IngredientBakingGoods_BakingGoodGoodId");

            migrationBuilder.RenameColumn(
                name: "Target_end_time",
                table: "Bathces",
                newName: "TargetEndTime");

            migrationBuilder.RenameColumn(
                name: "Start_time",
                table: "Bathces",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "End_time",
                table: "Bathces",
                newName: "EndTime");

            migrationBuilder.RenameColumn(
                name: "BakingGoodGoodsId",
                table: "Bathces",
                newName: "BakingGoodGoodId");

            migrationBuilder.RenameIndex(
                name: "IX_Bathces_BakingGoodGoodsId",
                table: "Bathces",
                newName: "IX_Bathces_BakingGoodGoodId");

            migrationBuilder.RenameColumn(
                name: "GoodsId",
                table: "BakingGoods",
                newName: "GoodId");

            migrationBuilder.RenameColumn(
                name: "BakingGoodGoodsId",
                table: "BakingGoodPackets",
                newName: "BakingGoodGoodId");

            migrationBuilder.RenameColumn(
                name: "GoodsId",
                table: "BakingGoodPackets",
                newName: "GoodId");

            migrationBuilder.RenameIndex(
                name: "IX_BakingGoodPackets_BakingGoodGoodsId",
                table: "BakingGoodPackets",
                newName: "IX_BakingGoodPackets_BakingGoodGoodId");

            migrationBuilder.RenameColumn(
                name: "BakingGoodsGoodsId",
                table: "BakingGoodPacket",
                newName: "BakingGoodsGoodId");

            migrationBuilder.RenameColumn(
                name: "AddressesOnRouteAddressId",
                table: "AddressDispatchRoute",
                newName: "AddressesAddressId");

            migrationBuilder.CreateTable(
                name: "BakingGoodIngredients",
                columns: table => new
                {
                    BakingGoodsGoodId = table.Column<int>(type: "int", nullable: false),
                    IngredientsIngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BakingGoodIngredients", x => new { x.BakingGoodsGoodId, x.IngredientsIngredientId });
                    table.ForeignKey(
                        name: "FK_BakingGoodIngredients_BakingGoods_BakingGoodsGoodId",
                        column: x => x.BakingGoodsGoodId,
                        principalTable: "BakingGoods",
                        principalColumn: "GoodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BakingGoodIngredients_Ingredients_IngredientsIngredientId",
                        column: x => x.IngredientsIngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BakingGoodIngredients_IngredientsIngredientId",
                table: "BakingGoodIngredients",
                column: "IngredientsIngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressDispatchRoute_Addresses_AddressesAddressId",
                table: "AddressDispatchRoute",
                column: "AddressesAddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BakingGoodPacket_BakingGoods_BakingGoodsGoodId",
                table: "BakingGoodPacket",
                column: "BakingGoodsGoodId",
                principalTable: "BakingGoods",
                principalColumn: "GoodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BakingGoodPackets_BakingGoods_BakingGoodGoodId",
                table: "BakingGoodPackets",
                column: "BakingGoodGoodId",
                principalTable: "BakingGoods",
                principalColumn: "GoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bathces_BakingGoods_BakingGoodGoodId",
                table: "Bathces",
                column: "BakingGoodGoodId",
                principalTable: "BakingGoods",
                principalColumn: "GoodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientBakingGoods_BakingGoods_BakingGoodGoodId",
                table: "IngredientBakingGoods",
                column: "BakingGoodGoodId",
                principalTable: "BakingGoods",
                principalColumn: "GoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressDispatchRoute_Addresses_AddressesAddressId",
                table: "AddressDispatchRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_BakingGoodPacket_BakingGoods_BakingGoodsGoodId",
                table: "BakingGoodPacket");

            migrationBuilder.DropForeignKey(
                name: "FK_BakingGoodPackets_BakingGoods_BakingGoodGoodId",
                table: "BakingGoodPackets");

            migrationBuilder.DropForeignKey(
                name: "FK_Bathces_BakingGoods_BakingGoodGoodId",
                table: "Bathces");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientBakingGoods_BakingGoods_BakingGoodGoodId",
                table: "IngredientBakingGoods");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "BakingGoodIngredients");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Orders",
                newName: "DeliveryAddressAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_AddressId",
                table: "Orders",
                newName: "IX_Orders_DeliveryAddressAddressId");

            migrationBuilder.RenameColumn(
                name: "BakingGoodGoodId",
                table: "IngredientBakingGoods",
                newName: "BakingGoodGoodsId");

            migrationBuilder.RenameColumn(
                name: "GoodId",
                table: "IngredientBakingGoods",
                newName: "GoodsId");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientBakingGoods_BakingGoodGoodId",
                table: "IngredientBakingGoods",
                newName: "IX_IngredientBakingGoods_BakingGoodGoodsId");

            migrationBuilder.RenameColumn(
                name: "TargetEndTime",
                table: "Bathces",
                newName: "Target_end_time");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "Bathces",
                newName: "Start_time");

            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "Bathces",
                newName: "End_time");

            migrationBuilder.RenameColumn(
                name: "BakingGoodGoodId",
                table: "Bathces",
                newName: "BakingGoodGoodsId");

            migrationBuilder.RenameIndex(
                name: "IX_Bathces_BakingGoodGoodId",
                table: "Bathces",
                newName: "IX_Bathces_BakingGoodGoodsId");

            migrationBuilder.RenameColumn(
                name: "GoodId",
                table: "BakingGoods",
                newName: "GoodsId");

            migrationBuilder.RenameColumn(
                name: "BakingGoodGoodId",
                table: "BakingGoodPackets",
                newName: "BakingGoodGoodsId");

            migrationBuilder.RenameColumn(
                name: "GoodId",
                table: "BakingGoodPackets",
                newName: "GoodsId");

            migrationBuilder.RenameIndex(
                name: "IX_BakingGoodPackets_BakingGoodGoodId",
                table: "BakingGoodPackets",
                newName: "IX_BakingGoodPackets_BakingGoodGoodsId");

            migrationBuilder.RenameColumn(
                name: "BakingGoodsGoodId",
                table: "BakingGoodPacket",
                newName: "BakingGoodsGoodsId");

            migrationBuilder.RenameColumn(
                name: "AddressesAddressId",
                table: "AddressDispatchRoute",
                newName: "AddressesOnRouteAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressDispatchRoute_Addresses_AddressesOnRouteAddressId",
                table: "AddressDispatchRoute",
                column: "AddressesOnRouteAddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BakingGoodPacket_BakingGoods_BakingGoodsGoodsId",
                table: "BakingGoodPacket",
                column: "BakingGoodsGoodsId",
                principalTable: "BakingGoods",
                principalColumn: "GoodsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BakingGoodPackets_BakingGoods_BakingGoodGoodsId",
                table: "BakingGoodPackets",
                column: "BakingGoodGoodsId",
                principalTable: "BakingGoods",
                principalColumn: "GoodsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bathces_BakingGoods_BakingGoodGoodsId",
                table: "Bathces",
                column: "BakingGoodGoodsId",
                principalTable: "BakingGoods",
                principalColumn: "GoodsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientBakingGoods_BakingGoods_BakingGoodGoodsId",
                table: "IngredientBakingGoods",
                column: "BakingGoodGoodsId",
                principalTable: "BakingGoods",
                principalColumn: "GoodsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Addresses_DeliveryAddressAddressId",
                table: "Orders",
                column: "DeliveryAddressAddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
