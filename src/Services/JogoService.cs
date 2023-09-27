using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_catalogo_de_jogos.Entities;
using api_catalogo_de_jogos.InputModel;
using api_catalogo_de_jogos.Repository;
using api_catalogo_de_jogos.ViewModel;

namespace api_catalogo_de_jogos.Services
{
    public class JogoService : IJogoService
    {
        // Declarando o repository
        private readonly IJogoRepository _jogoRepository;

        Task IJogoService.Atualizar(Guid id, JogoInputModel jogo)
        {
            throw new NotImplementedException();
        }

        Task IJogoService.Atualizar(Guid id, double preco)
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        Task<JogoViewModel> IJogoService.Inserir(JogoInputModel jogo)
        {
            throw new NotImplementedException();
        }

        Task<List<JogoViewModel>> IJogoService.Obter(int pagina, int quantidade)
        {
            throw new NotImplementedException();
        }

        Task<JogoViewModel> IJogoService.Obter(Guid id)
        {
            throw new NotImplementedException();
        }

        Task IJogoService.Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}