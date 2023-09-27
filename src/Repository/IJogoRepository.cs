using api_catalogo_de_jogos.Entities;

namespace api_catalogo_de_jogos.Repository
{
    public interface IJogoRepository
    {
        Task<List<Jogo>> GetAllJogos (int pagina, int quantidade);
        Task<Jogo> GetJogoByID(Guid id);
        Task<Jogo> CriarNovoJogo(Jogo jogo);
        Task AtualizarJogo(Guid id, Jogo jogo);
        Task AtualizarItemJogo(Guid id , double preco);
        Task DeleteJogo(Guid id);
    }
}