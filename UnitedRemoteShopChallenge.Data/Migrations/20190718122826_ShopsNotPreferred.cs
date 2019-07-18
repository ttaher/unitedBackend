using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UnitedRemoteShopChallenge.Data.Migrations
{
    public partial class ShopsNotPreferred : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopsNotPreferreds",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ShopsPreferredId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    ShopId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopsNotPreferreds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopsNotPreferreds_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShopsNotPreferreds_IdnentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "IdnentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopsNotPreferreds_ShopId",
                table: "ShopsNotPreferreds",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopsNotPreferreds_UserId",
                table: "ShopsNotPreferreds",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopsNotPreferreds");
        }
    }
}
