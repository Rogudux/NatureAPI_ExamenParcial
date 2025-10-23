using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NatureAPi.Migrations
{
    /// <inheritdoc />
    public partial class SeedNuevasCONAmennn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Place_PlaceId",
                table: "Photo");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaceAmenity_Amenity_AmenityId",
                table: "PlaceAmenity");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaceAmenity_Place_PlaceId",
                table: "PlaceAmenity");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Place_PlaceId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Trail_Place_PlaceId",
                table: "Trail");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Place_PlaceId",
                table: "Photo",
                column: "PlaceId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaceAmenity_Amenity_AmenityId",
                table: "PlaceAmenity",
                column: "AmenityId",
                principalTable: "Amenity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaceAmenity_Place_PlaceId",
                table: "PlaceAmenity",
                column: "PlaceId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Place_PlaceId",
                table: "Review",
                column: "PlaceId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trail_Place_PlaceId",
                table: "Trail",
                column: "PlaceId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Place_PlaceId",
                table: "Photo");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaceAmenity_Amenity_AmenityId",
                table: "PlaceAmenity");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaceAmenity_Place_PlaceId",
                table: "PlaceAmenity");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Place_PlaceId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Trail_Place_PlaceId",
                table: "Trail");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Place_PlaceId",
                table: "Photo",
                column: "PlaceId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaceAmenity_Amenity_AmenityId",
                table: "PlaceAmenity",
                column: "AmenityId",
                principalTable: "Amenity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaceAmenity_Place_PlaceId",
                table: "PlaceAmenity",
                column: "PlaceId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Place_PlaceId",
                table: "Review",
                column: "PlaceId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trail_Place_PlaceId",
                table: "Trail",
                column: "PlaceId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
