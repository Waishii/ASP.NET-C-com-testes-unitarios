namespace Funcionarios.Domain
{
    public class Funcionario
    {
        public Guid id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cargo { get; set; }

        public void Imprime ()
        {
            Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}\nCargo: {Cargo}");
        }

        public bool EMaiorDeIdade()
        { 
            return Idade >= 18; 
        }
    }
}
