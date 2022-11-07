using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsersApi.Migrations
{
    public partial class InitialSetup3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "User",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "User",
                type: "datetime2",
                nullable: true);
        }
    }
}
