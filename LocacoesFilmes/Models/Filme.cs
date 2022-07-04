using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocacoesFilmes.Models
{
    [Table(name:"Filme")]
    public class Filme
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100), Required]
        public string? Titulo { get; set; }
        [Required]
        public int ClassificacaoIndicativa { get; set; }
        [Required]
        public int Lancamento { get; set; }

    }
}
