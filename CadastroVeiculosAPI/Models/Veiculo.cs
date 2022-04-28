using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroVeiculosAPI.Models
{
    public class Veiculo
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string veiculoNome { get; set; }
        [Required]
        public string marca { get; set; }
        [Range(1900,2100)]
        public int ano { get; set; }
        [Required]
        public string descricao { get; set; }
        public bool vendido { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
    }
}
