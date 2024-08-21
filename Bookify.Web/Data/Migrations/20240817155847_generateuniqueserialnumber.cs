using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Data.Migrations
{
	public partial class generateuniqueserialnumber : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.EnsureSchema(
				name: "shared");

			migrationBuilder.CreateSequence<int>(
				name: "SerialNumber",
				schema: "shared",
				startValue: 1000001L);

			migrationBuilder.AlterColumn<int>(
				name: "SerialNumber",
				table: "BookCopies",
				type: "int",
				nullable: false,
				defaultValueSql: "NEXT VALUE FOR shared.SerialNumber",
				oldClrType: typeof(int),
				oldType: "int");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropSequence(
				name: "SerialNumber",
				schema: "shared");

			migrationBuilder.AlterColumn<int>(
				name: "SerialNumber",
				table: "BookCopies",
				type: "int",
				nullable: false,
				oldClrType: typeof(int),
				oldType: "int",
				oldDefaultValueSql: "NEXT VALUE FOR shared.SerialNumber");
		}
	}
}
