﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrometheusAPI.Context;

namespace PrometheusAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210531220338_Changing to Bools")]
    partial class ChangingtoBools
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PrometheusAPI.Models.Case", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MBFormFactor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RGB")
                        .HasColumnType("bit");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("PrometheusAPI.Models.Cooler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LiquidCooling")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumOfFans")
                        .HasColumnType("int");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Coolers");
                });

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

            modelBuilder.Entity("PrometheusAPI.Models.HardDrive", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConnectionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiskSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Interface")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RPM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HardDrives");
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

            modelBuilder.Entity("PrometheusAPI.Models.Memory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Capacity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CellType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClockFrequency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StickType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Memories");
                });

            modelBuilder.Entity("PrometheusAPI.Models.MotherBoard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPUSocket")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Chipset")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormFactor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InBuiltWifi")
                        .HasColumnType("bit");

                    b.Property<bool>("M2NVMESupport")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PCIESlots")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAMSlots")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sata3Connectors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("USBPorts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoConnectors")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MotherBoards");
                });

            modelBuilder.Entity("PrometheusAPI.Models.OS", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstallMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OperatingSystems");
                });

            modelBuilder.Entity("PrometheusAPI.Models.OpticalDrive", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BluRay")
                        .HasColumnType("bit");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConnectionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OpticalDrives");
                });

            modelBuilder.Entity("PrometheusAPI.Models.PowerSupply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Efficiency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainConnectorType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Modular")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Power")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PowerSupplies");
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
