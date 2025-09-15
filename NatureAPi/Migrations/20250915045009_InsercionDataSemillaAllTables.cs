using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureAPi.Migrations
{
    /// <inheritdoc />
    public partial class InsercionDataSemillaAllTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Amenity",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Departamento frente a playa isla mujeres" },
                    { 2, "Cabaña a un lado de monumentos en playa isla mujeres" },
                    { 3, "Zona de campamento en selva lacandona" },
                    { 4, "Bote equipado en medio del rio en selva lacandona" }
                });

            migrationBuilder.InsertData(
                table: "Photo",
                columns: new[] { "Id", "PlaceId", "URL" },
                values: new object[,]
                {
                    { 1, 1, "https://images.odigoo.com/cb6a1e9c-21c6-4165-9ba7-db9263d832a1/images/media/isla-mujeres-beaches/webp/playa-norte-htfw.webp" },
                    { 2, 1, "https://cdn.sanity.io/images/atvntylo/production/52a6fcd9855b358bda42ad22de46ad0dfdbd7673-1200x630.png" },
                    { 3, 2, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQNIIv3OeZuYBcyk2F1mR6e-19hILJZ5BpiVA&s" },
                    { 4, 2, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR9BeIi7ay8rQgZG4HEnLqGsjwmdFgKo_81xg&s" }
                });

            migrationBuilder.UpdateData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 2,
                column: "Category",
                value: "Selva");

            migrationBuilder.InsertData(
                table: "Trail",
                columns: new[] { "Id", "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path", "PlaceId" },
                values: new object[,]
                {
                    { 1, "Facil", 1.2, 25, true, "Sendero Escultórico de Punta Sur", "Un camino costero que rodea el acantilado sur de la isla, pasando por un jardín de esculturas y con vistas espectaculares al mar Caribe.", 1 },
                    { 2, "Dificil", 2.5, 45, true, "Circuito de la Salina Grande", "Ruta plana que bordea la laguna salada en el centro de la isla, ideal para observar aves y disfrutar de un paisaje diferente al de la playa.", 1 },
                    { 3, "Intermedio", 4.5, 120, false, "Sendero del Río Lacanjá", "Una caminata inmersiva a lo largo de la ribera del río Lacanjá, atravesando vegetación densa y puentes colgantes, terminando en una serie de cascadas.", 2 },
                    { 4, "Facil", 3.0, 90, true, "Exploración de la Zona Arqueológica de Yaxchilán", "Circuito que conecta las principales estructuras y estelas mayas de Yaxchilán, un sitio accesible solo por río. El sendero está rodeado por el sonido de monos aulladores.", 2 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 4);

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

            migrationBuilder.DeleteData(
                table: "Trail",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trail",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trail",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trail",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Amenity",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenity",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenity",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Amenity",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Place",
                keyColumn: "Id",
                keyValue: 2,
                column: "Category",
                value: "Selva Tropical y Reserva de la Biósfera");
        }
    }
}
