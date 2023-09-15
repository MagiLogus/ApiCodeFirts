using WebCodeFirst.Contexts;
using WebCodeFirst.Domains;
using WebCodeFirst.Intefaces;
using WebCodeFirst.Utils;

namespace WebCodeFirst.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        /// <summary>
        /// variavel privada e somente leitura para armazenar os dados do contexto 
        /// </summary>
        private readonly InLockContexts ctx;

        /// <summary>
        /// construtor do repositorio 
        /// toda vez que o repositorio for instanciado, 
        /// ele tera acesso aos dados fornecidos pelo contexto
        /// </summary>
        public UsuarioRepository()
        {
            ctx = new InLockContexts();
        }

        public Usuario BuscarUsuario(string email, string senha)
        {
            try
            {
                Usuario usuariobuscado = ctx.Usuarios.FirstOrDefault(u => u.Email == email)!;

                if (usuariobuscado != null)
                {
                    bool confere = Criptografia.CompararHash(senha, usuariobuscado.Senha!);
                    if (confere)
                    {
                        return usuariobuscado;
                    }
                }
                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha!);
                ctx.Add(usuario);
                ctx.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
