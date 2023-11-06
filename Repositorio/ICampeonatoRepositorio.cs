using KRB_tec_jr.Models;

namespace KRB_tec_jr.Repositorio
{
    public interface ICampeonatoRepositorio
    {
        CampeonatosModel ListarPorId(int id);
        List<CampeonatosModel> BuscarTodos();
        CampeonatosModel Adicionar(CampeonatosModel campeonato);
        CampeonatosModel Atualizar(CampeonatosModel campeonato);
        bool Apagar(int id);
    }
}
