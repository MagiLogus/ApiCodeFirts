using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace WebCodeFirst.Domains
{
    [Table("Usuario")]
    [Index(nameof(Email), IsUnique=true)] //cria um indice unico 
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Obrigatorio")]
        public string? Email { get; set; }

        [Column(TypeName = "VARCHAR(200)")]
        [Required(ErrorMessage = "Obrigatorio senha")]
        [StringLength(200, MinimumLength = 6, ErrorMessage = "a senha deve conter de 6 a 20 caracteres")]
        public string? Senha { get; set; }

        // referencia da chave estrangeira  (tabela de tipo de usuario)
        [Required(ErrorMessage = "obrigatorio")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey("IdTipoUsuario")]
        public TiposUsuario? TiposUsuario { get; set; }

    }
}
