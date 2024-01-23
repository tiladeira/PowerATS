using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PowerATS.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class ConfigInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidato",
                columns: table => new
                {
                    IdCandidato = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeCompleto = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidato", x => x.IdCandidato);
                });

            migrationBuilder.CreateTable(
                name: "Vaga",
                columns: table => new
                {
                    IdVaga = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TipoContratacao = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaga", x => x.IdVaga);
                });

            migrationBuilder.CreateTable(
                name: "Curriculo",
                columns: table => new
                {
                    IdCurriculo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCandidato = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Curriculo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curriculo", x => x.IdCurriculo);
                    table.ForeignKey(
                        name: "FK_Curriculo_Candidato",
                        column: x => x.IdCandidato,
                        principalTable: "Candidato",
                        principalColumn: "IdCandidato");
                });

            migrationBuilder.CreateTable(
                name: "CandidatoVaga",
                columns: table => new
                {
                    IdCandidatoVaga = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCandidato = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdVaga = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatoVaga", x => x.IdCandidatoVaga);
                    table.ForeignKey(
                        name: "FK_CandidatoVaga_Candidato",
                        column: x => x.IdCandidato,
                        principalTable: "Candidato",
                        principalColumn: "IdCandidato");
                    table.ForeignKey(
                        name: "FK_CandidatoVaga_Vaga",
                        column: x => x.IdVaga,
                        principalTable: "Vaga",
                        principalColumn: "IdVaga");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidatoVaga_IdCandidato",
                table: "CandidatoVaga",
                column: "IdCandidato");

            migrationBuilder.CreateIndex(
                name: "IX_CandidatoVaga_IdVaga",
                table: "CandidatoVaga",
                column: "IdVaga");

            migrationBuilder.CreateIndex(
                name: "IX_Curriculo_IdCandidato",
                table: "Curriculo",
                column: "IdCandidato");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidatoVaga");

            migrationBuilder.DropTable(
                name: "Curriculo");

            migrationBuilder.DropTable(
                name: "Vaga");

            migrationBuilder.DropTable(
                name: "Candidato");
        }
    }
}
