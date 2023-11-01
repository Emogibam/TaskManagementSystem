using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagementSystem.Infrastruture.Migrations
{
    public partial class AddingAnnotationToEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emails_AspNetUsers_ApplicationUserId",
                table: "Emails");

            migrationBuilder.DropIndex(
                name: "IX_Emails_ApplicationUserId",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Emails");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_UserId",
                table: "Emails",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_AspNetUsers_UserId",
                table: "Emails",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emails_AspNetUsers_UserId",
                table: "Emails");

            migrationBuilder.DropIndex(
                name: "IX_Emails_UserId",
                table: "Emails");

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserId",
                table: "Emails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Emails_ApplicationUserId",
                table: "Emails",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_AspNetUsers_ApplicationUserId",
                table: "Emails",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
