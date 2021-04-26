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
                    Email="Angel",
                    Password="password"
                }
            };
            var graphicsCardFixedData = new List<GraphicsCard>(){
                //"Dual Link DVI-I", "HDMI 2.0b","Display Port 1.4","Display Port 1.4","Display Port 1.4"
                new GraphicsCard(){Id = 1, Name = "NVIDIA GeForce GTX 1080", GPU = "NVIDIA", CoreCount = 2560, CoreClockSpeed = "1607 MHz", MemoryType = "GDDR5X", MemorySize = "8 GB", MemorySpeed = "1251MHz", MemoryBandwidth = "320.3 GB/s", MemoryBus = "256 bit", ThermalDesignPower= "180 W", SuggestedPSU = "450 W", VideoOutputPorts = "[\"1x DVI\",\"1x DisplayPort\",\"1x DisplayPort\",\"1x DisplayPort\",\"1x HDMI\"]", PowerConnectors = "1x 8-pin", ComputePerformance = "8.873 TFLOPS", Price = "599 USD", ImagePath = "/graphicscards/nvidiageforcegtx1080"}
            };
            builder.Entity<Login>().HasData(fixedData);
            builder.Entity<GraphicsCard>().HasData(graphicsCardFixedData);
        }
    }
}