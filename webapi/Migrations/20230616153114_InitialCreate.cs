using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartridgePublishers",
                columns: table => new
                {
                    CartridgePublisherId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartridgePublishers", x => x.CartridgePublisherId);
                });

            migrationBuilder.CreateTable(
                name: "CartridgeTypes",
                columns: table => new
                {
                    CartridgeTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartridgeTypes", x => x.CartridgeTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Path = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.PhotoId);
                });

            migrationBuilder.CreateTable(
                name: "Roms",
                columns: table => new
                {
                    RomId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Path = table.Column<string>(type: "text", nullable: false),
                    Hash = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roms", x => x.RomId);
                });

            migrationBuilder.CreateTable(
                name: "Cartridges",
                columns: table => new
                {
                    CartridgeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Catalog = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CartridgePublisherId = table.Column<int>(type: "integer", nullable: true),
                    CartridgeTypeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cartridges", x => x.CartridgeId);
                    table.ForeignKey(
                        name: "FK_Cartridges_CartridgePublishers_CartridgePublisherId",
                        column: x => x.CartridgePublisherId,
                        principalTable: "CartridgePublishers",
                        principalColumn: "CartridgePublisherId");
                    table.ForeignKey(
                        name: "FK_Cartridges_CartridgeTypes_CartridgeTypeId",
                        column: x => x.CartridgeTypeId,
                        principalTable: "CartridgeTypes",
                        principalColumn: "CartridgeTypeId");
                });

            migrationBuilder.CreateTable(
                name: "CartridgeGame",
                columns: table => new
                {
                    CartridgeId = table.Column<int>(type: "integer", nullable: false),
                    GameId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartridgeGame", x => new { x.GameId, x.CartridgeId });
                    table.ForeignKey(
                        name: "FK_CartridgeGame_Cartridges_CartridgeId",
                        column: x => x.CartridgeId,
                        principalTable: "Cartridges",
                        principalColumn: "CartridgeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartridgeGame_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartridgePhoto",
                columns: table => new
                {
                    CartridgeId = table.Column<int>(type: "integer", nullable: false),
                    PhotoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartridgePhoto", x => new { x.PhotoId, x.CartridgeId });
                    table.ForeignKey(
                        name: "FK_CartridgePhoto_Cartridges_CartridgeId",
                        column: x => x.CartridgeId,
                        principalTable: "Cartridges",
                        principalColumn: "CartridgeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartridgePhoto_Photos_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photos",
                        principalColumn: "PhotoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartridgeRom",
                columns: table => new
                {
                    CartridgeId = table.Column<int>(type: "integer", nullable: false),
                    RomId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartridgeRom", x => new { x.RomId, x.CartridgeId });
                    table.ForeignKey(
                        name: "FK_CartridgeRom_Cartridges_CartridgeId",
                        column: x => x.CartridgeId,
                        principalTable: "Cartridges",
                        principalColumn: "CartridgeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartridgeRom_Roms_RomId",
                        column: x => x.RomId,
                        principalTable: "Roms",
                        principalColumn: "RomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartridgeGame_CartridgeId",
                table: "CartridgeGame",
                column: "CartridgeId");

            migrationBuilder.CreateIndex(
                name: "IX_CartridgePhoto_CartridgeId",
                table: "CartridgePhoto",
                column: "CartridgeId");

            migrationBuilder.CreateIndex(
                name: "IX_CartridgeRom_CartridgeId",
                table: "CartridgeRom",
                column: "CartridgeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cartridges_CartridgePublisherId",
                table: "Cartridges",
                column: "CartridgePublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Cartridges_CartridgeTypeId",
                table: "Cartridges",
                column: "CartridgeTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartridgeGame");

            migrationBuilder.DropTable(
                name: "CartridgePhoto");

            migrationBuilder.DropTable(
                name: "CartridgeRom");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Cartridges");

            migrationBuilder.DropTable(
                name: "Roms");

            migrationBuilder.DropTable(
                name: "CartridgePublishers");

            migrationBuilder.DropTable(
                name: "CartridgeTypes");
        }
    }
}
