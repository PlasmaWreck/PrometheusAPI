using Microsoft.EntityFrameworkCore;
using PrometheusAPI.Models;
using System.Collections.Generic;

namespace PrometheusAPI.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Login> Users { get; set; }
        public DbSet<GraphicsCard> GraphicsCards { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            var fixedData = new List<Login>(){
                new Login(){
                    Id=1,
                    Username="Angel",
                    Password="password"
                }
            };
            var graphicsCardFixedData = new List<GraphicsCard>(){
                //"Dual Link DVI-I", "HDMI 2.0b","Display Port 1.4","Display Port 1.4","Display Port 1.4"
                new GraphicsCard(){Id = 1, Name = "GeForce GTX 1080", GPU = "NVIDIA", CoreCount = 2560, CoreClockSpeed = 1607, MemoryType = "GDDR5X", MemorySize = 8, MemoryBandwith = 320, MotherBoardInterface = 256, ThermalDesignPower= 180, VideoOutputPorts = "", ComputePerformance = 9, Price = 1499}
            };
            builder.Entity<Login>().HasData(fixedData);
            builder.Entity<GraphicsCard>().HasData(graphicsCardFixedData);
        }
    }
}