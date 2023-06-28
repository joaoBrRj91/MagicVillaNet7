using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla.API.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedForVillaNumberIdInVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CodVilla", "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft", "UodatedDate", "VillaNumberId", "imageUrl" },
                values: new object[] { new Guid("99e4a417-fea3-4009-ab44-5c4b5729022e"), "", "ROYAL VILLA-958370548417775862", new DateTime(2023, 6, 28, 19, 18, 0, 199, DateTimeKind.Local).AddTicks(6810), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Royal Villa", 4, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("95ca3dfb-8ffe-430e-9e3d-da2b4b6f9486"), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("99e4a417-fea3-4009-ab44-5c4b5729022e"));
        }
    }
}
