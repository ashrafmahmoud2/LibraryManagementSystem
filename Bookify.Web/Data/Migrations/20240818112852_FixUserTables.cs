using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Data.Migrations
{
	public partial class FixUserTables : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.RenameColumn(
				name: "LastUpdateById",
				table: "AspNetUsers",
				newName: "LastUpdatedById");

			migrationBuilder.RenameColumn(
				name: "CreateById",
				table: "AspNetUsers",
				newName: "CreatedById");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.RenameColumn(
				name: "LastUpdatedById",
				table: "AspNetUsers",
				newName: "LastUpdateById");

			migrationBuilder.RenameColumn(
				name: "CreatedById",
				table: "AspNetUsers",
				newName: "CreateById");
		}
	}
}
