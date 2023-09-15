using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebCodeFirst.Intefaces;
using WebCodeFirst.Repositories;
using WebCodeFirst.ViewModels;

namespace WebCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel usuario)
        { }
    }
}
