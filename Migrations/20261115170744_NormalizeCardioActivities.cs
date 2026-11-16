using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Group1_WebSerAppDev.Migrations
{
    /// <inheritdoc />
    public partial class NormalizeCardioActivities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardioActivities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CardioActivities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Met",
                table: "CardioActivities");

            migrationBuilder.DropColumn(
                name: "Pace",
                table: "CardioActivities");

            migrationBuilder.CreateTable(
                name: "ActivityPaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Met = table.Column<double>(type: "float", nullable: false),
                    CardioActivityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityPaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityPaces_CardioActivities_CardioActivityId",
                        column: x => x.CardioActivityId,
                        principalTable: "CardioActivities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ActivityPaces",
                columns: new[] { "Id", "CardioActivityId", "Description", "Met" },
                values: new object[,]
                {
                    { 1, 1, "9 mph, recreational", 7.5 },
                    { 2, 1, "11 mph, moderate", 9.8000000000000007 },
                    { 3, 2, "5 mph (12 min/mile)", 8.3000000000000007 },
                    { 4, 2, "6 mph (10 min/mile)", 9.8000000000000007 },
                    { 5, 3, "12-13.9 mph, moderate", 8.0 },
                    { 6, 4, "3.5 mph, brisk", 4.2999999999999998 },
                    { 7, 5, "Freestyle laps, light to moderate", 5.7999999999999998 },
                    { 8, 6, "100 watts, moderate", 7.0 },
                    { 9, 7, "Moderate effort", 5.0 },
                    { 10, 8, "100-120 skips/min", 11.800000000000001 }
                });

            migrationBuilder.UpdateData(
                table: "CardioActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Equipment", "JointImpact", "MusclesWorked", "Name" },
                values: new object[] { "Running shoes", 2, "Quads, hamstrings, calves", "Running" });

            migrationBuilder.UpdateData(
                table: "CardioActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Equipment", "JointImpact", "MusclesWorked", "Name" },
                values: new object[] { "Bike, helmet", 0, "Quads, glutes, calves", "Cycling" });

            migrationBuilder.UpdateData(
                table: "CardioActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Equipment", "JointImpact", "MusclesWorked", "Name" },
                values: new object[] { "Walking shoes", 0, "Calves, hamstrings, glutes", "Walking" });

            migrationBuilder.UpdateData(
                table: "CardioActivities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Equipment", "MusclesWorked", "Name" },
                values: new object[] { "Pool access, goggles", "Shoulders, back, core, legs", "Swimming" });

            migrationBuilder.UpdateData(
                table: "CardioActivities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Equipment", "MusclesWorked", "Name" },
                values: new object[] { "Rowing machine", "Back, legs, arms, core", "Rowing machine" });

            migrationBuilder.UpdateData(
                table: "CardioActivities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Equipment", "MusclesWorked", "Name" },
                values: new object[] { "Elliptical trainer", "Quads, glutes, hamstrings", "Elliptical" });

            migrationBuilder.UpdateData(
                table: "CardioActivities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Equipment", "JointImpact", "MusclesWorked", "Name" },
                values: new object[] { "Jump rope", 2, "Calves, shoulders, core", "Jump rope" });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityPaces_CardioActivityId",
                table: "ActivityPaces",
                column: "CardioActivityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityPaces");

            migrationBuilder.AddColumn<double>(
                name: "Met",
                table: "CardioActivities",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Pace",
                table: "CardioActivities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "CardioActivities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Met", "Pace" },
                values: new object[] { 7.5, "9 mph, recreational" });

            migrationBuilder.UpdateData(
                table: "CardioActivities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Equipment", "JointImpact", "Met", "MusclesWorked", "Name", "Pace" },
                values: new object[] { "Skates, helmet, pads", 0, 9.8000000000000007, "Glutes, quads, hip abductors, core", "Rollerblading", "11 mph, moderate" });

            migrationBuilder.UpdateData(
                table: "CardioActivities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Equipment", "JointImpact", "Met", "MusclesWorked", "Name", "Pace" },
                values: new object[] { "Running shoes", 2, 8.3000000000000007, "Quads, hamstrings, calves", "Running", "5 mph (12 min/mile)" });

            migrationBuilder.UpdateData(
                table: "CardioActivities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Equipment", "JointImpact", "Met", "MusclesWorked", "Name", "Pace" },
                values: new object[] { "Running shoes", 2, 9.8000000000000007, "Quads, hamstrings, calves", "Running", "6 mph (10 min/mile)" });

            migrationBuilder.UpdateData(
                table: "CardioActivities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Equipment", "Met", "MusclesWorked", "Name", "Pace" },
                values: new object[] { "Bike, helmet", 8.0, "Quads, glutes, calves", "Cycling", "12-13.9 mph, moderate" });

            migrationBuilder.UpdateData(
                table: "CardioActivities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Equipment", "Met", "MusclesWorked", "Name", "Pace" },
                values: new object[] { "Walking shoes", 4.2999999999999998, "Calves, hamstrings, glutes", "Walking", "3.5 mph, brisk" });

            migrationBuilder.UpdateData(
                table: "CardioActivities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Equipment", "Met", "MusclesWorked", "Name", "Pace" },
                values: new object[] { "Pool access, goggles", 5.7999999999999998, "Shoulders, back, core, legs", "Swimming", "Freestyle laps, light to moderate" });

            migrationBuilder.UpdateData(
                table: "CardioActivities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Equipment", "JointImpact", "Met", "MusclesWorked", "Name", "Pace" },
                values: new object[] { "Rowing machine", 0, 7.0, "Back, legs, arms, core", "Rowing machine", "100 watts, moderate" });

            migrationBuilder.InsertData(
                table: "CardioActivities",
                columns: new[] { "Id", "Equipment", "JointImpact", "Met", "MusclesWorked", "Name", "Pace" },
                values: new object[,]
                {
                    { 9, "Elliptical trainer", 0, 5.0, "Quads, glutes, hamstrings", "Elliptical", "Moderate effort" },
                    { 10, "Jump rope", 2, 11.800000000000001, "Calves, shoulders, core", "Jump rope", "100-120 skips/min" }
                });
        }
    }
}
