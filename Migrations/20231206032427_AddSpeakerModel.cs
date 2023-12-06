using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentProgramBuilder.Migrations
{
    /// <inheritdoc />
    public partial class AddSpeakerModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpeakerName",
                table: "SacramentProgram");

            migrationBuilder.DropColumn(
                name: "SpeakerType",
                table: "SacramentProgram");

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpeakerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SacramentProgramId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Speaker_SacramentProgram_SacramentProgramId",
                        column: x => x.SacramentProgramId,
                        principalTable: "SacramentProgram",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_SacramentProgramId",
                table: "Speaker",
                column: "SacramentProgramId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speaker");

            migrationBuilder.AddColumn<string>(
                name: "SpeakerName",
                table: "SacramentProgram",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpeakerType",
                table: "SacramentProgram",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
