using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api_catalogo_de_jogos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JogosController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<object>>> GetAllJogos()
        {
            return Ok();
        }

         [HttpGet("{JogoId:guid}")]
        public async Task<ActionResult<object>> GetJogoByID(Guid idJogo)
        {
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult<object>> CreateNewJogo()
        {
            return Ok();
        }

        [HttpPut("{JogoId:guid")]
        public async Task<ActionResult<object>> ChangeJogo(Guid idJogo)
        {
            return Ok();
        }

        [HttpPatch("{JogoId:guid}/preco/{preco:double}")]
        public async Task<ActionResult<object>> ChangeItemJogo(Guid idJogo, double jogo)
        {
            return Ok();
        }

        /*
        [HttpDelete("{JogoId:guid}")]
        public async Task<AcceptedResult> DeleteJogo(Guid id)
        {
            return 
        }
        */
    }
}