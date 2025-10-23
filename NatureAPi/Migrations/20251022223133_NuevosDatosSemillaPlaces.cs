using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureAPi.Migrations
{
    /// <inheritdoc />
    public partial class NuevosDatosSemillaPlaces : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Place",
                columns: new[] { "Id", "Accessible", "Category", "CreatedAt", "Description", "ElevationMeters", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[,]
                {
                    { 4, true, "Formación geológica", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Formaciones petrificadas de travertino con pozas naturales color turquesa en la Sierra de Oaxaca, con miradores y senderos panorámicos.", 1800, 70.0, 16.867000000000001, -96.268000000000001, "Hierve el Agua", "08:00 - 18:00" },
                    { 5, true, "Cascada", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Conjunto de cascadas de color turquesa formadas por sales calcáreas en la selva chiapaneca; senderos, miradores y áreas de baño señalizadas.", 150, 50.0, 17.268000000000001, -92.108999999999995, "Cascadas de Agua Azul", "08:00 - 18:00" },
                    { 6, true, "Cañón", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Sistema de cañones más extenso que el Gran Cañón; miradores espectaculares, teleférico y rutas de senderismo en la Sierra Tarahumara.", 2400, 0.0, 27.535, -107.81, "Barrancas del Cobre (Divisadero)", "08:00 - 18:00" },
                    { 7, true, "Volcán", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Volcán con lagunas crátericas (Sol y Luna) y paisajes de alta montaña; rutas de senderismo con control de acceso en temporada.", 4680, 54.0, 19.108000000000001, -99.757999999999996, "Nevado de Toluca (Xinantécatl)", "07:00 - 16:00" },
                    { 8, true, "Laguna", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Laguna cristalina de tonos azul-turquesa con estromatolitos, cenotes y balnearios; ideal para kayak, paddle y paseos en lancha.", 10, 50.0, 18.669, -88.391000000000005, "Laguna de Bacalar (Laguna de los Siete Colores)", "08:00 - 18:00" },
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
