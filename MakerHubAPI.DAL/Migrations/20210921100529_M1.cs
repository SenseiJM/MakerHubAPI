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
                name: "CategorieAge",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieAge", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CategorieInterclubs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genre = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieInterclubs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Classement",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Denomination = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classement", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TypeSouper",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeSouper", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Equipe",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    IDCategorieInterclubs = table.Column<int>(type: "int", nullable: false),
                    LieuMatch = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HeureMatch = table.Column<TimeSpan>(type: "time", nullable: false),
                    HeureDepart = table.Column<TimeSpan>(type: "time", nullable: true),
                    Division = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipe", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Equipe_CategorieInterclubs_IDCategorieInterclubs",
                        column: x => x.IDCategorieInterclubs,
                        principalTable: "CategorieInterclubs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Competition",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDCategorieAge = table.Column<int>(type: "int", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Heure = table.Column<TimeSpan>(type: "time", nullable: false),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    IDClassementMinimum = table.Column<int>(type: "int", nullable: false),
                    IDClassementMaximum = table.Column<int>(type: "int", nullable: false),
                    Lieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreMax = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competition", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Competition_CategorieAge_IDCategorieAge",
                        column: x => x.IDCategorieAge,
                        principalTable: "CategorieAge",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Competition_Classement_IDClassementMaximum",
                        column: x => x.IDClassementMaximum,
                        principalTable: "Classement",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Competition_Classement_IDClassementMinimum",
                        column: x => x.IDClassementMinimum,
                        principalTable: "Classement",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Stage",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HeureDebut = table.Column<TimeSpan>(type: "time", nullable: false),
                    HeureFin = table.Column<TimeSpan>(type: "time", nullable: false),
                    PrixAffilies = table.Column<double>(type: "float", nullable: false),
                    PrixExternes = table.Column<double>(type: "float", nullable: false),
                    IDClassementMinimum = table.Column<int>(type: "int", nullable: false),
                    IDClassementMaximum = table.Column<int>(type: "int", nullable: false),
                    Entraineur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NombreMax = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Stage_Classement_IDClassementMaximum",
                        column: x => x.IDClassementMaximum,
                        principalTable: "Classement",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Stage_Classement_IDClassementMinimum",
                        column: x => x.IDClassementMinimum,
                        principalTable: "Classement",
                        principalColumn: "ID");
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
                    NombreMax = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Souper", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Souper_TypeSouper_IDType",
                        column: x => x.IDType,
                        principalTable: "TypeSouper",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Joueur",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IDClassementHommes = table.Column<int>(type: "int", nullable: false),
                    IDClassementDames = table.Column<int>(type: "int", nullable: true),
                    IDCategorieAge = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    IDEquipeHommes = table.Column<int>(type: "int", nullable: true),
                    IDEquipeDames = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joueur", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Joueur_CategorieAge_IDCategorieAge",
                        column: x => x.IDCategorieAge,
                        principalTable: "CategorieAge",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Joueur_Classement_IDClassementDames",
                        column: x => x.IDClassementDames,
                        principalTable: "Classement",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Joueur_Classement_IDClassementHommes",
                        column: x => x.IDClassementHommes,
                        principalTable: "Classement",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Joueur_Equipe_IDEquipeDames",
                        column: x => x.IDEquipeDames,
                        principalTable: "Equipe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Joueur_Equipe_IDEquipeHommes",
                        column: x => x.IDEquipeHommes,
                        principalTable: "Equipe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_Competition_IDCategorieAge",
                table: "Competition",
                column: "IDCategorieAge");

            migrationBuilder.CreateIndex(
                name: "IX_Competition_IDClassementMaximum",
                table: "Competition",
                column: "IDClassementMaximum");

            migrationBuilder.CreateIndex(
                name: "IX_Competition_IDClassementMinimum",
                table: "Competition",
                column: "IDClassementMinimum");

            migrationBuilder.CreateIndex(
                name: "IX_Equipe_IDCategorieInterclubs",
                table: "Equipe",
                column: "IDCategorieInterclubs");

            migrationBuilder.CreateIndex(
                name: "IX_Joueur_IDCategorieAge",
                table: "Joueur",
                column: "IDCategorieAge");

            migrationBuilder.CreateIndex(
                name: "IX_Joueur_IDClassementDames",
                table: "Joueur",
                column: "IDClassementDames");

            migrationBuilder.CreateIndex(
                name: "IX_Joueur_IDClassementHommes",
                table: "Joueur",
                column: "IDClassementHommes");

            migrationBuilder.CreateIndex(
                name: "IX_Joueur_IDEquipeDames",
                table: "Joueur",
                column: "IDEquipeDames");

            migrationBuilder.CreateIndex(
                name: "IX_Joueur_IDEquipeHommes",
                table: "Joueur",
                column: "IDEquipeHommes");

            migrationBuilder.CreateIndex(
                name: "IX_JoueurCompetition_IDJoueur",
                table: "JoueurCompetition",
                column: "IDJoueur");

            migrationBuilder.CreateIndex(
                name: "IX_JoueurStage_IDJoueur",
                table: "JoueurStage",
                column: "IDJoueur");

            migrationBuilder.CreateIndex(
                name: "IX_Souper_IDType",
                table: "Souper",
                column: "IDType");

            migrationBuilder.CreateIndex(
                name: "IX_Stage_IDClassementMaximum",
                table: "Stage",
                column: "IDClassementMaximum");

            migrationBuilder.CreateIndex(
                name: "IX_Stage_IDClassementMinimum",
                table: "Stage",
                column: "IDClassementMinimum");
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

            migrationBuilder.DropTable(
                name: "TypeSouper");

            migrationBuilder.DropTable(
                name: "CategorieAge");

            migrationBuilder.DropTable(
                name: "Equipe");

            migrationBuilder.DropTable(
                name: "Classement");

            migrationBuilder.DropTable(
                name: "CategorieInterclubs");
        }
    }
}
