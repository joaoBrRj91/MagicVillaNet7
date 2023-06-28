using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla.API.Migrations
{
    /// <inheritdoc />
    public partial class AddColumVillaNumberId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("0f141e14-15f5-42cd-a5e3-e024ca382c47"));

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("12d1da60-2dc2-4719-99fb-cde9dc8231e6"));

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("97dd3c82-b3ee-413a-a757-dd5cc222a047"));

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("db66d6f5-14c9-44ca-8a4c-21fbaca93564"));

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("e8dfacef-e472-439e-ac57-4523e388158b"));

            migrationBuilder.AddColumn<Guid>(
                name: "VillaNumberId",
                table: "Villas",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CodVilla", "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft", "UodatedDate", "VillaNumberId", "imageUrl" },
                values: new object[,]
                {
                    { new Guid("6ea85422-d866-40d4-a32c-aa3faea0d534"), "", "DIAMOND POOL VILLA-5507862466826226597", new DateTime(2023, 6, 28, 18, 43, 57, 533, DateTimeKind.Local).AddTicks(3310), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Diamond Pool Villa", 4, 600.0, 1100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg" },
                    { new Guid("8bc08d2d-786a-471b-96bc-76f9920f4d15"), "", "ROYAL VILLA-6594355368041288959", new DateTime(2023, 6, 28, 18, 43, 57, 533, DateTimeKind.Local).AddTicks(3130), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Royal Villa", 4, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg" },
                    { new Guid("cdb78392-ac99-486b-91cd-1aac2748f031"), "", "DIAMOND VILLA-5184515499140905454", new DateTime(2023, 6, 28, 18, 43, 57, 533, DateTimeKind.Local).AddTicks(3280), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Diamond Villa", 4, 550.0, 900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg" },
                    { new Guid("e52d1b46-d99f-4cc6-a0b9-84744ffdf669"), "", "LUXURY POOL VILLA-6321911891011742494", new DateTime(2023, 6, 28, 18, 43, 57, 533, DateTimeKind.Local).AddTicks(3260), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Luxury Pool Villa", 4, 400.0, 750, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg" },
                    { new Guid("ff73dc2a-b036-46d1-86b5-ce6bcec8432b"), "", "PREMIUM POOL VILLA-6432176193701704629", new DateTime(2023, 6, 28, 18, 43, 57, 533, DateTimeKind.Local).AddTicks(3230), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Premium Pool Villa", 4, 300.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("6ea85422-d866-40d4-a32c-aa3faea0d534"));

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("8bc08d2d-786a-471b-96bc-76f9920f4d15"));

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("cdb78392-ac99-486b-91cd-1aac2748f031"));

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("e52d1b46-d99f-4cc6-a0b9-84744ffdf669"));

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: new Guid("ff73dc2a-b036-46d1-86b5-ce6bcec8432b"));

            migrationBuilder.DropColumn(
                name: "VillaNumberId",
                table: "Villas");

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CodVilla", "CreatedDate", "Details", "Name", "Occupancy", "Rate", "Sqft", "UodatedDate", "imageUrl" },
                values: new object[,]
                {
                    { new Guid("0f141e14-15f5-42cd-a5e3-e024ca382c47"), "", "LUXURY POOL VILLA-5660578027540656005", new DateTime(2023, 6, 28, 17, 26, 1, 12, DateTimeKind.Local).AddTicks(6600), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Luxury Pool Villa", 4, 400.0, 750, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg" },
                    { new Guid("12d1da60-2dc2-4719-99fb-cde9dc8231e6"), "", "ROYAL VILLA-7910064154366320123", new DateTime(2023, 6, 28, 17, 26, 1, 12, DateTimeKind.Local).AddTicks(6420), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Royal Villa", 4, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg" },
                    { new Guid("97dd3c82-b3ee-413a-a757-dd5cc222a047"), "", "DIAMOND POOL VILLA-606261136968324026", new DateTime(2023, 6, 28, 17, 26, 1, 12, DateTimeKind.Local).AddTicks(6680), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Diamond Pool Villa", 4, 600.0, 1100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg" },
                    { new Guid("db66d6f5-14c9-44ca-8a4c-21fbaca93564"), "", "DIAMOND VILLA-2859613693115668480", new DateTime(2023, 6, 28, 17, 26, 1, 12, DateTimeKind.Local).AddTicks(6640), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Diamond Villa", 4, 550.0, 900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg" },
                    { new Guid("e8dfacef-e472-439e-ac57-4523e388158b"), "", "PREMIUM POOL VILLA-5671017674291781161", new DateTime(2023, 6, 28, 17, 26, 1, 12, DateTimeKind.Local).AddTicks(6550), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Premium Pool Villa", 4, 300.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg" }
                });
        }
    }
}
