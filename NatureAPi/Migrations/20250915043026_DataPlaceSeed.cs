using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureAPi.Migrations
{
    /// <inheritdoc />
    public partial class DataPlaceSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Place",
                columns: new[] { "Id", "Accessible", "Category", "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[,]
                {
                    { 1, true, "Playa", new DateTime(2025, 9, 14, 22, 30, 25, 901, DateTimeKind.Local).AddTicks(3720), "Reconocida mundialmente por su arena blanca y fina, y sus aguas cristalinas de poca profundidad y oleaje suave, ideal para nadar y relajarse.", 1, 0.0, 21.2577, -86.7517, "Playa Isla Mujeres", "Abierto 24 horas" },
                    { 2, true, "Selva Tropical y Reserva de la Biósfera", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Una de las regiones de mayor diversidad biológica de México y el mundo. Es el corazón de la selva tropical más grande del país y hogar de especies como el jaguar y la guacamaya roja.", 200, 300.0, 16.633299999999998, -91.0, "Selva Lacandona", "Varía según el tour; generalmente 7:00 AM - 6:00 PM" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
