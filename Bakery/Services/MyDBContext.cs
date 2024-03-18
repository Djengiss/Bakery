using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Bakery.Models;
using Bakery.Services;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;


namespace Bakery.db
{
    public class MyDbContext : DbContext
    {
        private const string SQL_DATABASE_NAME = "NewBakeryDB";
        private const string USER_ID = "SA";
        private static readonly string USER_PASSWORD = File.ReadAllText("secrets.txt").Trim();
        private static readonly string HOST_ADDRESS = "localhost,1433";

        private static readonly string CONN_STR = $"Data Source={HOST_ADDRESS};Database={SQL_DATABASE_NAME};User ID={USER_ID};Password={USER_PASSWORD};TrustServerCertificate=True";
        private static readonly string CONN_STR_DBSYS = $"Data Source={HOST_ADDRESS};User ID={USER_ID};Password={USER_PASSWORD};TrustServerCertificate=True";

        internal DbSet<Address> Addresses { get; set; }
        internal DbSet<BakeryBatch> Bathces { get; set; }
        internal DbSet<BakingGood> BakingGoods { get; set; }
        internal DbSet<DispatchRoute> Routes { get; set; }
        internal DbSet<Ingredients> Ingredients { get; set; }
        internal DbSet<Order> Orders { get; set; }
        internal DbSet<Packet> Packets { get; set; }
        internal DbSet<BakingGoodPacket> BakingGoodPackets { get; set; }
        internal DbSet<BakingGoodIngredient> BakingGoodIngredients { get; set; }

        // Composite key
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BakingGoodPacket>()
                .HasKey(bp => new { bp.GoodId, bp.PacketId });
            modelBuilder.Entity<BakingGoodPacket>()
                .HasOne(bp => bp.BakingGood)
                .WithMany(bg => bg.BakingGoodPackets)
                .HasForeignKey(bp => bp.GoodId);

            modelBuilder.Entity<BakingGoodPacket>()
                .HasOne(bp => bp.Packet)
                .WithMany(p => p.BakingGoodsPackets)
                .HasForeignKey(bp => bp.PacketId);
            ///////

            modelBuilder.Entity<BakingGoodIngredient>()
                .HasKey(bg => new { bg.GoodId, bg.IngredientId });

            modelBuilder.Entity<BakingGoodIngredient>()
                .HasOne(bg => bg.BakingGood)
                .WithMany(g => g.BakingGoodIngredients)
                .HasForeignKey(bg => bg.GoodId);

            modelBuilder.Entity<BakingGoodIngredient>()
                .HasOne(bg => bg.Ingredient)
                .WithMany(i => i.BakingGoodIngredients)
                .HasForeignKey(bg => bg.IngredientId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options
                .UseSqlServer(CONN_STR);
        
    }
}