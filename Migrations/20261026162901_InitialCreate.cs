using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Group1_WebSerAppDev.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Camera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTaken = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Camera", "DateTaken", "Location", "Title" },
                values: new object[,]
                {
                    { 1, "[camera]", new DateTime(2026, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "[place]", "[title]" },
                    { 2, "[camera]", new DateTime(2026, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "[place]", "[title]" },
                    { 3, "[camera]", new DateTime(2026, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "[place]", "[title]" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");
        }
    }
}
