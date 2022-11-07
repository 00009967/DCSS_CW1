using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsersApi.Migrations
{
    public partial class InitialSetup2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "User");
        }
    }
}
