using Microsoft.EntityFrameworkCore.Migrations;

namespace Tp2.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "secteurs",
                columns: table => new
                {
                    codeSecteur = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomSecteur = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_secteurs", x => x.codeSecteur);
                });

            migrationBuilder.CreateTable(
                name: "filieres",
                columns: table => new
                {
                    codeF = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codeSecteur = table.Column<int>(type: "int", nullable: false),
                    secteurcodeSecteur = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filieres", x => x.codeF);
                    table.ForeignKey(
                        name: "FK_filieres_secteurs_secteurcodeSecteur",
                        column: x => x.secteurcodeSecteur,
                        principalTable: "secteurs",
                        principalColumn: "codeSecteur",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "groupes",
                columns: table => new
                {
                    codeG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeF = table.Column<int>(type: "int", nullable: false),
                    filierecodeF = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groupes", x => x.codeG);
                    table.ForeignKey(
                        name: "FK_groupes_filieres_filierecodeF",
                        column: x => x.filierecodeF,
                        principalTable: "filieres",
                        principalColumn: "codeF",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "modules",
                columns: table => new
                {
                    codeM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MassH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codeF = table.Column<int>(type: "int", nullable: false),
                    filierecodeF = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modules", x => x.codeM);
                    table.ForeignKey(
                        name: "FK_modules_filieres_filierecodeF",
                        column: x => x.filierecodeF,
                        principalTable: "filieres",
                        principalColumn: "codeF",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_filieres_secteurcodeSecteur",
                table: "filieres",
                column: "secteurcodeSecteur");

            migrationBuilder.CreateIndex(
                name: "IX_groupes_filierecodeF",
                table: "groupes",
                column: "filierecodeF");

            migrationBuilder.CreateIndex(
                name: "IX_modules_filierecodeF",
                table: "modules",
                column: "filierecodeF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "groupes");

            migrationBuilder.DropTable(
                name: "modules");

            migrationBuilder.DropTable(
                name: "filieres");

            migrationBuilder.DropTable(
                name: "secteurs");
        }
    }
}
