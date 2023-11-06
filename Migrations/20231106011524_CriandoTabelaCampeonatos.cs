using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KRB_tec_jr.Migrations
{
    /// <inheritdoc />
    public partial class CriandoTabelaCampeonatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campeonatos",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Campeonato = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataRealizacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sobre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ginasio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformacoesGerais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntradaAoPublico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destaque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campeonatos", x => x.Codigo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campeonatos");
        }
    }
}
