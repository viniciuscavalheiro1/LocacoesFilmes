using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocacoesFilmes.Models
{
    [Table(name: "Filme")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200), Required]
        public string? Nome { get; set; }
        [Required]
        public int CPF { get; set; }
        [MaxLength(8)]
        public int DataNascimento { get; set; }
    }
}
