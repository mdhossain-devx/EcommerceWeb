using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataToDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 2, "Vid City", "Vivid Books", "7779990000", "66666", "IL", "999 Vid St" },
                    { 3, "Lala land", "Readers Club", "1113335555", "99999", "NY", "999 Main St" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "A gripping journey through time, where destiny and science intertwine. When a forgotten relic is uncovered, one man must solve ancient riddles to protect the fabric of reality.\r\n\r\nRich in suspense and imagination, this time-travel adventure blends mystery with powerful storytelling.");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 2, "Nancy Hoover", 1, "A haunting tale of survival beneath an ever-darkening sky. As the world grapples with a mysterious eclipse, one woman uncovers a secret that could save—or destroy—humanity.\r\n\r\nWith atmospheric tension and emotional depth, this thriller keeps readers on edge.", "CAW777777701", 40.0, 30.0, 20.0, 25.0, "Dark Skies" },
                    { 3, "Julian Button", 1, "An emotional story of love and letting go, set against the backdrop of a coastal town. As past wounds resurface, a photographer and a writer find healing in unexpected places.\r\n\r\nA bittersweet romance that captures the fleeting beauty of second chances.", "RITO5555501", 55.0, 50.0, 35.0, 40.0, "Vanish in the Sunset" },
                    { 4, "Abby Muscles", 2, "A delightful tale that explores childhood nostalgia and the sweetness of dreams. Follow a group of friends as they navigate small-town joys, heartbreaks, and coming-of-age truths.\r\n\r\nPlayful and heartwarming, this story blends humor with gentle life lessons.", "WS3333333301", 70.0, 65.0, 55.0, 60.0, "Cotton Candy" },
                    { 5, "Ron Parker", 2, "Set on a remote island, this novel tells the story of resilience and hope after disaster strikes. A stranded marine biologist must rely on nature, memory, and courage to survive.\r\n\r\nA stirring blend of suspense and serenity, ideal for fans of introspective survival tales.", "SOTJ1111111101", 30.0, 27.0, 20.0, 25.0, "Rock in the Ocean" },
                    { 6, "Laura Phantom", 3, "An enchanting journey through forest folklore and natural magic. A botanist stumbles upon a hidden realm where leaves whisper stories and trees guard ancient wisdom.\r\n\r\nBlending fantasy and serenity, this tale invites readers into a world of quiet wonder.", "FOT000000001", 25.0, 23.0, 20.0, 22.0, "Leaves and Wonders" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ");
        }
    }
}
