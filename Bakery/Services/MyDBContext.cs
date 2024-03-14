using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Bakery.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Bakery.db
{
    public class MyDbContext : DbContext
    {
        const string SQL_DATABASE_NAME = "BakeryDB";
        const string USER_ID = "SA";
        const string USER_PASSWORD = "BAKERYPASS";
        const string HOST_ADDRESS = "localhoost,1433";
        const string CONN_STR = $"Data Source={HOST_ADDRESS};Database={SQL_DATABASE_NAME};User ID={USER_ID};Password={USER_PASSWORD};TrustServerCertificate=True";
        const string CONN_STR_DBSYS = $"Data Source={HOST_ADDRESS};User ID={USER_ID};Password={USER_PASSWORD};TrustServerCertificate=True";
        internal DbSet<Address> Addresses { get; set; }
        internal DbSet<BakeryBatch> Bathces { get; set; }
        internal DbSet<BakingGood> BakingGoods { get; set; }
        internal DbSet<DispatchRoute> Routes { get; set; }
        internal DbSet<Ingredients> Ingredients { get; set; }
        internal DbSet<Order> Orders { get; set; }
        internal DbSet<Packet> Packets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options
                .UseSqlServer(CONN_STR);
    }
}