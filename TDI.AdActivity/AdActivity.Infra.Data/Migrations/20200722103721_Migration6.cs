using Microsoft.EntityFrameworkCore.Migrations;

namespace AdActivity.Infra.Data.Migrations
{
    public partial class Migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campaigns_Brands_BRNId",
                table: "Campaigns");

            migrationBuilder.DropForeignKey(
                name: "FK_Campaigns_FundingTypes_FundingTypeId",
                table: "Campaigns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FundingTypes",
                table: "FundingTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Campaigns",
                table: "Campaigns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brands",
                table: "Brands");

            migrationBuilder.RenameTable(
                name: "FundingTypes",
                newName: "FundingType");

            migrationBuilder.RenameTable(
                name: "Campaigns",
                newName: "Campaign");

            migrationBuilder.RenameTable(
                name: "Brands",
                newName: "Brand");

            migrationBuilder.RenameIndex(
                name: "IX_Campaigns_FundingTypeId",
                table: "Campaign",
                newName: "IX_Campaign_FundingTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Campaigns_BRNId",
                table: "Campaign",
                newName: "IX_Campaign_BRNId");

            migrationBuilder.AlterColumn<bool>(
                name: "IsPlaceholder",
                table: "Campaign",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FundingType",
                table: "FundingType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Campaign",
                table: "Campaign",
                column: "CAMId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brand",
                table: "Brand",
                column: "BRNId");

            migrationBuilder.AddForeignKey(
                name: "FK_Campaign_Brand_BRNId",
                table: "Campaign",
                column: "BRNId",
                principalTable: "Brand",
                principalColumn: "BRNId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Campaign_FundingType_FundingTypeId",
                table: "Campaign",
                column: "FundingTypeId",
                principalTable: "FundingType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campaign_Brand_BRNId",
                table: "Campaign");

            migrationBuilder.DropForeignKey(
                name: "FK_Campaign_FundingType_FundingTypeId",
                table: "Campaign");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FundingType",
                table: "FundingType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Campaign",
                table: "Campaign");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brand",
                table: "Brand");

            migrationBuilder.RenameTable(
                name: "FundingType",
                newName: "FundingTypes");

            migrationBuilder.RenameTable(
                name: "Campaign",
                newName: "Campaigns");

            migrationBuilder.RenameTable(
                name: "Brand",
                newName: "Brands");

            migrationBuilder.RenameIndex(
                name: "IX_Campaign_FundingTypeId",
                table: "Campaigns",
                newName: "IX_Campaigns_FundingTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Campaign_BRNId",
                table: "Campaigns",
                newName: "IX_Campaigns_BRNId");

            migrationBuilder.AlterColumn<string>(
                name: "IsPlaceholder",
                table: "Campaigns",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddPrimaryKey(
                name: "PK_FundingTypes",
                table: "FundingTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Campaigns",
                table: "Campaigns",
                column: "CAMId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brands",
                table: "Brands",
                column: "BRNId");

            migrationBuilder.AddForeignKey(
                name: "FK_Campaigns_Brands_BRNId",
                table: "Campaigns",
                column: "BRNId",
                principalTable: "Brands",
                principalColumn: "BRNId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Campaigns_FundingTypes_FundingTypeId",
                table: "Campaigns",
                column: "FundingTypeId",
                principalTable: "FundingTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
