using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Data.Migrations
{
	public partial class my : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.RenameColumn(
				name: "ImageThmbnailUrl",
				table: "Books",
				newName: "ImageThumbnailUrl");

			migrationBuilder.RenameColumn(
				name: "ImagePublicUrl",
				table: "Books",
				newName: "ImagePublicId");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.RenameColumn(
				name: "ImageThumbnailUrl",
				table: "Books",
				newName: "ImageThmbnailUrl");

			migrationBuilder.RenameColumn(
				name: "ImagePublicId",
				table: "Books",
				newName: "ImagePublicUrl");
		}
	}
}
