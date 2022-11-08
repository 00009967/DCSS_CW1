using Microsoft.EntityFrameworkCore.Migrations;

namespace UsersApi.Migrations
{
    public partial class SeedsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 3, "Wade@gmail.com", "Wade", "+998912345678" },
                    { 26, "Horald@gmail.com", "Horald", "+998912345678" },
                    { 25, "Aidan@gmail.com", "Aidan", "+998912345678" },
                    { 24, "Julian@gmail.com", "Julian", "+998912345678" },
                    { 23, "Connar@gmail.com", "Connar", "+998912345678" },
                    { 22, "Antonio@gmail.com", "Antonio", "+998912345678" },
                    { 21, "Blake@gmail.com", "Blake", "+998912345678" },
                    { 20, "Harvey@gmail.com", "Harvey", "+998912345678" },
                    { 19, "Glen@gmail.com", "Glen", "+998912345678" },
                    { 18, "Joshua@gmail.com", "Joshua", "+998912345678" },
                    { 17, "Milton@gmail.com", "Milton", "+998912345678" },
                    { 16, "Lewis@gmail.com", "Lewis", "+998912345678" },
                    { 27, "Conner@gmail.com", "Conner", "+998912345678" },
                    { 15, "Ethan@gmail.com", "Ethan", "+998912345678" },
                    { 13, "Miles@gmail.com", "Miles", "+998912345678" },
                    { 12, "Robert@gmail.com", "Robert", "+998912345678" },
                    { 11, "Brian@gmail.com", "Brian", "+998912345678" },
                    { 10, "Dan@gmail.com", "Dan", "+998912345678" },
                    { 9, "Jeff@gmail.com", "Jeff", "+998912345678" },
                    { 8, "Jorge@gmail.com", "Jorge", "+998912345678" },
                    { 7, "Gibert@gmail.com", "Gibert", "+998912345678" },
                    { 6, "Riley@gmail.com", "Riley", "+998912345678" },
                    { 5, "Ivan@gmail.com", "Ivan", "+998912345678" },
                    { 4, "Seth@gmail.com", "Seth", "+998912345678" },
                    { 2, "Alex@gmail.com", "Alex", "+998912345678" },
                    { 14, "Nathaniel@gmail.com", "Nathaniel", "+998912345678" },
                    { 28, "Mac@gmail.com", "Mac", "+998912345678" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[] { 1, "john@gmail.com", "John", "+998912345678" });
        }
    }
}
