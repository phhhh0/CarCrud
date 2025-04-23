using Microsoft.EntityFrameworkCore;
using CarCRUD.Models;

namespace CarCRUD.Data 
{
    
    public class ContextoCarro : DbContext
    {
       
        public DbSet<CarroModelo> Carros { get; set; }

       
        protected override void OnConfiguring(DbContextOptionsBuilder construtorOpcoes)
        {
            construtorOpcoes.UseSqlite("Data Source=Carro.sqlite"); 
            base.OnConfiguring(construtorOpcoes);
        }
    }
}
