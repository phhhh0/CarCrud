using Microsoft.EntityFrameworkCore;
using CarCRUD.Models; // Alterado para CarCRUD.Models, pois você está trabalhando com carros

namespace CarCRUD.Data // Corrigido para CarCRUD.Data
{
    // Contexto de banco de dados para Carro
    public class ContextoCarro : DbContext
    {
        // Tabela de carros
        public DbSet<CarroModelo> Carros { get; set; }

        // Configuração da conexão com o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder construtorOpcoes)
        {
            construtorOpcoes.UseSqlite("Data Source=Carro.sqlite"); // Usando o SQLite como banco de dados
            base.OnConfiguring(construtorOpcoes);
        }
    }
}