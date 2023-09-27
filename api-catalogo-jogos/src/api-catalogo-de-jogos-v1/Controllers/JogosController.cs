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
        public async Task<ActionResult<List<object>>> GetAllJogos([FromQuery, Range(1,int.MaxValue)] int pagina = 1, [FromQuery, Range(1,50)] int  quantidade = 5)
        {
            var jogos = await _jogoService.GetAllJogos(1,5);
            if (jogos.Count() < 1)
            {
                return NoContent();
            }
            return Ok(jogos);
        }

        /*---------------------------------------------------------------*/
        [HttpGet("{JogoId:guid}")]
        public async Task<ActionResult<object>> GetJogoByID([FromRoute]Guid idJogo)
        {
            var result = await _jogoService.GetJogoByID(idJogo);
            if (result == null)
            {
                return NoContent();
            }
            return Ok(result);
        }
       
       
       
        /*---------------------------------------------------------------*/
        [HttpPost]
        public async Task<ActionResult<object>> CriarNovoJogo([FromBody] JogoInputModel jogo)
        {
            try
            {
                var result = await _jogoService.CriarNovoJogo(jogo);
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
                return await _jogoService.AtualizarJogo(id, jogo);
            }
            catch (System.Exception)
            {
               return UnprocessableEntity("Falhou aí heim, talvez esteja repetido..." );
            }
        }
        
        
        /*---------------------------------------------------------------*/
        [HttpPatch("{JogoId:guid}/preco/{preco:double}")]
        public async Task<ActionResult<JogoViewModel>> AtualizarItemJogo([FromRoute] Guid id , [FromBody] double preco)
        {
             try
            {
                return await _jogoService.AtualizarItemJogo(id, preco);
            }
            catch (System.Exception)
            {
               return UnprocessableEntity("Falhou aí heim, talvez esteja repetido..." );
            }
        }

        
        
        
       /*---------------------------------------------------------------*/
        
        [HttpDelete("{JogoId:guid}")]
        public async Task<ActionResult> DeleteJogo( [FromRoute] Guid id)
        {
           try
           {
             await _jogoService.DeleteJogo(id);
             return Ok();
           }
           catch(Exception)
           {
               return UnprocessableEntity("Jogo não existe" );

           }
        }
       
    }
}