using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_catalogo_de_jogos.InputModel;
using api_catalogo_de_jogos.ViewModel;

namespace api_catalogo_de_jogos.Services
{
    public class JogoService : IJogoService
    {
        Task IJogoService.AtualizarItemJogo(Guid id, double preco)
        {
            throw new NotImplementedException();
        }

        Task IJogoService.AtualizarJogo(Guid id, JogoInputModel jogo)
        {
            throw new NotImplementedException();
        }

        Task<JogoViewModel> IJogoService.CriarNovoJogo(JogoInputModel jogo)
        {
            throw new NotImplementedException();
        }

        Task IJogoService.DeleteJogo(Guid id)
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        Task<List<JogoViewModel>> IJogoService.GetAllJogos(int pagina, int quantidade)
        {
            throw new NotImplementedException();
        }

        Task<JogoViewModel> IJogoService.GetJogoByID(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}