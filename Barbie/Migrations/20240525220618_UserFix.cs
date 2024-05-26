using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barbie.Migrations
{
    /// <inheritdoc />
    public partial class UserFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Barbers_Users_UserId",
                table: "Barbers");

            migrationBuilder.DropIndex(
                name: "IX_Barbers_UserId",
                table: "Barbers");

            migrationBuilder.AddColumn<Guid>(
                name: "BarbershopId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Barbers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BarbershopId",
                table: "Users",
                column: "BarbershopId");

            migrationBuilder.CreateIndex(
                name: "IX_Barbers_UserId",
                table: "Barbers",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Barbers_Users_UserId",
                table: "Barbers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Barbershops_BarbershopId",
                table: "Users",
                column: "BarbershopId",
                principalTable: "Barbershops",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Barbers_Users_UserId",
                table: "Barbers");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Barbershops_BarbershopId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_BarbershopId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Barbers_UserId",
                table: "Barbers");

            migrationBuilder.DropColumn(
                name: "BarbershopId",
                table: "Users");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Barbers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Barbers_UserId",
                table: "Barbers",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Barbers_Users_UserId",
                table: "Barbers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
