using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EShop.Migrations
{
    public partial class lol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Username = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cooling",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    RPM = table.Column<int>(nullable: false),
                    AirFlow = table.Column<double>(nullable: false),
                    NoiseLevel = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ImgURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cooling", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Memory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Frequency = table.Column<int>(nullable: false),
                    Buffer = table.Column<double>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    HasLED = table.Column<bool>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ImgURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotherBoards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Socket = table.Column<string>(nullable: true),
                    MaxMemory = table.Column<int>(nullable: false),
                    MaxMemoryFrequency = table.Column<int>(nullable: false),
                    Channels = table.Column<int>(nullable: false),
                    USBConnectors = table.Column<int>(nullable: false),
                    HasEthernet = table.Column<bool>(nullable: false),
                    HasWiFi = table.Column<bool>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ImgURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotherBoards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PowerSupplies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    MaxPower = table.Column<int>(nullable: false),
                    MaxVoltage = table.Column<int>(nullable: false),
                    MaxCurrent = table.Column<int>(nullable: false),
                    HasOverVoltageProtection = table.Column<bool>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ImgURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerSupplies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Frequency = table.Column<double>(nullable: false),
                    TurboFrequency = table.Column<double>(nullable: false),
                    NumCores = table.Column<int>(nullable: false),
                    NumThreads = table.Column<int>(nullable: false),
                    Cache = table.Column<int>(nullable: false),
                    RAMSupport = table.Column<string>(nullable: true),
                    TDP = table.Column<int>(nullable: false),
                    Lithography = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ImgURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Storage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    ReadSpeed = table.Column<int>(nullable: false),
                    WriteSpeed = table.Column<int>(nullable: false),
                    Buffer = table.Column<int>(nullable: false),
                    FormFactor = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    ImgURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Frequency = table.Column<int>(nullable: false),
                    TurboFrequency = table.Column<int>(nullable: false),
                    NumCores = table.Column<int>(nullable: false),
                    BusWidth = table.Column<int>(nullable: false),
                    VRAMBuffer = table.Column<double>(nullable: false),
                    VRAMType = table.Column<string>(nullable: true),
                    TDP = table.Column<int>(nullable: false),
                    Lithography = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ImgURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoCards", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Cooling");

            migrationBuilder.DropTable(
                name: "Memory");

            migrationBuilder.DropTable(
                name: "MotherBoards");

            migrationBuilder.DropTable(
                name: "PowerSupplies");

            migrationBuilder.DropTable(
                name: "Processors");

            migrationBuilder.DropTable(
                name: "Storage");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "VideoCards");
        }
    }
}
