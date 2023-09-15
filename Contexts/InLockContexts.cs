using Microsoft.EntityFrameworkCore;
using WebCodeFirst.Domains;

namespace WebCodeFirst.Contexts
{
    public class InLockContexts : DbContext
    {
        //Define as entidades do banco de dados dbset
        public DbSet<Estudio> Estudio { get; set; }

        public DbSet<Jogo> Jogo { get; set; }

        public DbSet<TiposUsuario> TiposUsuario { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        //define as opcoes de construcao do banco (string de conexao)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE19-S15; Database=inlock_games_codefirst_manha; user Id=sa; pwd=Senai@134; TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder); //objeto com as configuracoes definidas 
        }

    }
}
