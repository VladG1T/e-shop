﻿// <auto-generated />
using System;
using EShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EShop.Migrations
{
    [DbContext(typeof(GenericContext))]
    partial class GenericContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("EShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EShop.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<string>("CategoryName");

                    b.Property<DateTime>("Date");

                    b.Property<int>("ItemId");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EShop.Models.Cooling", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AirFlow");

                    b.Property<string>("ImgURL");

                    b.Property<string>("Name");

                    b.Property<double>("NoiseLevel");

                    b.Property<double>("Price");

                    b.Property<int>("RPM");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Cooling");
                });

            modelBuilder.Entity("EShop.Models.Memory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Buffer");

                    b.Property<int>("Frequency");

                    b.Property<bool>("HasLED");

                    b.Property<string>("ImgURL");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Memory");
                });

            modelBuilder.Entity("EShop.Models.MotherBoard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Channels");

                    b.Property<bool>("HasEthernet");

                    b.Property<bool>("HasWiFi");

                    b.Property<string>("ImgURL");

                    b.Property<int>("MaxMemory");

                    b.Property<int>("MaxMemoryFrequency");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<string>("Socket");

                    b.Property<int>("USBConnectors");

                    b.HasKey("Id");

                    b.ToTable("MotherBoards");
                });

            modelBuilder.Entity("EShop.Models.PowerSupply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("HasOverVoltageProtection");

                    b.Property<string>("ImgURL");

                    b.Property<int>("MaxCurrent");

                    b.Property<int>("MaxPower");

                    b.Property<int>("MaxVoltage");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.ToTable("PowerSupplies");
                });

            modelBuilder.Entity("EShop.Models.Processor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cache");

                    b.Property<double>("Frequency");

                    b.Property<string>("ImgURL");

                    b.Property<int>("Lithography");

                    b.Property<string>("Name");

                    b.Property<int>("NumCores");

                    b.Property<int>("NumThreads");

                    b.Property<double>("Price");

                    b.Property<string>("RAMSupport");

                    b.Property<int>("TDP");

                    b.Property<double>("TurboFrequency");

                    b.HasKey("Id");

                    b.ToTable("Processors");
                });

            modelBuilder.Entity("EShop.Models.Storage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Buffer");

                    b.Property<string>("FormFactor");

                    b.Property<string>("ImgURL");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<int>("ReadSpeed");

                    b.Property<string>("Type");

                    b.Property<int>("WriteSpeed");

                    b.HasKey("Id");

                    b.ToTable("Storage");
                });

            modelBuilder.Entity("EShop.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EShop.Models.VideoCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BusWidth");

                    b.Property<int>("Frequency");

                    b.Property<string>("ImgURL");

                    b.Property<int>("Lithography");

                    b.Property<string>("Name");

                    b.Property<int>("NumCores");

                    b.Property<double>("Price");

                    b.Property<int>("TDP");

                    b.Property<int>("TurboFrequency");

                    b.Property<double>("VRAMBuffer");

                    b.Property<string>("VRAMType");

                    b.HasKey("Id");

                    b.ToTable("VideoCards");
                });
#pragma warning restore 612, 618
        }
    }
}