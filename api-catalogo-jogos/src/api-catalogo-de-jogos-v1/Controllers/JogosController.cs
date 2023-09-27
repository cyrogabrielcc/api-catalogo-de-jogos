using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api_catalogo_de_jogos.InputModel;

namespace api_catalogo_de_jogos.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class JogosController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<object>>> GetAllJogos()
        {
            return Ok();
        }

        /*---------------------------------------------------------------*/
        [HttpGet("{JogoId:guid}")]
        public async Task<ActionResult<object>> GetJogoByID(Guid idJogo)
        {
            return Ok();
        }
       
       
       
        /*---------------------------------------------------------------*/
        [HttpPost]
        public async Task<ActionResult<object>> CriarNovoJogo(JogoInputModel jogo)
        {
            return Ok();
        }

        
        
        
        /*---------------------------------------------------------------*/
        [HttpPut("{JogoId:guid")]
        public async Task<ActionResult<object>> AtualizarJogo(Guid id , JogoInputModel jogo)
        {
            return Ok();
        }
        
        
        /*---------------------------------------------------------------*/
        [HttpPatch("{JogoId:guid}/preco/{preco:double}")]
        public async Task<ActionResult<object>> ChangeItemJogo(Guid idJogo, double preco)
        {
            return Ok();
        }

        
        
        
       /*---------------------------------------------------------------*/
        
       /* [HttpDelete("{JogoId:guid}")]
        public async Task<AcceptedResult> DeleteJogo(Guid id)
        {
            return Ok();
        }
        */
    }
}