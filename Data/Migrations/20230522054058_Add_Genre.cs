using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Roles.Data.Migrations
{
    public partial class Add_Genre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Genres",
                newName: "GenreId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Books",
                newName: "BookId");

            migrationBuilder.AddColumn<int>(
                name: "GenreId1",
                table: "Genres",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genres_GenreId1",
                table: "Genres",
                column: "GenreId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Genres_GenreId1",
                table: "Genres",
                column: "GenreId1",
                principalTable: "Genres",
                principalColumn: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Genres_GenreId1",
                table: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Genres_GenreId1",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "GenreId1",
                table: "Genres");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Genres",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Books",
                newName: "Id");
        }
    }
}
