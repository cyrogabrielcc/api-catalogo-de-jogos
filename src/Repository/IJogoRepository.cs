using api_catalogo_de_jogos.Entities;
using api_catalogo_de_jogos.InputModel;
using api_catalogo_de_jogos.ViewModel;

namespace api_catalogo_de_jogos.Repository
{
    public interface IJogoRepository
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id, JogoInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
    }
}