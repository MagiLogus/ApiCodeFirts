using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCodeFirst.Domains
{
    [Table("Jogo")]
    public class Jogo
    {
        [Key]
        public Guid IdJogo { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome Obrigatorio!")]
        public string? Nome { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Obrigatorio!")]
        public string? Descricao { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Obrigario")]
        public DateTime? DataLancamento { get; set; }

        [Column(TypeName = "Decimal(4,2)")]
        [Required(ErrorMessage = "Obrigario")]
        public decimal? Preco { get; set; }

        //referencia da chave estrangeira (Tabela de Estudio)
        [Required(ErrorMessage = "Obrigario informar o estudio!")]
        public Guid IdEstudio { get; set; }
        [ForeignKey("IdEstudio")]
        public Estudio? Estudio { get; set; }
    }
}
