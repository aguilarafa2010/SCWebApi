using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCData.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalasCinemas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalasCinemas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sinopse = table.Column<string>(nullable: true),
                    Genero = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    ClienteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filmes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HDisponiveis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Horario = table.Column<DateTime>(nullable: false),
                    SalaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HDisponiveis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HDisponiveis_SalasCinemas_SalaId",
                        column: x => x.SalaId,
                        principalTable: "SalasCinemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalasFilmes",
                columns: table => new
                {
                    SalaId = table.Column<int>(nullable: false),
                    FilmeId = table.Column<int>(nullable: false),
                    FilmesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalasFilmes", x => new { x.SalaId, x.FilmeId });
                    table.ForeignKey(
                        name: "FK_SalasFilmes_Filmes_FilmesId",
                        column: x => x.FilmesId,
                        principalTable: "Filmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalasFilmes_SalasCinemas_SalaId",
                        column: x => x.SalaId,
                        principalTable: "SalasCinemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmes_ClienteId",
                table: "Filmes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_HDisponiveis_SalaId",
                table: "HDisponiveis",
                column: "SalaId");

            migrationBuilder.CreateIndex(
                name: "IX_SalasFilmes_FilmesId",
                table: "SalasFilmes",
                column: "FilmesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HDisponiveis");

            migrationBuilder.DropTable(
                name: "SalasFilmes");

            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "SalasCinemas");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
