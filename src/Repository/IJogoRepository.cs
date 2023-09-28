using api_catalogo_de_jogos.Entities;
using api_catalogo_de_jogos.InputModel;
using api_catalogo_de_jogos.ViewModel;

namespace api_catalogo_de_jogos.Repository
{
    public interface IJogoRepository
    {
        public Task<List<Jogo>> Obter(int pagina, int quantidade);
        public Task<Jogo> Obter(Guid id);
        public Task<Jogo> Inserir(JogoInputModel jogo);
        public Task Atualizar(Guid id, JogoInputModel jogo);
        public Task Atualizar(Guid id, double preco);
        public Task Remover(Guid id);
    }
}