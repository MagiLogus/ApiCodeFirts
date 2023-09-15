using WebCodeFirst.Domains;

namespace WebCodeFirst.Intefaces
{
    public interface IEstudioRepository
    {
        List<Estudio> Listar();
        Estudio BuscarPorId(Guid id);
        void Cadastrar(Estudio novoEstudio);
        void Atualizar(Guid id, Estudio estudio);
        void Deletar(Guid id);

        List<Estudio> ListarComJogos();
    }
}
