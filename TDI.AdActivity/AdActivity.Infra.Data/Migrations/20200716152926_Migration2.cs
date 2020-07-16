using Microsoft.EntityFrameworkCore.Migrations;

namespace AdActivity.Infra.Data.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_FundingTypeId",
                table: "Campaigns",
                column: "FundingTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Campaigns_FundingTypes_FundingTypeId",
                table: "Campaigns",
                column: "FundingTypeId",
                principalTable: "FundingTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campaigns_FundingTypes_FundingTypeId",
                table: "Campaigns");

            migrationBuilder.DropIndex(
                name: "IX_Campaigns_FundingTypeId",
                table: "Campaigns");
        }
    }
}
