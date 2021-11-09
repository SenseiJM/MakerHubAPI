using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MakerHubAPI.DAL.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Annonce",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Annonce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Competition",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Heure = table.Column<TimeSpan>(type: "time", nullable: false),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    Lieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreMax = table.Column<int>(type: "int", nullable: true),
                    CategorieAge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassementMinimum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassementMaximum = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competition", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Joueur",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDAFTT = table.Column<int>(type: "int", nullable: false),
                    IdentifiantConnexion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotDePasse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDEquipeHommes = table.Column<int>(type: "int", nullable: true),
                    IDEquipeDames = table.Column<int>(type: "int", nullable: true),
                    HeureDepartHommes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeureDepartDames = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joueur", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Souper",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDType = table.Column<int>(type: "int", nullable: false),
                    PrixAffilies = table.Column<double>(type: "float", nullable: false),
                    PrixExternes = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NombreMax = table.Column<int>(type: "int", nullable: true),
                    TypeSouper = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Titre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Souper", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Stage",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HeureDebut = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    HeureFin = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    PrixAffilies = table.Column<double>(type: "float", nullable: false),
                    PrixExternes = table.Column<double>(type: "float", nullable: false),
                    Entraineur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombreMax = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    ClassementMinimum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassementMaximum = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stage", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JoueurCompetition",
                columns: table => new
                {
                    IDJoueur = table.Column<int>(type: "int", nullable: false),
                    IDCompetition = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoueurCompetition", x => new { x.IDCompetition, x.IDJoueur });
                    table.ForeignKey(
                        name: "FK_JoueurCompetition_Competition_IDCompetition",
                        column: x => x.IDCompetition,
                        principalTable: "Competition",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JoueurCompetition_Joueur_IDJoueur",
                        column: x => x.IDJoueur,
                        principalTable: "Joueur",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JoueurStage",
                columns: table => new
                {
                    IDJoueur = table.Column<int>(type: "int", nullable: false),
                    IDStage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoueurStage", x => new { x.IDStage, x.IDJoueur });
                    table.ForeignKey(
                        name: "FK_JoueurStage_Joueur_IDJoueur",
                        column: x => x.IDJoueur,
                        principalTable: "Joueur",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JoueurStage_Stage_IDStage",
                        column: x => x.IDStage,
                        principalTable: "Stage",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JoueurCompetition_IDJoueur",
                table: "JoueurCompetition",
                column: "IDJoueur");

            migrationBuilder.CreateIndex(
                name: "IX_JoueurStage_IDJoueur",
                table: "JoueurStage",
                column: "IDJoueur");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Annonce");

            migrationBuilder.DropTable(
                name: "JoueurCompetition");

            migrationBuilder.DropTable(
                name: "JoueurStage");

            migrationBuilder.DropTable(
                name: "Souper");

            migrationBuilder.DropTable(
                name: "Competition");

            migrationBuilder.DropTable(
                name: "Joueur");

            migrationBuilder.DropTable(
                name: "Stage");
        }
    }
}
