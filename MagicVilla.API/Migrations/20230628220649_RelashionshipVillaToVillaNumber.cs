using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla.API.Migrations
{
    /// <inheritdoc />
    public partial class RelashionshipVillaToVillaNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "VillaNumberId",
                table: "Villas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Villas_VillaNumberId",
                table: "Villas",
                column: "VillaNumberId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Villas_VillaNumbers_VillaNumberId",
                table: "Villas",
                column: "VillaNumberId",
                principalTable: "VillaNumbers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Villas_VillaNumbers_VillaNumberId",
                table: "Villas");

            migrationBuilder.DropIndex(
                name: "IX_Villas_VillaNumberId",
                table: "Villas");

            migrationBuilder.AlterColumn<Guid>(
                name: "VillaNumberId",
                table: "Villas",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }
    }
}
