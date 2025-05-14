using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG7311_ST10349038_POE.Data.Migrations
{
    /// <inheritdoc />
    public partial class _22ndMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Profiles_ProfileId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProfileId",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Products_ProfileId",
                table: "Products",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Profiles_ProfileId",
                table: "Products",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
