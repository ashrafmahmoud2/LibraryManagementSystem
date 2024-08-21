using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Data.Migrations
{
	public partial class UpdateUserPropertyNamees : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
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

			migrationBuilder.AddColumn<string>(
				name: "CreatedById",
				table: "Categories",
				type: "nvarchar(450)",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "LastUpdatedById",
				table: "Categories",
				type: "nvarchar(450)",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "CreatedById",
				table: "Books",
				type: "nvarchar(450)",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "LastUpdatedById",
				table: "Books",
				type: "nvarchar(450)",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "CreatedById",
				table: "BookCopies",
				type: "nvarchar(450)",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "LastUpdatedById",
				table: "BookCopies",
				type: "nvarchar(450)",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "CreatedById",
				table: "Authors",
				type: "nvarchar(450)",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "LastUpdatedById",
				table: "Authors",
				type: "nvarchar(450)",
				nullable: true);

			migrationBuilder.AlterColumn<string>(
				name: "LastUpdatedById",
				table: "AspNetUsers",
				type: "nvarchar(max)",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "nvarchar(max)");

			migrationBuilder.AlterColumn<string>(
				name: "CreatedById",
				table: "AspNetUsers",
				type: "nvarchar(max)",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "nvarchar(max)");

			migrationBuilder.CreateIndex(
				name: "IX_Categories_CreatedById",
				table: "Categories",
				column: "CreatedById");

			migrationBuilder.CreateIndex(
				name: "IX_Categories_LastUpdatedById",
				table: "Categories",
				column: "LastUpdatedById");

			migrationBuilder.CreateIndex(
				name: "IX_Books_CreatedById",
				table: "Books",
				column: "CreatedById");

			migrationBuilder.CreateIndex(
				name: "IX_Books_LastUpdatedById",
				table: "Books",
				column: "LastUpdatedById");

			migrationBuilder.CreateIndex(
				name: "IX_BookCopies_CreatedById",
				table: "BookCopies",
				column: "CreatedById");

			migrationBuilder.CreateIndex(
				name: "IX_BookCopies_LastUpdatedById",
				table: "BookCopies",
				column: "LastUpdatedById");

			migrationBuilder.CreateIndex(
				name: "IX_Authors_CreatedById",
				table: "Authors",
				column: "CreatedById");

			migrationBuilder.CreateIndex(
				name: "IX_Authors_LastUpdatedById",
				table: "Authors",
				column: "LastUpdatedById");

			migrationBuilder.CreateIndex(
				name: "IX_AspNetUsers_Email",
				table: "AspNetUsers",
				column: "Email",
				unique: true,
				filter: "[Email] IS NOT NULL");

			migrationBuilder.CreateIndex(
				name: "IX_AspNetUsers_UserName",
				table: "AspNetUsers",
				column: "UserName",
				unique: true,
				filter: "[UserName] IS NOT NULL");

			migrationBuilder.AddForeignKey(
				name: "FK_Authors_AspNetUsers_CreatedById",
				table: "Authors",
				column: "CreatedById",
				principalTable: "AspNetUsers",
				principalColumn: "Id");

			migrationBuilder.AddForeignKey(
				name: "FK_Authors_AspNetUsers_LastUpdatedById",
				table: "Authors",
				column: "LastUpdatedById",
				principalTable: "AspNetUsers",
				principalColumn: "Id");

			migrationBuilder.AddForeignKey(
				name: "FK_BookCopies_AspNetUsers_CreatedById",
				table: "BookCopies",
				column: "CreatedById",
				principalTable: "AspNetUsers",
				principalColumn: "Id");

			migrationBuilder.AddForeignKey(
				name: "FK_BookCopies_AspNetUsers_LastUpdatedById",
				table: "BookCopies",
				column: "LastUpdatedById",
				principalTable: "AspNetUsers",
				principalColumn: "Id");

			migrationBuilder.AddForeignKey(
				name: "FK_Books_AspNetUsers_CreatedById",
				table: "Books",
				column: "CreatedById",
				principalTable: "AspNetUsers",
				principalColumn: "Id");

			migrationBuilder.AddForeignKey(
				name: "FK_Books_AspNetUsers_LastUpdatedById",
				table: "Books",
				column: "LastUpdatedById",
				principalTable: "AspNetUsers",
				principalColumn: "Id");

			migrationBuilder.AddForeignKey(
				name: "FK_Categories_AspNetUsers_CreatedById",
				table: "Categories",
				column: "CreatedById",
				principalTable: "AspNetUsers",
				principalColumn: "Id");

			migrationBuilder.AddForeignKey(
				name: "FK_Categories_AspNetUsers_LastUpdatedById",
				table: "Categories",
				column: "LastUpdatedById",
				principalTable: "AspNetUsers",
				principalColumn: "Id");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_Authors_AspNetUsers_CreatedById",
				table: "Authors");

			migrationBuilder.DropForeignKey(
				name: "FK_Authors_AspNetUsers_LastUpdatedById",
				table: "Authors");

			migrationBuilder.DropForeignKey(
				name: "FK_BookCopies_AspNetUsers_CreatedById",
				table: "BookCopies");

			migrationBuilder.DropForeignKey(
				name: "FK_BookCopies_AspNetUsers_LastUpdatedById",
				table: "BookCopies");

			migrationBuilder.DropForeignKey(
				name: "FK_Books_AspNetUsers_CreatedById",
				table: "Books");

			migrationBuilder.DropForeignKey(
				name: "FK_Books_AspNetUsers_LastUpdatedById",
				table: "Books");

			migrationBuilder.DropForeignKey(
				name: "FK_Categories_AspNetUsers_CreatedById",
				table: "Categories");

			migrationBuilder.DropForeignKey(
				name: "FK_Categories_AspNetUsers_LastUpdatedById",
				table: "Categories");

			migrationBuilder.DropIndex(
				name: "IX_Categories_CreatedById",
				table: "Categories");

			migrationBuilder.DropIndex(
				name: "IX_Categories_LastUpdatedById",
				table: "Categories");

			migrationBuilder.DropIndex(
				name: "IX_Books_CreatedById",
				table: "Books");

			migrationBuilder.DropIndex(
				name: "IX_Books_LastUpdatedById",
				table: "Books");

			migrationBuilder.DropIndex(
				name: "IX_BookCopies_CreatedById",
				table: "BookCopies");

			migrationBuilder.DropIndex(
				name: "IX_BookCopies_LastUpdatedById",
				table: "BookCopies");

			migrationBuilder.DropIndex(
				name: "IX_Authors_CreatedById",
				table: "Authors");

			migrationBuilder.DropIndex(
				name: "IX_Authors_LastUpdatedById",
				table: "Authors");

			migrationBuilder.DropIndex(
				name: "IX_AspNetUsers_Email",
				table: "AspNetUsers");

			migrationBuilder.DropIndex(
				name: "IX_AspNetUsers_UserName",
				table: "AspNetUsers");

			migrationBuilder.DropColumn(
				name: "CreatedById",
				table: "Categories");

			migrationBuilder.DropColumn(
				name: "LastUpdatedById",
				table: "Categories");

			migrationBuilder.DropColumn(
				name: "CreatedById",
				table: "Books");

			migrationBuilder.DropColumn(
				name: "LastUpdatedById",
				table: "Books");

			migrationBuilder.DropColumn(
				name: "CreatedById",
				table: "BookCopies");

			migrationBuilder.DropColumn(
				name: "LastUpdatedById",
				table: "BookCopies");

			migrationBuilder.DropColumn(
				name: "CreatedById",
				table: "Authors");

			migrationBuilder.DropColumn(
				name: "LastUpdatedById",
				table: "Authors");

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

			migrationBuilder.AlterColumn<string>(
				name: "LastUpdatedById",
				table: "AspNetUsers",
				type: "nvarchar(max)",
				nullable: false,
				defaultValue: "",
				oldClrType: typeof(string),
				oldType: "nvarchar(max)",
				oldNullable: true);

			migrationBuilder.AlterColumn<string>(
				name: "CreatedById",
				table: "AspNetUsers",
				type: "nvarchar(max)",
				nullable: false,
				defaultValue: "",
				oldClrType: typeof(string),
				oldType: "nvarchar(max)",
				oldNullable: true);

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
	}
}
