using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntitiesClasses.Migrations
{
    /// <inheritdoc />
    public partial class database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AudioData",
                table: "Messages");

            migrationBuilder.AddColumn<string>(
                name: "FileNameAudio",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FilePathAudio",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileNameAudio",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "FilePathAudio",
                table: "Messages");

            migrationBuilder.AddColumn<byte[]>(
                name: "AudioData",
                table: "Messages",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
