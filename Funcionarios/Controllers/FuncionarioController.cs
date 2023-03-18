using Funcionarios.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Funcionarios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        public static List<Funcionario> Funcionarios = new();
        [HttpGet]
        public IEnumerable<Funcionario> GetFuncionarios()
        {
            return from Funcionario in Funcionarios orderby Funcionario.Nome ascending select Funcionario;
        }
        [HttpPost]
        public void PostFuncionarios(Funcionario funcionario)
        {
            funcionario.id=Guid.NewGuid();
            Funcionarios.Add(funcionario);
        }
        [HttpPatch]
        public void PatchFuncionarios(Funcionario funcionario)
        {
            var _funcionario= Funcionarios.First(x=>x.id==funcionario.id);
            _funcionario.Nome = funcionario.Nome;
            _funcionario.Idade = funcionario.Idade;
            _funcionario.Cargo = funcionario.Cargo;

        }
        [HttpDelete]
        public void DeleteFuncionarios(Funcionario funcionario)
        {
            var _funcionario = Funcionarios.First(x => x.id == funcionario.id);
            Funcionarios.Remove(_funcionario);

        }
    }
}