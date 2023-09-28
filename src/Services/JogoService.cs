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
    class JogoService : IJogoService
    {


        // ----------------------- Declarando o repository
        private readonly IJogoRepository _jogoRepository;



        // ----------------------- Criando o construtor
        JogoService(IJogoRepository jogoRepository)
        {
            _jogoRepository = jogoRepository;
        }



        // ----------------------- Obtendo todos
         async Task<List<JogoViewModel>> IJogoService.Obter(int pagina, int quantidade)
        {
            var jogos = await _jogoRepository.Obter(pagina, quantidade);
            var results = jogos.Select(jogo => new JogoViewModel {
                Id = jogo.Id, 
                Nome = jogo.Nome,
                Produtora = jogo.Produtora,
                Preco = jogo.Preco
            }).ToList();

            return results;
        }




        // ----------------------- Obtendo um pelo id
        async Task<JogoViewModel> IJogoService.Obter(Guid id)
        {
            var jogo = await _jogoRepository.Obter(id);
            if (jogo is null)  return null;
            
            var result = new JogoViewModel
            {
              Id = jogo.Id,
              Nome = jogo.Nome,
              Produtora = jogo.Produtora,
              Preco = jogo.Preco  
            };
            return result;
            
        }

        Task IJogoService.Atualizar(Guid id, JogoInputModel jogo)
        {
            throw new NotImplementedException();
        }

        Task IJogoService.Atualizar(Guid id, double preco)
        {
            throw new NotImplementedException();
        }

        Task<JogoViewModel> IJogoService.Inserir(JogoInputModel jogo)
        {
            throw new NotImplementedException();
        }

        Task IJogoService.Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}