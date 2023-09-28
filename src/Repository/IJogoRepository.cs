using api_catalogo_de_jogos.Entities;
using api_catalogo_de_jogos.InputModel;
using api_catalogo_de_jogos.ViewModel;

namespace api_catalogo_de_jogos.Repository
{
    public interface IJogoRepository
    {
        Task<List<Jogo>> Obter(int pagina, int quantidade);
        Task<Jogo> Obter(Guid id);
        Task<List<Jogo>> Obter(string nome, string produtora);
        Task Inserir(Jogo jogo);
        Task Atualizar(Jogo jogo);
        Task Remover(Guid id);
    }
}