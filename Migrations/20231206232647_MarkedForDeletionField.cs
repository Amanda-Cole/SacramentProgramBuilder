using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentProgramBuilder.Migrations
{
    /// <inheritdoc />
    public partial class MarkedForDeletionField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "MarkedForDeletion",
                table: "Speaker",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MarkedForDeletion",
                table: "Speaker");
        }
    }
}
