
using Funcionarios.Domain;

var funcionario = new Funcionario();

funcionario.Nome = "Jose";
funcionario.Idade = 17;
funcionario.Cargo = "Desenvolvedor";

funcionario.Imprime();

Console.WriteLine(
    $"O Funcionario {funcionario.Nome} " +
    $"{(funcionario.EMaiorDeIdade()?"é":"não é")} Maior de idade"
);