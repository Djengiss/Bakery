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
                    b.Property<int>("AddressesAddressId")
                        .HasColumnType("int");

                    b.Property<int>("DispatchRoutesDispatchId")
                        .HasColumnType("int");

                    b.HasKey("AddressesAddressId", "DispatchRoutesDispatchId");

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

                    b.Property<int>("BakingGoodGoodId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("EndTime")
                        .HasColumnType("int");

                    b.Property<int>("StartTime")
                        .HasColumnType("int");

                    b.Property<int>("TargetEndTime")
                        .HasColumnType("int");

                    b.HasKey("BatchId");

                    b.HasIndex("BakingGoodGoodId");

                    b.ToTable("Bathces");
                });

            modelBuilder.Entity("Bakery.Models.BakingGood", b =>
                {
                    b.Property<int>("GoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GoodId"));

                    b.Property<int>("DaysOfValidity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Recipe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GoodId");

                    b.ToTable("BakingGoods");
                });

            modelBuilder.Entity("Bakery.Models.BakingGoodIngredient", b =>
                {
                    b.Property<int>("GoodId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.HasKey("GoodId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("BakingGoodIngredients");
                });

            modelBuilder.Entity("Bakery.Models.BakingGoodPacket", b =>
                {
                    b.Property<int>("GoodId")
                        .HasColumnType("int");

                    b.Property<int>("PacketId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.HasKey("GoodId", "PacketId");

                    b.HasIndex("PacketId");

                    b.ToTable("BakingGoodPackets");
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

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("AddressId");

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
                        .HasForeignKey("AddressesAddressId")
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
                        .HasForeignKey("BakingGoodGoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BakingGood");
                });

            modelBuilder.Entity("Bakery.Models.BakingGoodIngredient", b =>
                {
                    b.HasOne("Bakery.Models.BakingGood", "BakingGood")
                        .WithMany("BakingGoodIngredients")
                        .HasForeignKey("GoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bakery.Models.Ingredients", "Ingredient")
                        .WithMany("BakingGoodIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BakingGood");

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("Bakery.Models.BakingGoodPacket", b =>
                {
                    b.HasOne("Bakery.Models.BakingGood", "BakingGood")
                        .WithMany("BakingGoodPackets")
                        .HasForeignKey("GoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bakery.Models.Packet", "Packet")
                        .WithMany("BakingGoodsPackets")
                        .HasForeignKey("PacketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BakingGood");

                    b.Navigation("Packet");
                });

            modelBuilder.Entity("Bakery.Models.Order", b =>
                {
                    b.HasOne("Bakery.Models.Address", "Address")
                        .WithMany("Orders")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
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
                    b.Navigation("BakingGoodIngredients");

                    b.Navigation("BakingGoodPackets");

                    b.Navigation("Batches");
                });

            modelBuilder.Entity("Bakery.Models.Ingredients", b =>
                {
                    b.Navigation("BakingGoodIngredients");
                });

            modelBuilder.Entity("Bakery.Models.Order", b =>
                {
                    b.Navigation("Packets");
                });

            modelBuilder.Entity("Bakery.Models.Packet", b =>
                {
                    b.Navigation("BakingGoodsPackets");
                });
#pragma warning restore 612, 618
        }
    }
}
