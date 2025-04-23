namespace CarCRUD.Models
{
    public class CarroModelo
    {
        public Guid Id { get; set; }
        public string Modelo { get; set; }
        public bool Ativo { get; set; } // Propriedade que indica se o carro está ativo ou inativo

        public CarroModelo(string modelo)
        {
            Id = Guid.NewGuid();
            Modelo = modelo;
            Ativo = true; // Por padrão, o carro é ativo
        }

        // Método para definir o carro como inativo
        public void DefinirComoInativo()
        {
            Ativo = false; // Marca o carro como inativo
        }

        // Outros métodos que o seu modelo possa ter
        public void AlterarModelo(string novoModelo)
        {
            Modelo = novoModelo;
        }
    }
}