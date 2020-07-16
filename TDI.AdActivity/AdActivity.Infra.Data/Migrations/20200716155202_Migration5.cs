using Microsoft.EntityFrameworkCore.Migrations;

namespace AdActivity.Infra.Data.Migrations
{
    public partial class Migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campaigns_Brands_BrandBRNId",
                table: "Campaigns");

            migrationBuilder.DropIndex(
                name: "IX_Campaigns_BrandBRNId",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "BrandBRNId",
                table: "Campaigns");

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_BRNId",
                table: "Campaigns",
                column: "BRNId");

            migrationBuilder.AddForeignKey(
                name: "FK_Campaigns_Brands_BRNId",
                table: "Campaigns",
                column: "BRNId",
                principalTable: "Brands",
                principalColumn: "BRNId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campaigns_Brands_BRNId",
                table: "Campaigns");

            migrationBuilder.DropIndex(
                name: "IX_Campaigns_BRNId",
                table: "Campaigns");

            migrationBuilder.AddColumn<int>(
                name: "BrandBRNId",
                table: "Campaigns",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_BrandBRNId",
                table: "Campaigns",
                column: "BrandBRNId");

            migrationBuilder.AddForeignKey(
                name: "FK_Campaigns_Brands_BrandBRNId",
                table: "Campaigns",
                column: "BrandBRNId",
                principalTable: "Brands",
                principalColumn: "BRNId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
