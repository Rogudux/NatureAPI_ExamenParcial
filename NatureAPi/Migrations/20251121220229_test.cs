using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureAPi.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "PlaceAmenity",
                keyColumns: new[] { "AmenityId", "PlaceId" },
                keyValues: new object[] { 4, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlaceAmenity",
                columns: new[] { "AmenityId", "PlaceId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 }
                });
        }
    }
}
