using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NatureAPi.Migrations
{
    /// <inheritdoc />
    public partial class SeedNuevas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Photo",
                columns: new[] { "Id", "PlaceId", "URL" },
                values: new object[,]
                {
                    { 6, 6, "https://visitachiapas.com/wp-content/uploads/32080021_2001255793535615_8694945979746484224_n-845x684.jpg" },
                    { 7, 7, "https://static.wixstatic.com/media/cf3297_1207992ee7504d6b89bef1ad615630e4~mv2.jpg/v1/fill/w_568,h_378,al_c,q_80,usm_0.66_1.00_0.01,enc_avif,quality_auto/cf3297_1207992ee7504d6b89bef1ad615630e4~mv2.jpg" },
                    { 8, 8, "https://upload.wikimedia.org/wikipedia/commons/thumb/2/28/Vista_del_Nevado_de_Toluca.jpg/1280px-Vista_del_Nevado_de_Toluca.jpg" },
                    { 9, 9, "https://www.gob.mx/cms/uploads/article/main_image/83508/BACALAR-web.jpg" },
                    { 10, 10, "https://www.shutterstock.com/image-photo/sumidero-canyon-chiapas-mexico-600nw-2292202987.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Trail",
                columns: new[] { "Id", "Difficulty", "DistanceKm", "EstimatedTimeMinutes", "IsLoop", "Name", "Path", "PlaceId" },
                values: new object[,]
                {
                    { 101, "Moderado", 2.3999999999999999, 75, false, "Sendero Pozas Turquesa", "Tramo sombreado que sigue el cauce del rio con miradores a varias caidas; se avanza sobre pasarelas y roca humeda, con tramos resbalosos tras lluvia.", 6 },
                    { 102, "Dificil", 7.0, 210, false, "Miradores del Divisadero", "Recorrido por la cresta con sube y baja constante; bordea varios miradores naturales con secciones expuestas y terreno pedregoso.", 7 },
                    { 103, "Dificil", 5.5, 180, true, "Lagunas del Sol y la Luna", "Circuito a gran altitud que desciende al crater y rodea ambas lagunas; piso de arena volcanica y piedra suelta con pendientes pronunciadas.", 8 },
                    { 104, "Facil", 3.2000000000000002, 80, true, "Costera de los Siete Colores", "Camino llano junto a la laguna con accesos a muelles y miradores; ideal para paseo suave con paradas para fotografias.", 9 },
                    { 105, "Moderado", 4.0, 120, false, "Ribera del Grijalva", "Senda riberenia entre selva baja y paredones del cañon; zonas con lodazales en temporada y tramos estrechos junto al rio.", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Photo",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Trail",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Trail",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Trail",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Trail",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Trail",
                keyColumn: "Id",
                keyValue: 105);

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
        }
    }
}
