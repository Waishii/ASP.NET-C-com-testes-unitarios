using Funcionarios.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Funcionarios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        private static List<Funcionario> Funcionarios = new();
        [HttpGet]
        public IEnumerable<Funcionario> GetFuncionarios()
        {
            return from Funcionario in Funcionarios orderby Funcionario.Nome ascending select Funcionario;
        }
        [HttpPost]
        public void PostFuncionarios(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
        }
    }
}