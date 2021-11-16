using System.ComponentModel.DataAnnotations;

namespace LocadoraVeiculos.Domain
{
    public class Veiculo
    {
        public int Id {get; set; }
        public int EstabelecimentoId {get; set; }
        public Estabelecimento Estabelecimento {get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Marca {get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Modelo {get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Cor {get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Tipo {get; set; }
        
    }
}