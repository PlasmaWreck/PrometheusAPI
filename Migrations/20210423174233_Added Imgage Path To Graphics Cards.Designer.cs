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
    [Migration("20210423174233_Added Imgage Path To Graphics Cards")]
    partial class AddedImgagePathToGraphicsCards
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("ComputePerformance")
                        .HasColumnType("int");

                    b.Property<int>("CoreClockSpeed")
                        .HasColumnType("int");

                    b.Property<int>("CoreCount")
                        .HasColumnType("int");

                    b.Property<string>("GPU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MemoryBandwith")
                        .HasColumnType("int");

                    b.Property<int>("MemorySize")
                        .HasColumnType("int");

                    b.Property<string>("MemoryType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MotherBoardInterface")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("ThermalDesignPower")
                        .HasColumnType("int");

                    b.Property<string>("VideoOutputPorts")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GraphicsCards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ComputePerformance = 9,
                            CoreClockSpeed = 1607,
                            CoreCount = 2560,
                            GPU = "NVIDIA",
                            MemoryBandwith = 320,
                            MemorySize = 8,
                            MemoryType = "GDDR5X",
                            MotherBoardInterface = 256,
                            Name = "GeForce GTX 1080",
                            Price = 1499f,
                            ThermalDesignPower = 180,
                            VideoOutputPorts = ""
                        });
                });

            modelBuilder.Entity("PrometheusAPI.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "password",
                            Username = "Angel"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}