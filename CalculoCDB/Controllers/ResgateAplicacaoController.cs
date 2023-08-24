using CalculoCDB.Aplicaca.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculoCDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResgateAplicacaoController : ControllerBase
    {
        private readonly IResgateAplicacaoServico resgateAplicacaoServico;

        public ResgateAplicacaoController(IResgateAplicacaoServico resgateAplicacaoServico)
        {
            this.resgateAplicacaoServico = resgateAplicacaoServico;
        }

        [HttpGet("RetornaBrutoLiquido/{valor}/{quantidadeMeses}")]
        public IActionResult RetornaPessoas(double valor, int quantidadeMeses)
        {
            var resgateAplicacao = resgateAplicacaoServico.RetornaEstimativaCalculoCDB(valor, quantidadeMeses);
            return Ok(resgateAplicacao);
        }
    }
}
