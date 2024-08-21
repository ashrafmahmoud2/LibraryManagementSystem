using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Data.Migrations
{
	public partial class AddBookCopy : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_BookCopy_Books_BookId",
				table: "BookCopy");

			migrationBuilder.DropPrimaryKey(
				name: "PK_BookCopy",
				table: "BookCopy");

			migrationBuilder.RenameTable(
				name: "BookCopy",
				newName: "BooksCopy");

			migrationBuilder.RenameIndex(
				name: "IX_BookCopy_BookId",
				table: "BooksCopy",
				newName: "IX_BooksCopy_BookId");

			migrationBuilder.AddColumn<DateTime>(
				name: "CreatedOn",
				table: "BooksCopy",
				type: "datetime2",
				nullable: false,
				defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

			migrationBuilder.AddColumn<bool>(
				name: "IsDeleted",
				table: "BooksCopy",
				type: "bit",
				nullable: false,
				defaultValue: false);

			migrationBuilder.AddColumn<DateTime>(
				name: "LastUpdatedOn",
				table: "BooksCopy",
				type: "datetime2",
				nullable: true);

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

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_BooksCopy_Books_BookId",
				table: "BooksCopy");

			migrationBuilder.DropPrimaryKey(
				name: "PK_BooksCopy",
				table: "BooksCopy");

			migrationBuilder.DropColumn(
				name: "CreatedOn",
				table: "BooksCopy");

			migrationBuilder.DropColumn(
				name: "IsDeleted",
				table: "BooksCopy");

			migrationBuilder.DropColumn(
				name: "LastUpdatedOn",
				table: "BooksCopy");

			migrationBuilder.RenameTable(
				name: "BooksCopy",
				newName: "BookCopy");

			migrationBuilder.RenameIndex(
				name: "IX_BooksCopy_BookId",
				table: "BookCopy",
				newName: "IX_BookCopy_BookId");

			migrationBuilder.AddPrimaryKey(
				name: "PK_BookCopy",
				table: "BookCopy",
				column: "Id");

			migrationBuilder.AddForeignKey(
				name: "FK_BookCopy_Books_BookId",
				table: "BookCopy",
				column: "BookId",
				principalTable: "Books",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);
		}
	}
}
