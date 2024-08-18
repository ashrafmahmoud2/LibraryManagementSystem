using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Data.Migrations
{
    public partial class makesomeUpdatesinModelsandNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksCopy_Books_BookId",
                table: "BooksCopy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksCopy",
                table: "BooksCopy");

            migrationBuilder.RenameTable(
                name: "BooksCopy",
                newName: "BookCopies");

            migrationBuilder.RenameIndex(
                name: "IX_BooksCopy_BookId",
                table: "BookCopies",
                newName: "IX_BookCopies_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCopies",
                table: "BookCopies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCopies_Books_BookId",
                table: "BookCopies",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCopies_Books_BookId",
                table: "BookCopies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCopies",
                table: "BookCopies");

            migrationBuilder.RenameTable(
                name: "BookCopies",
                newName: "BooksCopy");

            migrationBuilder.RenameIndex(
                name: "IX_BookCopies_BookId",
                table: "BooksCopy",
                newName: "IX_BooksCopy_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksCopy",
                table: "BooksCopy",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksCopy_Books_BookId",
                table: "BooksCopy",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
