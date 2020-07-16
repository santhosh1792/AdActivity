using Microsoft.EntityFrameworkCore.Migrations;

namespace AdActivity.Infra.Data.Migrations
{
    public partial class Migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrandBRNId",
                table: "Campaigns",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
