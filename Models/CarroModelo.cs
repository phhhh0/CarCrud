namespace CarCRUD.Models
{
    public class CarroModelo
    {
        public Guid Id { get; set; }
        public string Modelo { get; set; }
        public bool Ativo { get; set; } 

        public CarroModelo(string modelo)
        {
            Id = Guid.NewGuid();
            Modelo = modelo;
            Ativo = true; 
        }

        
        public void DefinirComoInativo()
        {
            Ativo = false; 
        }

      
        public void AlterarModelo(string novoModelo)
        {
            Modelo = novoModelo;
        }
    }
}
