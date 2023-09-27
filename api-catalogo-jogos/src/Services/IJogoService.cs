using api_catalogo_de_jogos.InputModel;
using api_catalogo_de_jogos.ViewModel;

namespace api_catalogo_de_jogos.Services
{
    public interface IJogoService : IDisposable
    {
        Task<List<JogoViewModel>> GetAllJogos (int pagina, int quantidade);
        Task<JogoViewModel> GetJogoByID(Guid id);
        Task<JogoViewModel> CriarNovoJogo(JogoInputModel jogo);
        Task AtualizarJogo(Guid id, JogoInputModel jogo);
        Task AtualizarItemJogo(Guid id , double preco);
        Task DeleteJogo(Guid id);
    }
}