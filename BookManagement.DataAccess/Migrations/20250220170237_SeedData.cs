using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookManagement.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Title", "AuthorName", "IsDeleted", "PublicationYear", "ViewsCount" },
                values: new object[,]
                {
                    { "Beyond the Horizon", "Isabella Lee", false, 2021, 80 },
                    { "Guardians of the Galaxy", "Alexander King", false, 2016, 150 },
                    { "Journey to the Unknown", "Michael Johnson", false, 2019, 30 },
                    { "Legends of the Past", "Charlotte Wilson", false, 2019, 100 },
                    { "Lost in Time", "James Williams", false, 2018, 25 },
                    { "Mystery of the Old Mansion", "Olivia Martinez", false, 2022, 40 },
                    { "Secrets of the Moon", "Liam Hall", false, 2022, 130 },
                    { "Tales from the Deep", "Grace Walker", false, 2021, 120 },
                    { "The Enchanted Forest", "Sophia Brown", false, 2020, 10 },
                    { "The Forbidden Island", "Benjamin Harris", false, 2016, 90 },
                    { "The Forgotten Realm", "Ava Young", false, 2017, 140 },
                    { "The Great Adventure", "Ethan Thompson", false, 2020, 70 },
                    { "The Hidden Treasures", "Emily Clark", false, 2021, 15 },
                    { "The Last Expedition", "William Davis", false, 2015, 50 },
                    { "The Lost Kingdom", "Henry Lewis", false, 2018, 110 },
                    { "The Phantom Ship", "Harper Scott", false, 2020, 160 },
                    { "The Secret of the Ancient Ruins", "Mia Robinson", false, 2017, 60 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "Beyond the Horizon");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "Guardians of the Galaxy");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "Journey to the Unknown");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "Legends of the Past");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "Lost in Time");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "Mystery of the Old Mansion");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "Secrets of the Moon");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "Tales from the Deep");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "The Enchanted Forest");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "The Forbidden Island");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "The Forgotten Realm");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "The Great Adventure");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "The Hidden Treasures");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "The Last Expedition");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "The Lost Kingdom");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "The Phantom Ship");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Title",
                keyValue: "The Secret of the Ancient Ruins");
        }
    }
}
