using System.ComponentModel.DataAnnotations;

namespace api_catalogo_de_jogos.InputModel
{
    public class JogoInputModel
    {
        /*_______________________#####_______________________*/
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Deve ter entre 2 e 100")]
        public string Nome {get; set;}
        
       
       /*_______________________#####_______________________*/
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Deve ter entre 2 e 100")]
        public string Produtora {get; set;}
      
        /*_______________________#####_______________________*/
        [Required]
        [Range(1,1000, ErrorMessage = "mínimo de 50 e máximo de 1000")]
        public double Preco {get; set;}
    }
}