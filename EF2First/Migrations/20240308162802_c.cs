using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF2First.Migrations
{
    /// <inheritdoc />
    public partial class c : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "author",
                columns: table => new
                {
                    Auth_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    joindate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_author", x => x.Auth_id);
                });

            migrationBuilder.CreateTable(
                name: "catalog",
                columns: table => new
                {
                    Ct_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catalog", x => x.Ct_id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    New_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    bref = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Au_id = table.Column<int>(type: "int", nullable: false),
                    Cat_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.New_id);
                    table.ForeignKey(
                        name: "FK_News_author_Au_id",
                        column: x => x.Au_id,
                        principalTable: "author",
                        principalColumn: "Auth_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_News_catalog_Cat_id",
                        column: x => x.Cat_id,
                        principalTable: "catalog",
                        principalColumn: "Ct_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_News_Au_id",
                table: "News",
                column: "Au_id");

            migrationBuilder.CreateIndex(
                name: "IX_News_Cat_id",
                table: "News",
                column: "Cat_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "author");

            migrationBuilder.DropTable(
                name: "catalog");
        }
    }
}
