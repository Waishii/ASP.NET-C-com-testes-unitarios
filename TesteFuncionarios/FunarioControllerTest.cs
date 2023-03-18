using Funcionarios.Controllers;
using Funcionarios.Domain;

namespace TesteFuncionarios
{
    public class FunarioControllerTest
    {
        [Fact]
        public void PostTest()
        {
            limparControler();
            var controller = criarFuncionarioController();
            var funcionario = criarFuncionario();
            FuncionarioController.Funcionarios.Add(funcionario);
            var _funcionario = controller.GetFuncionarios().First();
            Assert.Equal(funcionario, _funcionario);
        }
        private Funcionario criarFuncionario()
        {
            return new Funcionario
            {
                Nome = "José",
                Idade = 21,
                Cargo = "Desenvolvedor"
            };
        }
        private FuncionarioController criarFuncionarioController()
        {
            return new FuncionarioController
            {

            };
        }
        private void limparControler()
        {
            FuncionarioController.Funcionarios = new();
        }
    }
}