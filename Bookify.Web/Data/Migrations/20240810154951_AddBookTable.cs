using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Data.Migrations
{
	public partial class AddBookTable : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Books",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
					AuthorId = table.Column<int>(type: "int", nullable: false),
					Publisher = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
					PublishingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
					ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
					ImageThmbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
					ImagePublicUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
					Hall = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
					IsAvailableForRental = table.Column<bool>(type: "bit", nullable: false),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false),
					CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
					LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Books", x => x.Id);
					table.ForeignKey(
						name: "FK_Books_Authors_AuthorId",
						column: x => x.AuthorId,
						principalTable: "Authors",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateTable(
				name: "BookCategories",
				columns: table => new
				{
					BookId = table.Column<int>(type: "int", nullable: false),
					CategoryId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_BookCategories", x => new { x.BookId, x.CategoryId });
					table.ForeignKey(
						name: "FK_BookCategories_Books_BookId",
						column: x => x.BookId,
						principalTable: "Books",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
					table.ForeignKey(
						name: "FK_BookCategories_Categories_CategoryId",
						column: x => x.CategoryId,
						principalTable: "Categories",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateTable(
				name: "BookCopy",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					BookId = table.Column<int>(type: "int", nullable: false),
					IsAvailableforRental = table.Column<bool>(type: "bit", nullable: false),
					EditionNumber = table.Column<int>(type: "int", nullable: false),
					SerialNumber = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_BookCopy", x => x.Id);
					table.ForeignKey(
						name: "FK_BookCopy_Books_BookId",
						column: x => x.BookId,
						principalTable: "Books",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

			migrationBuilder.CreateIndex(
				name: "IX_BookCategories_CategoryId",
				table: "BookCategories",
				column: "CategoryId");

			migrationBuilder.CreateIndex(
				name: "IX_BookCopy_BookId",
				table: "BookCopy",
				column: "BookId");

			migrationBuilder.CreateIndex(
				name: "IX_Books_AuthorId",
				table: "Books",
				column: "AuthorId");

			migrationBuilder.CreateIndex(
				name: "IX_Books_Title_AuthorId",
				table: "Books",
				columns: new[] { "Title", "AuthorId" },
				unique: true);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "BookCategories");

			migrationBuilder.DropTable(
				name: "BookCopy");

			migrationBuilder.DropTable(
				name: "Books");
		}
	}
}
