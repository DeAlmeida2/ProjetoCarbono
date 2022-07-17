using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoCarbono.Migrations
{
    public partial class CriandoTabAspectos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aspectos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Transporte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsumoVeiculo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Passageiros = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emissão = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aspectos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aspectos");
        }
    }
}
