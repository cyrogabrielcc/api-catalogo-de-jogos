using api_catalogo_de_jogos.InputModel;
using api_catalogo_de_jogos.ViewModel;

namespace api_catalogo_de_jogos.Services
{
    public interface IJogoService
    {
        public Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        public Task<JogoViewModel> Obter(Guid id);
        public Task<JogoViewModel> Inserir(JogoInputModel jogo);
        public Task Atualizar(Guid id, JogoInputModel jogo);
        public Task Atualizar(Guid id, double preco);
        public Task Remover(Guid id);
    }
}