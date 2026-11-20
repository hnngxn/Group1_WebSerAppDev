using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Group1_WebSerAppDev.Migrations
{
    /// <inheritdoc />
    public partial class AddCardioActivities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardioActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Met = table.Column<double>(type: "float", nullable: false),
                    JointImpact = table.Column<int>(type: "int", nullable: false),
                    MusclesWorked = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Equipment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardioActivities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CardioActivities",
                columns: new[] { "Id", "Equipment", "JointImpact", "Met", "MusclesWorked", "Name", "Pace" },
                values: new object[,]
                {
                    { 1, "Skates, helmet, pads", 0, 7.5, "Glutes, quads, hip abductors, core", "Rollerblading", "9 mph, recreational" },
                    { 2, "Skates, helmet, pads", 0, 9.8000000000000007, "Glutes, quads, hip abductors, core", "Rollerblading", "11 mph, moderate" },
                    { 3, "Running shoes", 2, 8.3000000000000007, "Quads, hamstrings, calves", "Running", "5 mph (12 min/mile)" },
                    { 4, "Running shoes", 2, 9.8000000000000007, "Quads, hamstrings, calves", "Running", "6 mph (10 min/mile)" },
                    { 5, "Bike, helmet", 0, 8.0, "Quads, glutes, calves", "Cycling", "12-13.9 mph, moderate" },
                    { 6, "Walking shoes", 0, 4.2999999999999998, "Calves, hamstrings, glutes", "Walking", "3.5 mph, brisk" },
                    { 7, "Pool access, goggles", 0, 5.7999999999999998, "Shoulders, back, core, legs", "Swimming", "Freestyle laps, light to moderate" },
                    { 8, "Rowing machine", 0, 7.0, "Back, legs, arms, core", "Rowing machine", "100 watts, moderate" },
                    { 9, "Elliptical trainer", 0, 5.0, "Quads, glutes, hamstrings", "Elliptical", "Moderate effort" },
                    { 10, "Jump rope", 2, 11.800000000000001, "Calves, shoulders, core", "Jump rope", "100-120 skips/min" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardioActivities");
        }
    }
}
