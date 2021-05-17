﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrometheusAPI.Context;

namespace PrometheusAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PrometheusAPI.Models.GraphicsCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ComputePerformance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoreClockSpeed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CoreCount")
                        .HasColumnType("int");

                    b.Property<string>("GPU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemoryBandwidth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemoryBus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemorySize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemorySpeed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemoryType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PowerConnectors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuggestedPSU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThermalDesignPower")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoOutputPorts")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GraphicsCards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ComputePerformance = "8.873 TFLOPS",
                            CoreClockSpeed = "1607 MHz",
                            CoreCount = 2560,
                            GPU = "NVIDIA",
                            ImagePath = "/graphicscards/nvidiageforcegtx1080",
                            MemoryBandwidth = "320.3 GB/s",
                            MemoryBus = "256 bit",
                            MemorySize = "8 GB",
                            MemorySpeed = "1251MHz",
                            MemoryType = "GDDR5X",
                            Name = "NVIDIA GeForce GTX 1080",
                            PowerConnectors = "1x 8-pin",
                            Price = "599 USD",
                            SuggestedPSU = "450 W",
                            ThermalDesignPower = "180 W",
                            VideoOutputPorts = "[\"1x DVI\",\"1x DisplayPort\",\"1x DisplayPort\",\"1x DisplayPort\",\"1x HDMI\"]"
                        });
                });

            modelBuilder.Entity("PrometheusAPI.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Angel",
                            Password = "password"
                        });
                });

            modelBuilder.Entity("PrometheusAPI.Models.Processor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BaseClock")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CoreCount")
                        .HasColumnType("int");

                    b.Property<string>("Frequency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntegratedGraphics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaxTemp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemorySupport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PCIExpress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Socket")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThermalDesignPower")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThreadCount")
                        .HasColumnType("int");

                    b.Property<string>("Transistors")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Processors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BaseClock = "100 Mhz",
                            Brand = "AMD",
                            CoreCount = 6,
                            Frequency = "3.6 GHz",
                            ImagePath = "/processors/amdryzen53600",
                            IntegratedGraphics = "N/A",
                            MaxTemp = "95C",
                            MemorySupport = "DDR4-3200 MHz Dual-channel",
                            Name = "AMD Ryzen 5 3600",
                            PCIExpress = "Gen 4",
                            Price = "$0",
                            Socket = "AMD Socket AM4",
                            ThermalDesignPower = "65 W",
                            ThreadCount = 12,
                            Transistors = "3,800 million"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
