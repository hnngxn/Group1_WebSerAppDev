using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Group1_WebSerAppDev.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePhotoModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Camera",
                table: "Photos",
                newName: "ImageFile");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Photos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTaken", "Description", "ImageFile", "Location", "Title" },
                values: new object[] { new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Driving under the sunset with my best friend", "SunsetDrive.jpg", "Bel Air, MD", "Sunset Drive" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTaken", "Description", "ImageFile", "Location", "Title" },
                values: new object[] { new DateTime(2026, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "He bought me flowers ", "Tulips.jpg", "Vietnam", "Tulips" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateTaken", "Description", "ImageFile", "Location", "Title" },
                values: new object[] { new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sleepy owl", "Owl.jpg", "Hershey Park", "Owl" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "DateTaken", "Description", "ImageFile", "Location", "Title" },
                values: new object[,]
                {
                    { 4, new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "First fall at UC", "Fall.jpg", "UC", "Fall Season in Cincy" },
                    { 5, new DateTime(2026, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "My two good boys back home", "Dogs.jpg", "Home", "Two little cuties" },
                    { 6, new DateTime(2026, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lovebirds - they said", "Birds.jpg", "Cincinnati Zoo", "Love Birds" },
                    { 7, new DateTime(2026, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The summer he came", "BlurrySummer.jpg", "Cincinnati, OH", "Him" },
                    { 8, new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "A kid lost in the blue light at the museum", "Child.jpg", "Hershey Park", "Child" },
                    { 9, new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "UC through my lens", "UC.jpg", "Cincinnati, OH", "UC" },
                    { 10, new DateTime(2026, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "First time at this zoo with my boyfriend", "Zoo.jpg", "Cincinnati Zoo", "Zoo" },
                    { 11, new DateTime(2026, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vacation that I grew up with", "Motobike.jpg", "Vũng Tàu, Vietnam", "Motorbike" },
                    { 12, new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trip to DC with mom and dad", "McDonnal.jpg", "Washington, DC", "McDonald's Through the Frame" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Photos");

            migrationBuilder.RenameColumn(
                name: "ImageFile",
                table: "Photos",
                newName: "Camera");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Camera", "DateTaken", "Location", "Title" },
                values: new object[] { "[camera]", new DateTime(2026, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "[place]", "[title]" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Camera", "DateTaken", "Location", "Title" },
                values: new object[] { "[camera]", new DateTime(2026, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "[place]", "[title]" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Camera", "DateTaken", "Location", "Title" },
                values: new object[] { "[camera]", new DateTime(2026, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "[place]", "[title]" });
        }
    }
}
