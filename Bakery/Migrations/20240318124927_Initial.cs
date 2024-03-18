using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockAmount = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientId);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    DispatchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.DispatchId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryAddressAddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_DeliveryAddressAddressId",
                        column: x => x.DeliveryAddressAddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddressDispatchRoute",
                columns: table => new
                {
                    AddressesOnRouteAddressId = table.Column<int>(type: "int", nullable: false),
                    DispatchRoutesDispatchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressDispatchRoute", x => new { x.AddressesOnRouteAddressId, x.DispatchRoutesDispatchId });
                    table.ForeignKey(
                        name: "FK_AddressDispatchRoute_Addresses_AddressesOnRouteAddressId",
                        column: x => x.AddressesOnRouteAddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddressDispatchRoute_Routes_DispatchRoutesDispatchId",
                        column: x => x.DispatchRoutesDispatchId,
                        principalTable: "Routes",
                        principalColumn: "DispatchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Packets",
                columns: table => new
                {
                    PacketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrackId = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packets", x => x.PacketId);
                    table.ForeignKey(
                        name: "FK_Packets_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BakingGoodPacket",
                columns: table => new
                {
                    BakingGood_Packet_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsId = table.Column<int>(type: "int", nullable: false),
                    PacketId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BakingGood_Packet", x => x.BakingGood_Packet_Id);
                    table.ForeignKey(
                        name: "FK_BakingGood_Packet_Packets_PacketId",
                        column: x => x.PacketId,
                        principalTable: "Packets",
                        principalColumn: "PacketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BakingGoods",
                columns: table => new
                {
                    GoodsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Recipe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaysOfValidity = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PacketBakingGood_Packet_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BakingGoods", x => x.GoodsId);
                    table.ForeignKey(
                        name: "FK_BakingGoods_BakingGood_Packet_PacketBakingGood_Packet_Id",
                        column: x => x.PacketBakingGood_Packet_Id,
                        principalTable: "BakingGoodPacket",
                        principalColumn: "BakingGood_Packet_Id");
                });

            migrationBuilder.CreateTable(
                name: "Bathces",
                columns: table => new
                {
                    BatchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Start_time = table.Column<int>(type: "int", nullable: false),
                    Target_end_time = table.Column<int>(type: "int", nullable: false),
                    End_time = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    BakingGoodGoodsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bathces", x => x.BatchId);
                    table.ForeignKey(
                        name: "FK_Bathces_BakingGoods_BakingGoodGoodsId",
                        column: x => x.BakingGoodGoodsId,
                        principalTable: "BakingGoods",
                        principalColumn: "GoodsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BakingGoodIngredient",
                columns: table => new
                {
                    Ingredient_BakingGoo_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    BakingGoodGoodsId = table.Column<int>(type: "int", nullable: true),
                    IngredientsIngredientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient_BakingGood", x => x.Ingredient_BakingGoo_Id);
                    table.ForeignKey(
                        name: "FK_Ingredient_BakingGood_BakingGoods_BakingGoodGoodsId",
                        column: x => x.BakingGoodGoodsId,
                        principalTable: "BakingGoods",
                        principalColumn: "GoodsId");
                    table.ForeignKey(
                        name: "FK_Ingredient_BakingGood_Ingredients_IngredientsIngredientId",
                        column: x => x.IngredientsIngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressDispatchRoute_DispatchRoutesDispatchId",
                table: "AddressDispatchRoute",
                column: "DispatchRoutesDispatchId");

            migrationBuilder.CreateIndex(
                name: "IX_BakingGood_Packet_PacketId",
                table: "BakingGoodPacket",
                column: "PacketId");

            migrationBuilder.CreateIndex(
                name: "IX_BakingGoods_PacketBakingGood_Packet_Id",
                table: "BakingGoods",
                column: "PacketBakingGood_Packet_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bathces_BakingGoodGoodsId",
                table: "Bathces",
                column: "BakingGoodGoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_BakingGood_BakingGoodGoodsId",
                table: "BakingGoodIngredient",
                column: "BakingGoodGoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_BakingGood_IngredientsIngredientId",
                table: "BakingGoodIngredient",
                column: "IngredientsIngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeliveryAddressAddressId",
                table: "Orders",
                column: "DeliveryAddressAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Packets_OrderID",
                table: "Packets",
                column: "OrderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressDispatchRoute");

            migrationBuilder.DropTable(
                name: "Bathces");

            migrationBuilder.DropTable(
                name: "BakingGoodIngredient");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "BakingGoods");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "BakingGoodPacket");

            migrationBuilder.DropTable(
                name: "Packets");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
