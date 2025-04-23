using Microsoft.EntityFrameworkCore.Migrations;
using CarCRUD.Data;
using Microsoft.EntityFrameworkCore.Infrastructure; // Corrigido para CarCRUD.Data

#nullable disable

namespace CarCRUD.Migrations // Corrigido para CarCRUD.Migrations
{
    [DbContext(typeof(ContextoCarro))] // Corrigido para ContextoCarro
    [Migration("20250422150916_Inicial")]
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Criação da tabela Carros
            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remoção da tabela Carros caso precise fazer rollback
            migrationBuilder.DropTable(name: "Carros");
        }
    }
}