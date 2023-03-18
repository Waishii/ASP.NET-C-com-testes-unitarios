using Funcionarios.Controllers;
using Funcionarios.Domain;

namespace TesteFuncionarios
{
    public class FunarioControllerTest
    {
        [Fact]
        public void GetTest()
        {
            limparControler();
            var controller = criarFuncionarioController();
            var funcionario = criarFuncionario();
            addFuncionario(funcionario);
            var _funcionario = controller.GetFuncionarios().First();
            Assert.Equal(funcionario, _funcionario);
        }
        [Fact]
        public void PostTest()
        {
            limparControler();
            var controller = criarFuncionarioController();
            var funcionario = criarFuncionario();
            controller.PostFuncionarios(funcionario);
            var funcionarioInterno = getFuncionario();
            Assert.Equal(funcionario, funcionarioInterno);
            Assert.NotEqual(default(Guid),funcionario.id);
        }
        [Fact]
        public void PatchTest()
        {
            limparControler();
            var controller = criarFuncionarioController();
            var funcionario = criarFuncionario();
            var funcionarioEditado = criarFuncionario();
            addFuncionario(funcionario);
            var id = Guid.NewGuid();
            funcionario.id = id;
            funcionarioEditado.id = id;
            funcionarioEditado.Nome = "Carla";
            controller.PatchFuncionarios(funcionarioEditado);
            Assert.Equal(funcionario.Nome, funcionarioEditado.Nome);
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
        private void addFuncionario(Funcionario funcionario)
        {
            FuncionarioController.Funcionarios.Add(funcionario);

        }
        private Funcionario getFuncionario()
        {
            return FuncionarioController.Funcionarios.First();

        }

    }
}