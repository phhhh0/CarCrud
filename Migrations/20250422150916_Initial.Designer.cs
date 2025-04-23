using Microsoft.EntityFrameworkCore.Migrations;
using CarCRUD.Data;
using Microsoft.EntityFrameworkCore.Infrastructure; 

#nullable disable

namespace CarCRUD.Migrations 
{
    [DbContext(typeof(ContextoCarro))] 
    [Migration("20250422150916_Inicial")]
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
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
           
            migrationBuilder.DropTable(name: "Carros");
        }
    }
}
