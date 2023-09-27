using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_catalogo_de_jogos.Exceptions
{
    public class JogoNaoCadastradoException : Exception 
    {
        public JogoNaoCadastradoException() : base("O jogo não existe!")
        {
            
        }
    }
}