using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication4.Migrations
{
    /// <inheritdoc />
    public partial class Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    HireDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Nurseries",
                columns: table => new
                {
                    NurseryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    EstablishedDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurseries", x => x.NurseryId);
                });

            migrationBuilder.CreateTable(
                name: "Responsibles",
                columns: table => new
                {
                    BatchId = table.Column<int>(type: "integer", nullable: false),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsibles", x => new { x.EmployeeId, x.BatchId });
                });

            migrationBuilder.CreateTable(
                name: "SeedlingBatches",
                columns: table => new
                {
                    BatchId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NurseryId = table.Column<int>(type: "integer", nullable: false),
                    SpeciesId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    SownDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ReadyDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeedlingBatches", x => x.BatchId);
                });

            migrationBuilder.CreateTable(
                name: "TreeSpecies",
                columns: table => new
                {
                    SpeciesId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LatinName = table.Column<string>(type: "text", nullable: false),
                    GrowthTimeInYears = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreeSpecies", x => x.SpeciesId);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "HireDate", "LastName" },
                values: new object[,]
                {
                    { 1, "Jan", new DateOnly(2020, 1, 1), "Nowak" },
                    { 2, "Anna", new DateOnly(2020, 1, 1), "Kowalska" }
                });

            migrationBuilder.InsertData(
                table: "Nurseries",
                columns: new[] { "NurseryId", "EstablishedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateOnly(1990, 5, 15), "szkola lesna 1" },
                    { 2, new DateOnly(1995, 3, 10), "szkola lesna 2" }
                });

            migrationBuilder.InsertData(
                table: "SeedlingBatches",
                columns: new[] { "BatchId", "NurseryId", "Quantity", "ReadyDate", "SownDate", "SpeciesId" },
                values: new object[] { 1, 1, 1000, null, new DateOnly(2023, 4, 1), 1 });

            migrationBuilder.InsertData(
                table: "TreeSpecies",
                columns: new[] { "SpeciesId", "GrowthTimeInYears", "LatinName" },
                values: new object[,]
                {
                    { 1, 30, "Quercus robur" },
                    { 2, 20, "Pinus sylvestris" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Nurseries");

            migrationBuilder.DropTable(
                name: "Responsibles");

            migrationBuilder.DropTable(
                name: "SeedlingBatches");

            migrationBuilder.DropTable(
                name: "TreeSpecies");
        }
    }
}
