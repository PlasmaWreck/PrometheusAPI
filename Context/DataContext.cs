using Microsoft.EntityFrameworkCore;
using PrometheusAPI.Models;
using System.Collections.Generic;

namespace PrometheusAPI.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Login> Users { get; set; }
        public DbSet<GraphicsCard> GraphicsCards { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<HardDrive> HardDrives { get; set; }
        public DbSet<Memory> Memories { get; set; }
        public DbSet<MotherBoard> MotherBoards { get; set; }
        public DbSet<OS> OperatingSystems { get; set; }
        public DbSet<OpticalDrive> OpticalDrives { get; set; }
        public DbSet<Processor> Processors { get; set; }
        public DbSet<PowerSupply> PowerSupplies { get; set; }
        public DbSet<Cooler> Coolers { get; set; }
        public DbSet<SavedBuild> SavedBuilds { get; set; }

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
                new GraphicsCard(){Id = 1, Name = "NVIDIA GeForce GTX 1080", 
                GPU = "NVIDIA", CoreCount = 2560, CoreClockSpeed = "1607 MHz",
                MemoryType = "GDDR5X", 
                MemorySize = "8 GB", 
                MemorySpeed = "1251MHz", 
                MemoryBandwidth = "320.3 GB/s", 
                MemoryBus = "256 bit", 
                ThermalDesignPower= "180 W", 
                SuggestedPSU = "450 W", 
                VideoOutputPorts = "[\"1x DVI\",\"1x DisplayPort\",\"1x DisplayPort\",\"1x DisplayPort\",\"1x HDMI\"]", 
                PowerConnectors = "1x 8-pin", 
                ComputePerformance = "8.873 TFLOPS", 
                Price = "599 USD", 
                ImagePath = "/graphicscards/nvidiageforcegtx1080"}
            };
            var processorFixedData = new List<Processor>(){
                //"Dual Link DVI-I", "HDMI 2.0b","Display Port 1.4","Display Port 1.4","Display Port 1.4"
                new Processor(){Id = 1, 
                Name = "AMD Ryzen 5 3600", 
                Brand = "AMD", 
                CoreCount = 6,
                ThreadCount = 12,
                Transistors = "3,800 million",
                Frequency = "3.6 GHz",
                BaseClock = "100 Mhz",
                PCIExpress = "Gen 4",
                Socket = "AMD Socket AM4",
                MaxTemp = "95C",
                IntegratedGraphics = "N/A",
                MemorySupport = "DDR4-3200 MHz Dual-channel",
                ThermalDesignPower = "65 W",
                Price = "$0",
                ImagePath = "/processors/amdryzen53600"
                }
            };
            builder.Entity<Login>().HasData(fixedData);
            builder.Entity<GraphicsCard>().HasData(graphicsCardFixedData);
            builder.Entity<Processor>().HasData(processorFixedData);
        }
    }
}