using Microsoft.AspNetCore.Mvc;
using api_catalogo_de_jogos.InputModel;
using api_catalogo_de_jogos.Services;
using System.ComponentModel.DataAnnotations;
using api_catalogo_de_jogos.ViewModel;

namespace api_catalogo_de_jogos.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class JogosController : ControllerBase
    {

        private readonly IJogoService _jogoService;

        public JogosController(IJogoService jogoService)
        {
            _jogoService = jogoService;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<object>>> Obter([FromQuery, Range(1,int.MaxValue)] int pagina = 1, [FromQuery, Range(1,50)] int  quantidade = 5)
        {
            var jogos = await _jogoService.Obter(1,5);
            if (jogos.Count() < 1)
            {
                return NoContent();
            }
            return Ok(jogos);
        }

        /*---------------------------------------------------------------*/
        [HttpGet("{JogoId:guid}")]
        public async Task<ActionResult<object>> Obter([FromRoute]Guid idJogo)
        {
            var result = await _jogoService.Obter(idJogo);
            if (result == null)
            {
                return NoContent();
            }
            return Ok(result);
        }
       
       
       
        /*---------------------------------------------------------------*/
        [HttpPost]
        public async Task<ActionResult<object>> InserirJogo ([FromBody] JogoInputModel jogo)
        {
            try
            {
                var result = await _jogoService.Inserir(jogo);
                return Ok(result);
            }
            catch (System.Exception)
            {
               return UnprocessableEntity("Falhou aí heim, talvez esteja repetido..." );
            }
        }

        
        
        
        /*---------------------------------------------------------------*/
        [HttpPut("{JogoId:guid")]
        public async Task<ActionResult<JogoViewModel>> AtualizarJogo([FromRoute] Guid id , [FromBody] JogoInputModel jogo)
        {
             try
            {
                 await _jogoService.Atualizar(id, jogo);

                 return Ok();
            }
            catch (System.Exception)
            {
               return NotFound("O Jogo não pôde ser alterado" );
            }
        }
        
        
        /*---------------------------------------------------------------*/
        [HttpPatch("{JogoId:guid}/preco/{preco:double}")]
        public async Task<ActionResult<JogoViewModel>> AtualizarJogo([FromRoute] Guid id , [FromBody] double preco)
        {
             try
            {
                 await _jogoService.Atualizar(id, preco);
                 return Ok();
            }
            catch (System.Exception)
            {
               return UnprocessableEntity("Falhou aí heim, talvez esteja repetido..." );
            }
        }

        
        
        
       /*---------------------------------------------------------------*/
        
        [HttpDelete("{JogoId:guid}")]
        public async Task<ActionResult> ApagarJogo( [FromRoute] Guid id)
        {
           try
           {
             await _jogoService.Remover(id);
             return Ok();
           }
           catch(Exception)
           {
               return UnprocessableEntity("Jogo não existe" );

           }
        }
       
    }
}