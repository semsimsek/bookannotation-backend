using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bookannotation_api.Migrations
{
    public partial class keyupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Books_NotesId",
                table: "Notes");

            migrationBuilder.RenameColumn(
                name: "NotesId",
                table: "Notes",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Notes_NotesId",
                table: "Notes",
                newName: "IX_Notes_BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Books_BookId",
                table: "Notes",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Books_BookId",
                table: "Notes");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Notes",
                newName: "NotesId");

            migrationBuilder.RenameIndex(
                name: "IX_Notes_BookId",
                table: "Notes",
                newName: "IX_Notes_NotesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Books_NotesId",
                table: "Notes",
                column: "NotesId",
                principalTable: "Books",
                principalColumn: "BookId");
        }
    }
}
