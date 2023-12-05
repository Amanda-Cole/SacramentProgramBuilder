using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentProgramBuilder.Migrations
{
    /// <inheritdoc />
    public partial class ProgramDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ProgramDate",
                table: "SacramentProgram",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProgramDate",
                table: "SacramentProgram");
        }
    }
}
