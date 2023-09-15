using System.ComponentModel.DataAnnotations;

namespace WebCodeFirst.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="email obrigatorio")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "senha obrigatorio")]
        public string? Senha { get; set; }
    }
}
