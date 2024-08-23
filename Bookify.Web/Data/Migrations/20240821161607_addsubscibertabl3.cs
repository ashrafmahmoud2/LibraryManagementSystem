using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Data.Migrations
{
    public partial class addsubscibertabl3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "SecondName",
                table: "Subscribers");

            migrationBuilder.RenameColumn(
                name: "NationalID",
                table: "Subscribers",
                newName: "NationalId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscribers_NationalID",
                table: "Subscribers",
                newName: "IX_Subscribers_NationalId");

            migrationBuilder.AlterColumn<string>(
                name: "NationalId",
                table: "Subscribers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Subscribers",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Subscribers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Subscribers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Subscribers",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Subscribers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Subscribers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ImageThumbnailUrl",
                table: "Subscribers",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsBlackListed",
                table: "Subscribers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Subscribers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Subscribers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedById",
                table: "Subscribers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedOn",
                table: "Subscribers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "Subscribers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Governorates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governorates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Governorates_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Governorates_AspNetUsers_LastUpdatedById",
                        column: x => x.LastUpdatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GovernorateId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Areas_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Areas_AspNetUsers_LastUpdatedById",
                        column: x => x.LastUpdatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Areas_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalTable: "Governorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_AreaId",
                table: "Subscribers",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_CreatedById",
                table: "Subscribers",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_GovernorateId",
                table: "Subscribers",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_LastUpdatedById",
                table: "Subscribers",
                column: "LastUpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_MobileNumber",
                table: "Subscribers",
                column: "MobileNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Areas_CreatedById",
                table: "Areas",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Areas_GovernorateId",
                table: "Areas",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Areas_LastUpdatedById",
                table: "Areas",
                column: "LastUpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Areas_Name_GovernorateId",
                table: "Areas",
                columns: new[] { "Name", "GovernorateId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Governorates_CreatedById",
                table: "Governorates",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Governorates_LastUpdatedById",
                table: "Governorates",
                column: "LastUpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Governorates_Name",
                table: "Governorates",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_Areas_AreaId",
                table: "Subscribers",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_AspNetUsers_CreatedById",
                table: "Subscribers",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_AspNetUsers_LastUpdatedById",
                table: "Subscribers",
                column: "LastUpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_Governorates_GovernorateId",
                table: "Subscribers",
                column: "GovernorateId",
                principalTable: "Governorates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_Areas_AreaId",
                table: "Subscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_AspNetUsers_CreatedById",
                table: "Subscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_AspNetUsers_LastUpdatedById",
                table: "Subscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_Governorates_GovernorateId",
                table: "Subscribers");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Governorates");

            migrationBuilder.DropIndex(
                name: "IX_Subscribers_AreaId",
                table: "Subscribers");

            migrationBuilder.DropIndex(
                name: "IX_Subscribers_CreatedById",
                table: "Subscribers");

            migrationBuilder.DropIndex(
                name: "IX_Subscribers_GovernorateId",
                table: "Subscribers");

            migrationBuilder.DropIndex(
                name: "IX_Subscribers_LastUpdatedById",
                table: "Subscribers");

            migrationBuilder.DropIndex(
                name: "IX_Subscribers_MobileNumber",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "ImageThumbnailUrl",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "IsBlackListed",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "LastUpdatedById",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "LastUpdatedOn",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "Subscribers");

            migrationBuilder.RenameColumn(
                name: "NationalId",
                table: "Subscribers",
                newName: "NationalID");

            migrationBuilder.RenameIndex(
                name: "IX_Subscribers_NationalId",
                table: "Subscribers",
                newName: "IX_Subscribers_NationalID");

            migrationBuilder.AlterColumn<string>(
                name: "NationalID",
                table: "Subscribers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Subscribers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Subscribers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Subscribers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Subscribers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Subscribers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondName",
                table: "Subscribers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
