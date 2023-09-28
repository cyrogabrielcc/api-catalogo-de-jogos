using api_catalogo_de_jogos.Entities;
using api_catalogo_de_jogos.Exceptions;
using api_catalogo_de_jogos.InputModel;
using api_catalogo_de_jogos.Repository;
using api_catalogo_de_jogos.ViewModel;

namespace api_catalogo_de_jogos.Services
{
    class JogoService : IJogoService
    {


        // ----------------------- Declarando o repository
        private readonly IJogoRepository _jogoRepository;
        // ----------------------- Declarando o repository


        // ----------------------- Criando o construtor
        public JogoService(IJogoRepository jogoRepository)
        {
            _jogoRepository = jogoRepository;
        }
        // ----------------------- Criando o construtor



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
        // ----------------------- Obtendo todos




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
        // ----------------------- Obtendo um pelo id

        
        
        
        // ----------------------- INSERINDO UM JOGO
        async Task<JogoViewModel> IJogoService.Inserir(JogoInputModel jogo)
        {
            var jogoEntidade = await _jogoRepository.Obter(jogo.Nome, jogo.Produtora);

            if (jogoEntidade.Count > 0) throw new JogoJaCadastradoException();
            
            var jogoInsert = new Jogo
            {
                Id = Guid.NewGuid(),
                Nome = jogo.Nome,
                Produtora = jogo.Produtora,
                Preco = jogo.Preco
            };

            await _jogoRepository.Inserir(jogoInsert);

            return new JogoViewModel
            {
                Id = jogoInsert.Id,
                Nome = jogo.Nome,
                Produtora = jogo.Produtora,
                Preco = jogo.Preco
            };

        
        }
        // ----------------------- INSERINDO UM JOGO

        
        
        // ----------------------- ATUALIZANDO UM JOGO
        async Task IJogoService.Atualizar(Guid id, JogoInputModel jogo)
        {
            var entidadeJogo = await _jogoRepository.Obter(id);

            if (entidadeJogo is null) throw new JogoNaoCadastradoException(); 

            entidadeJogo.Nome = jogo.Nome;
            entidadeJogo.Produtora = jogo.Produtora;
            entidadeJogo.Preco = jogo.Preco;

            await _jogoRepository.Atualizar(entidadeJogo);

        }
        // ----------------------- ATUALIZANDO UM JOGO

        
        
        Task IJogoService.Atualizar(Guid id, double preco)
        {
            throw new NotImplementedException();
        }

        Task IJogoService.Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}