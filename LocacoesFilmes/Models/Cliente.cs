using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocacoesFilmes.Models
{
    [Table(name: "Cliente")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200), Required]
        public string? Nome { get; set; }
        [Required]
        public int CPF { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataNascimento { get; set; }
    }
}
