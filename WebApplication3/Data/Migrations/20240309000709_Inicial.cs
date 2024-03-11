using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "devis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    iDmainsOeuvres = table.Column<int>(type: "int", nullable: false),
                    iDroue = table.Column<int>(type: "int", nullable: false),
                    iDgentes = table.Column<int>(type: "int", nullable: false),
                    iDPneus = table.Column<int>(type: "int", nullable: false),
                    iDVoiture = table.Column<int>(type: "int", nullable: false),
                    iDFreins = table.Column<int>(type: "int", nullable: false),
                    iDbatteries = table.Column<int>(type: "int", nullable: false),
                    iDmoteurs = table.Column<int>(type: "int", nullable: false),
                    iDsuspensions = table.Column<int>(type: "int", nullable: false),
                    iDturboCompresseur = table.Column<int>(type: "int", nullable: false),
                    iDReparation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_devis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nombres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nombres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pneu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pneu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "batteries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prix = table.Column<double>(type: "float", nullable: false),
                    nombre = table.Column<int>(type: "int", nullable: false),
                    marque = table.Column<int>(type: "int", nullable: false),
                    devisId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_batteries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_batteries_devis_devisId",
                        column: x => x.devisId,
                        principalTable: "devis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "freins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prix = table.Column<double>(type: "float", nullable: false),
                    nombre = table.Column<int>(type: "int", nullable: false),
                    marque = table.Column<int>(type: "int", nullable: false),
                    devisId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_freins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_freins_devis_devisId",
                        column: x => x.devisId,
                        principalTable: "devis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "moteurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prix = table.Column<double>(type: "float", nullable: false),
                    nombre = table.Column<int>(type: "int", nullable: false),
                    marque = table.Column<int>(type: "int", nullable: false),
                    devisId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_moteurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_moteurs_devis_devisId",
                        column: x => x.devisId,
                        principalTable: "devis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "reparations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    statut = table.Column<bool>(type: "bit", nullable: false),
                    prix = table.Column<double>(type: "float", nullable: false),
                    nombre = table.Column<int>(type: "int", nullable: false),
                    categorie = table.Column<int>(type: "int", nullable: false),
                    devisId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reparations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reparations_devis_devisId",
                        column: x => x.devisId,
                        principalTable: "devis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "suspensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prix = table.Column<double>(type: "float", nullable: false),
                    nombre = table.Column<int>(type: "int", nullable: false),
                    marque = table.Column<int>(type: "int", nullable: false),
                    devisId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suspensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_suspensions_devis_devisId",
                        column: x => x.devisId,
                        principalTable: "devis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "turboCompresseur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prix = table.Column<double>(type: "float", nullable: false),
                    nombre = table.Column<int>(type: "int", nullable: false),
                    marque = table.Column<int>(type: "int", nullable: false),
                    devisId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_turboCompresseur", x => x.Id);
                    table.ForeignKey(
                        name: "FK_turboCompresseur_devis_devisId",
                        column: x => x.devisId,
                        principalTable: "devis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "voitures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prix = table.Column<double>(type: "float", nullable: false),
                    nombre = table.Column<int>(type: "int", nullable: false),
                    categorie = table.Column<int>(type: "int", nullable: false),
                    devisId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voitures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_voitures_devis_devisId",
                        column: x => x.devisId,
                        principalTable: "devis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "gentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prix = table.Column<double>(type: "float", nullable: false),
                    nombre = table.Column<int>(type: "int", nullable: false),
                    PneuId = table.Column<int>(type: "int", nullable: true),
                    devisId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gentes_devis_devisId",
                        column: x => x.devisId,
                        principalTable: "devis",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_gentes_Pneu_PneuId",
                        column: x => x.PneuId,
                        principalTable: "Pneu",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "mainsOeuvres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prix = table.Column<double>(type: "float", nullable: false),
                    nombre = table.Column<int>(type: "int", nullable: false),
                    PneuId = table.Column<int>(type: "int", nullable: true),
                    devisId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mainsOeuvres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mainsOeuvres_devis_devisId",
                        column: x => x.devisId,
                        principalTable: "devis",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_mainsOeuvres_Pneu_PneuId",
                        column: x => x.PneuId,
                        principalTable: "Pneu",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "pneus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prix = table.Column<double>(type: "float", nullable: false),
                    nombre = table.Column<int>(type: "int", nullable: false),
                    PneuId = table.Column<int>(type: "int", nullable: true),
                    devisId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pneus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pneus_devis_devisId",
                        column: x => x.devisId,
                        principalTable: "devis",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_pneus_Pneu_PneuId",
                        column: x => x.PneuId,
                        principalTable: "Pneu",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "roue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prix = table.Column<double>(type: "float", nullable: false),
                    nombre = table.Column<int>(type: "int", nullable: false),
                    PneuId = table.Column<int>(type: "int", nullable: true),
                    devisId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_roue_devis_devisId",
                        column: x => x.devisId,
                        principalTable: "devis",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_roue_Pneu_PneuId",
                        column: x => x.PneuId,
                        principalTable: "Pneu",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_batteries_devisId",
                table: "batteries",
                column: "devisId");

            migrationBuilder.CreateIndex(
                name: "IX_freins_devisId",
                table: "freins",
                column: "devisId");

            migrationBuilder.CreateIndex(
                name: "IX_gentes_devisId",
                table: "gentes",
                column: "devisId");

            migrationBuilder.CreateIndex(
                name: "IX_gentes_PneuId",
                table: "gentes",
                column: "PneuId");

            migrationBuilder.CreateIndex(
                name: "IX_mainsOeuvres_devisId",
                table: "mainsOeuvres",
                column: "devisId");

            migrationBuilder.CreateIndex(
                name: "IX_mainsOeuvres_PneuId",
                table: "mainsOeuvres",
                column: "PneuId");

            migrationBuilder.CreateIndex(
                name: "IX_moteurs_devisId",
                table: "moteurs",
                column: "devisId");

            migrationBuilder.CreateIndex(
                name: "IX_pneus_devisId",
                table: "pneus",
                column: "devisId");

            migrationBuilder.CreateIndex(
                name: "IX_pneus_PneuId",
                table: "pneus",
                column: "PneuId");

            migrationBuilder.CreateIndex(
                name: "IX_reparations_devisId",
                table: "reparations",
                column: "devisId");

            migrationBuilder.CreateIndex(
                name: "IX_roue_devisId",
                table: "roue",
                column: "devisId");

            migrationBuilder.CreateIndex(
                name: "IX_roue_PneuId",
                table: "roue",
                column: "PneuId");

            migrationBuilder.CreateIndex(
                name: "IX_suspensions_devisId",
                table: "suspensions",
                column: "devisId");

            migrationBuilder.CreateIndex(
                name: "IX_turboCompresseur_devisId",
                table: "turboCompresseur",
                column: "devisId");

            migrationBuilder.CreateIndex(
                name: "IX_voitures_devisId",
                table: "voitures",
                column: "devisId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "batteries");

            migrationBuilder.DropTable(
                name: "freins");

            migrationBuilder.DropTable(
                name: "gentes");

            migrationBuilder.DropTable(
                name: "mainsOeuvres");

            migrationBuilder.DropTable(
                name: "moteurs");

            migrationBuilder.DropTable(
                name: "Nombres");

            migrationBuilder.DropTable(
                name: "pneus");

            migrationBuilder.DropTable(
                name: "reparations");

            migrationBuilder.DropTable(
                name: "roue");

            migrationBuilder.DropTable(
                name: "suspensions");

            migrationBuilder.DropTable(
                name: "turboCompresseur");

            migrationBuilder.DropTable(
                name: "voitures");

            migrationBuilder.DropTable(
                name: "Pneu");

            migrationBuilder.DropTable(
                name: "devis");
        }
    }
}
