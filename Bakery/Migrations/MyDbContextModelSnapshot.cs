﻿// <auto-generated />
using System;
using Bakery.db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bakery.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AddressDispatchRoute", b =>
                {
                    b.Property<int>("AddressesOnRouteAddressId")
                        .HasColumnType("int");

                    b.Property<int>("DispatchRoutesDispatchId")
                        .HasColumnType("int");

                    b.HasKey("AddressesOnRouteAddressId", "DispatchRoutesDispatchId");

                    b.HasIndex("DispatchRoutesDispatchId");

                    b.ToTable("AddressDispatchRoute");
                });

            modelBuilder.Entity("Bakery.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Bakery.Models.BakeryBatch", b =>
                {
                    b.Property<int>("BatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BatchId"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("BakingGoodGoodsId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("End_time")
                        .HasColumnType("int");

                    b.Property<int>("Start_time")
                        .HasColumnType("int");

                    b.Property<int>("Target_end_time")
                        .HasColumnType("int");

                    b.HasKey("BatchId");

                    b.HasIndex("BakingGoodGoodsId");

                    b.ToTable("Bathces");
                });

            modelBuilder.Entity("Bakery.Models.BakingGood", b =>
                {
                    b.Property<int>("GoodsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GoodsId"));

                    b.Property<int>("DaysOfValidity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PacketBakingGood_Packet_Id")
                        .HasColumnType("int");

                    b.Property<string>("Recipe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GoodsId");

                    b.HasIndex("PacketBakingGood_Packet_Id");

                    b.ToTable("BakingGoods");
                });

            modelBuilder.Entity("Bakery.Models.BakingGood_Packet", b =>
                {
                    b.Property<int>("BakingGood_Packet_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BakingGood_Packet_Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("GoodsId")
                        .HasColumnType("int");

                    b.Property<int>("PacketId")
                        .HasColumnType("int");

                    b.HasKey("BakingGood_Packet_Id");

                    b.HasIndex("PacketId");

                    b.ToTable("BakingGood_Packet");
                });

            modelBuilder.Entity("Bakery.Models.DispatchRoute", b =>
                {
                    b.Property<int>("DispatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DispatchId"));

                    b.HasKey("DispatchId");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("Bakery.Models.Ingredient_BakingGood", b =>
                {
                    b.Property<int>("Ingredient_BakingGoo_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ingredient_BakingGoo_Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("BakingGoodGoodsId")
                        .HasColumnType("int");

                    b.Property<int>("GoodsId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int?>("IngredientsIngredientId")
                        .HasColumnType("int");

                    b.HasKey("Ingredient_BakingGoo_Id");

                    b.HasIndex("BakingGoodGoodsId");

                    b.HasIndex("IngredientsIngredientId");

                    b.ToTable("Ingredient_BakingGood");
                });

            modelBuilder.Entity("Bakery.Models.Ingredients", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StockAmount")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IngredientId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Bakery.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<int>("DeliveryAddressAddressId")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("DeliveryAddressAddressId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Bakery.Models.Packet", b =>
                {
                    b.Property<int>("PacketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PacketId"));

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.HasKey("PacketId");

                    b.HasIndex("OrderID");

                    b.ToTable("Packets");
                });

            modelBuilder.Entity("AddressDispatchRoute", b =>
                {
                    b.HasOne("Bakery.Models.Address", null)
                        .WithMany()
                        .HasForeignKey("AddressesOnRouteAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bakery.Models.DispatchRoute", null)
                        .WithMany()
                        .HasForeignKey("DispatchRoutesDispatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bakery.Models.BakeryBatch", b =>
                {
                    b.HasOne("Bakery.Models.BakingGood", "BakingGood")
                        .WithMany("Batches")
                        .HasForeignKey("BakingGoodGoodsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BakingGood");
                });

            modelBuilder.Entity("Bakery.Models.BakingGood", b =>
                {
                    b.HasOne("Bakery.Models.BakingGood_Packet", "Packet")
                        .WithMany()
                        .HasForeignKey("PacketBakingGood_Packet_Id");

                    b.Navigation("Packet");
                });

            modelBuilder.Entity("Bakery.Models.BakingGood_Packet", b =>
                {
                    b.HasOne("Bakery.Models.Packet", null)
                        .WithMany("BackingGood")
                        .HasForeignKey("PacketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bakery.Models.Ingredient_BakingGood", b =>
                {
                    b.HasOne("Bakery.Models.BakingGood", null)
                        .WithMany("Ingredeients")
                        .HasForeignKey("BakingGoodGoodsId");

                    b.HasOne("Bakery.Models.Ingredients", null)
                        .WithMany("BakingGood")
                        .HasForeignKey("IngredientsIngredientId");
                });

            modelBuilder.Entity("Bakery.Models.Order", b =>
                {
                    b.HasOne("Bakery.Models.Address", "DeliveryAddress")
                        .WithMany("Orders")
                        .HasForeignKey("DeliveryAddressAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeliveryAddress");
                });

            modelBuilder.Entity("Bakery.Models.Packet", b =>
                {
                    b.HasOne("Bakery.Models.Order", "Order")
                        .WithMany("Packets")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Bakery.Models.Address", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Bakery.Models.BakingGood", b =>
                {
                    b.Navigation("Batches");

                    b.Navigation("Ingredeients");
                });

            modelBuilder.Entity("Bakery.Models.Ingredients", b =>
                {
                    b.Navigation("BakingGood");
                });

            modelBuilder.Entity("Bakery.Models.Order", b =>
                {
                    b.Navigation("Packets");
                });

            modelBuilder.Entity("Bakery.Models.Packet", b =>
                {
                    b.Navigation("BackingGood");
                });
#pragma warning restore 612, 618
        }
    }
}