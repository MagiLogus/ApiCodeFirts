using WebCodeFirst.Domains;

namespace WebCodeFirst.Intefaces
{
    public interface IUsuarioRepository
    {
        Usuario BuscarUsuario(string email, string senha);

        void Cadastrar(Usuario usuario);
    }
}
