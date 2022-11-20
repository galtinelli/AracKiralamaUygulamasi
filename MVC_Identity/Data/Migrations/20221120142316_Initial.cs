using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Identity.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aracs_Renk_RenkId",
                table: "Aracs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Renk",
                table: "Renk");

            migrationBuilder.RenameTable(
                name: "Renk",
                newName: "Renks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Renks",
                table: "Renks",
                column: "RenkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aracs_Renks_RenkId",
                table: "Aracs",
                column: "RenkId",
                principalTable: "Renks",
                principalColumn: "RenkId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aracs_Renks_RenkId",
                table: "Aracs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Renks",
                table: "Renks");

            migrationBuilder.RenameTable(
                name: "Renks",
                newName: "Renk");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Renk",
                table: "Renk",
                column: "RenkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aracs_Renk_RenkId",
                table: "Aracs",
                column: "RenkId",
                principalTable: "Renk",
                principalColumn: "RenkId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
