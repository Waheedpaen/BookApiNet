using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntitiesClasses.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookImages_BookDetails_BookDetailId",
                table: "BookImages");

            migrationBuilder.AddForeignKey(
                name: "FK_BookImages_BookDetails_BookDetailId",
                table: "BookImages",
                column: "BookDetailId",
                principalTable: "BookDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookImages_BookDetails_BookDetailId",
                table: "BookImages");

            migrationBuilder.AddForeignKey(
                name: "FK_BookImages_BookDetails_BookDetailId",
                table: "BookImages",
                column: "BookDetailId",
                principalTable: "BookDetails",
                principalColumn: "Id");
        }
    }
}
