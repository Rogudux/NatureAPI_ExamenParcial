using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureAPi.Migrations
{
    /// <inheritdoc />
    public partial class SeedPlaces_6a10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { "Cascada", "Conjunto de cascadas de color turquesa formadas por sales calcáreas en la selva chiapaneca; senderos, miradores y áreas de baño señalizadas.", 150, 50.0, 17.268000000000001, -92.108999999999995, "Cascadas de Agua Azul", "08:00 - 18:00" });

            migrationBuilder.UpdateData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name" },
                values: new object[] { "Cañón", "Sistema de cañones más extenso que el Gran Cañón; miradores espectaculares, teleférico y rutas de senderismo en la Sierra Tarahumara.", 2400, 0.0, 27.535, -107.81, "Barrancas del Cobre (Divisadero)" });

            migrationBuilder.UpdateData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { "Volcán", "Volcán con lagunas crátericas (Sol y Luna) y paisajes de alta montaña; rutas de senderismo con control de acceso en temporada.", 4680, 54.0, 19.108000000000001, -99.757999999999996, "Nevado de Toluca (Xinantécatl)", "07:00 - 16:00" });

            migrationBuilder.InsertData(
                table: "Place",
                columns: new[] { "Id", "Accessible", "Category", "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[,]
                {
                    { 9, true, "Laguna", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Laguna cristalina de tonos azul-turquesa con estromatolitos, cenotes y balnearios; ideal para kayak, paddle y paseos en lancha.", 10, 50.0, 18.669, -88.391000000000005, "Laguna de Bacalar (Laguna de los Siete Colores)", "08:00 - 18:00" },
                    { 10, true, "Cañón", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Imponente cañón con paredes de más de 1000 m de altura, recorridos en lancha por el río Grijalva y miradores panorámicos.", 450, 250.0, 16.832999999999998, -93.102000000000004, "Cañón del Sumidero", "08:00 - 17:00" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { "Volcán", "Volcán con lagunas crátericas (Sol y Luna) y paisajes de alta montaña; rutas de senderismo con control de acceso en temporada.", 4680, 54.0, 19.108000000000001, -99.757999999999996, "Nevado de Toluca (Xinantécatl)", "07:00 - 16:00" });

            migrationBuilder.UpdateData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name" },
                values: new object[] { "Laguna", "Laguna cristalina de tonos azul-turquesa con estromatolitos, cenotes y balnearios; ideal para kayak, paddle y paseos en lancha.", 10, 50.0, 18.669, -88.391000000000005, "Laguna de Bacalar (Laguna de los Siete Colores)" });

            migrationBuilder.UpdateData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[] { "Cañón", "Imponente cañón con paredes de más de 1000 m de altura, recorridos en lancha por el río Grijalva y miradores panorámicos.", 450, 250.0, 16.832999999999998, -93.102000000000004, "Cañón del Sumidero", "08:00 - 17:00" });

            migrationBuilder.InsertData(
                table: "Place",
                columns: new[] { "Id", "Accessible", "Category", "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[,]
                {
                    { 1, true, "Playa", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Reconocida mundialmente por su arena blanca y fina, y sus aguas cristalinas de poca profundidad y oleaje suave, ideal para nadar y relajarse.", 1, 0.0, 21.2577, -86.7517, "Playa Isla Mujeres", "Abierto 24 horas" },
                    { 2, true, "Selva", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Una de las regiones de mayor diversidad biológica de México y el mundo. Es el corazón de la selva tropical más grande del país y hogar de especies como el jaguar y la guacamaya roja.", 200, 300.0, 16.633299999999998, -91.0, "Selva Lacandona", "Varía según el tour; generalmente 7:00 AM - 6:00 PM" },
                    { 4, true, "Cascada", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Conjunto de cascadas de color turquesa formadas por sales calcáreas en la selva chiapaneca; senderos, miradores y áreas de baño señalizadas.", 150, 50.0, 17.268000000000001, -92.108999999999995, "Cascadas de Agua Azul", "08:00 - 18:00" },
                    { 5, true, "Cañón", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Sistema de cañones más extenso que el Gran Cañón; miradores espectaculares, teleférico y rutas de senderismo en la Sierra Tarahumara.", 2400, 0.0, 27.535, -107.81, "Barrancas del Cobre (Divisadero)", "08:00 - 18:00" }
                });
        }
    }
}
