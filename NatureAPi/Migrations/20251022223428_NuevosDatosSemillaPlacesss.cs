using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureAPi.Migrations
{
    /// <inheritdoc />
    public partial class NuevosDatosSemillaPlacesss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Place",
                columns: new[] { "Id", "Accessible", "Category", "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { 3, true, "Formación geológica", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Formaciones petrificadas de travertino con pozas naturales color turquesa en la Sierra de Oaxaca, con miradores y senderos panorámicos.", 1800, 70.0, 16.867000000000001, -96.268000000000001, "Hierve el Agua", "08:00 - 18:00" });
        }
    }
}
