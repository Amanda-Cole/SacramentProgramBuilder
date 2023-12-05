using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentProgramBuilder.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SacramentProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PresidingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConductingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningPrayerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningHymnName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningHymnNum = table.Column<int>(type: "int", nullable: true),
                    SacramentHymnName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SacramentHymnNum = table.Column<int>(type: "int", nullable: true),
                    SpeakerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpeakerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialMusicalNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateHymnName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntermediateHymnNum = table.Column<int>(type: "int", nullable: true),
                    ClosingPrayerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosingHymnName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClosingHymnNum = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SacramentProgram", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SacramentProgram");
        }
    }
}
