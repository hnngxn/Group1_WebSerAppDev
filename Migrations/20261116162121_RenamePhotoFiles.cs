using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group1_WebSerAppDev.Migrations
{
    /// <inheritdoc />
    public partial class RenamePhotoFiles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageFile",
                value: "Nguyen_Han_SunsetDrive.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageFile",
                value: "Nguyen_Han_Tulips.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageFile",
                value: "Nguyen_Han_Owl.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageFile",
                value: "Nguyen_Han_Fall.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageFile",
                value: "Nguyen_Han_Dogs.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageFile",
                value: "Nguyen_Han_Birds.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageFile",
                value: "Nguyen_Han_BlurrySummer.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageFile",
                value: "Nguyen_Han_Child.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageFile",
                value: "Nguyen_Han_UC.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageFile",
                value: "Nguyen_Han_Zoo.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageFile", "Location" },
                values: new object[] { "Nguyen_Han_Motorbike.jpg", "Vung Tau, Vietnam" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageFile",
                value: "Nguyen_Han_McDonalds.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageFile",
                value: "SunsetDrive.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageFile",
                value: "Tulips.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageFile",
                value: "Owl.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageFile",
                value: "Fall.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageFile",
                value: "Dogs.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageFile",
                value: "Birds.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageFile",
                value: "BlurrySummer.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageFile",
                value: "Child.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageFile",
                value: "UC.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageFile",
                value: "Zoo.jpg");

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageFile", "Location" },
                values: new object[] { "Motobike.jpg", "Vũng Tàu, Vietnam" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageFile",
                value: "McDonnal.jpg");
        }
    }
}
