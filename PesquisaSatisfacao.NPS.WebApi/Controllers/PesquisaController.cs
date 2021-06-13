using Microsoft.AspNetCore.Mvc;
using PesquisaSatisfacao.NPS.Domain.Interfaces.Application;
using PesquisaSatisfacao.NPS.WebApi.Controllers.Shared;
using System.Threading.Tasks;

namespace PesquisaSatisfacao.NPS.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PesquisaController : ApiController
    {
        private readonly IPesquisaApp _pesquisaApp;

        public PesquisaController(IPesquisaApp pesquisaApp)
        {
            _pesquisaApp = pesquisaApp;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var pesquisa = await _pesquisaApp.Obter(id);
            return Ok(pesquisa);
        }

        [HttpPost]
        public IActionResult Update([FromBody] object pesquisa)
        {
            return Ok();
        }
    }
}
