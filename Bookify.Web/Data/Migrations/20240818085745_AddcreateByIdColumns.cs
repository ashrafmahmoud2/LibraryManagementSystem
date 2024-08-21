using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Data.Migrations
{
	public partial class AddcreateByIdColumns : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AddColumn<string>(
				name: "CreateById",
				table: "Categories",
				type: "nvarchar(450)",
				nullable: false,
				defaultValue: "");

			migrationBuilder.AddColumn<string>(
				name: "LastUpdateById",
				table: "Categories",
				type: "nvarchar(450)",
				nullable: false,
				defaultValue: "");

			migrationBuilder.AddColumn<string>(
				name: "CreateById",
				table: "Books",
				type: "nvarchar(450)",
				nullable: false,
				defaultValue: "");

			migrationBuilder.AddColumn<string>(
				name: "LastUpdateById",
				table: "Books",
				type: "nvarchar(450)",
				nullable: false,
				defaultValue: "");

			migrationBuilder.AddColumn<string>(
				name: "CreateById",
				table: "BookCopies",
				type: "nvarchar(450)",
				nullable: false,
				defaultValue: "");

			migrationBuilder.AddColumn<string>(
				name: "LastUpdateById",
				table: "BookCopies",
				type: "nvarchar(450)",
				nullable: false,
				defaultValue: "");

			migrationBuilder.AddColumn<string>(
				name: "CreateById",
				table: "Authors",
				type: "nvarchar(450)",
				nullable: false,
				defaultValue: "");

			migrationBuilder.AddColumn<string>(
				name: "LastUpdateById",
				table: "Authors",
				type: "nvarchar(450)",
				nullable: false,
				defaultValue: "");

			migrationBuilder.AddColumn<string>(
				name: "CreateById",
				table: "AspNetUsers",
				type: "nvarchar(max)",
				nullable: false,
				defaultValue: "");

			migrationBuilder.AddColumn<string>(
				name: "LastUpdateById",
				table: "AspNetUsers",
				type: "nvarchar(max)",
				nullable: false,
				defaultValue: "");

			migrationBuilder.CreateIndex(
				name: "IX_Categories_CreateById",
				table: "Categories",
				column: "CreateById");

			migrationBuilder.CreateIndex(
				name: "IX_Categories_LastUpdateById",
				table: "Categories",
				column: "LastUpdateById");

			migrationBuilder.CreateIndex(
				name: "IX_Books_CreateById",
				table: "Books",
				column: "CreateById");

			migrationBuilder.CreateIndex(
				name: "IX_Books_LastUpdateById",
				table: "Books",
				column: "LastUpdateById");

			migrationBuilder.CreateIndex(
				name: "IX_BookCopies_CreateById",
				table: "BookCopies",
				column: "CreateById");

			migrationBuilder.CreateIndex(
				name: "IX_BookCopies_LastUpdateById",
				table: "BookCopies",
				column: "LastUpdateById");

			migrationBuilder.CreateIndex(
				name: "IX_Authors_CreateById",
				table: "Authors",
				column: "CreateById");

			migrationBuilder.CreateIndex(
				name: "IX_Authors_LastUpdateById",
				table: "Authors",
				column: "LastUpdateById");

			migrationBuilder.AddForeignKey(
				name: "FK_Authors_AspNetUsers_CreateById",
				table: "Authors",
				column: "CreateById",
				principalTable: "AspNetUsers",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_Authors_AspNetUsers_LastUpdateById",
				table: "Authors",
				column: "LastUpdateById",
				principalTable: "AspNetUsers",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_BookCopies_AspNetUsers_CreateById",
				table: "BookCopies",
				column: "CreateById",
				principalTable: "AspNetUsers",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_BookCopies_AspNetUsers_LastUpdateById",
				table: "BookCopies",
				column: "LastUpdateById",
				principalTable: "AspNetUsers",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_Books_AspNetUsers_CreateById",
				table: "Books",
				column: "CreateById",
				principalTable: "AspNetUsers",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_Books_AspNetUsers_LastUpdateById",
				table: "Books",
				column: "LastUpdateById",
				principalTable: "AspNetUsers",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_Categories_AspNetUsers_CreateById",
				table: "Categories",
				column: "CreateById",
				principalTable: "AspNetUsers",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);

			migrationBuilder.AddForeignKey(
				name: "FK_Categories_AspNetUsers_LastUpdateById",
				table: "Categories",
				column: "LastUpdateById",
				principalTable: "AspNetUsers",
				principalColumn: "Id",
				onDelete: ReferentialAction.Restrict);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_Authors_AspNetUsers_CreateById",
				table: "Authors");

			migrationBuilder.DropForeignKey(
				name: "FK_Authors_AspNetUsers_LastUpdateById",
				table: "Authors");

			migrationBuilder.DropForeignKey(
				name: "FK_BookCopies_AspNetUsers_CreateById",
				table: "BookCopies");

			migrationBuilder.DropForeignKey(
				name: "FK_BookCopies_AspNetUsers_LastUpdateById",
				table: "BookCopies");

			migrationBuilder.DropForeignKey(
				name: "FK_Books_AspNetUsers_CreateById",
				table: "Books");

			migrationBuilder.DropForeignKey(
				name: "FK_Books_AspNetUsers_LastUpdateById",
				table: "Books");

			migrationBuilder.DropForeignKey(
				name: "FK_Categories_AspNetUsers_CreateById",
				table: "Categories");

			migrationBuilder.DropForeignKey(
				name: "FK_Categories_AspNetUsers_LastUpdateById",
				table: "Categories");

			migrationBuilder.DropIndex(
				name: "IX_Categories_CreateById",
				table: "Categories");

			migrationBuilder.DropIndex(
				name: "IX_Categories_LastUpdateById",
				table: "Categories");

			migrationBuilder.DropIndex(
				name: "IX_Books_CreateById",
				table: "Books");

			migrationBuilder.DropIndex(
				name: "IX_Books_LastUpdateById",
				table: "Books");

			migrationBuilder.DropIndex(
				name: "IX_BookCopies_CreateById",
				table: "BookCopies");

			migrationBuilder.DropIndex(
				name: "IX_BookCopies_LastUpdateById",
				table: "BookCopies");

			migrationBuilder.DropIndex(
				name: "IX_Authors_CreateById",
				table: "Authors");

			migrationBuilder.DropIndex(
				name: "IX_Authors_LastUpdateById",
				table: "Authors");

			migrationBuilder.DropColumn(
				name: "CreateById",
				table: "Categories");

			migrationBuilder.DropColumn(
				name: "LastUpdateById",
				table: "Categories");

			migrationBuilder.DropColumn(
				name: "CreateById",
				table: "Books");

			migrationBuilder.DropColumn(
				name: "LastUpdateById",
				table: "Books");

			migrationBuilder.DropColumn(
				name: "CreateById",
				table: "BookCopies");

			migrationBuilder.DropColumn(
				name: "LastUpdateById",
				table: "BookCopies");

			migrationBuilder.DropColumn(
				name: "CreateById",
				table: "Authors");

			migrationBuilder.DropColumn(
				name: "LastUpdateById",
				table: "Authors");

			migrationBuilder.DropColumn(
				name: "CreateById",
				table: "AspNetUsers");

			migrationBuilder.DropColumn(
				name: "LastUpdateById",
				table: "AspNetUsers");
		}
	}
}
