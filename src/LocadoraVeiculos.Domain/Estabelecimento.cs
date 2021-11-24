using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LocadoraVeiculos.Domain
{
    public class Estabelecimento
    {
        public int Id {get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Nome {get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string CNPJ {get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Endereco {get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Telefone {get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "Valor precisa ser maior que 0.")]
        public int QtdVagasMotos {get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "Valor precisa ser maior que 0.")]
        public int QtdVagasCarros {get; set; }
        public IEnumerable<Veiculo> Veiculos { get; set; }

    }
}
