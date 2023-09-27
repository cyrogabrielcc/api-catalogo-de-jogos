
namespace api_catalogo_de_jogos.Exceptions
{
    public class JogoJaCadastradoException : Exception
    {
        public JogoJaCadastradoException() : base("Jogo já cadastrado"){}   
    }
}