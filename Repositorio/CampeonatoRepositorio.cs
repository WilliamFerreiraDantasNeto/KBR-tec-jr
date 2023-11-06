using KRB_tec_jr.Data;
using KRB_tec_jr.Models;

namespace KRB_tec_jr.Repositorio
{
    public class CampeonatoRepositorio : ICampeonatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public CampeonatoRepositorio(BancoContext bancoContext){
            _bancoContext = bancoContext;
        }

        public CampeonatosModel ListarPorId(int id)
        {
            return _bancoContext.Campeonatos.FirstOrDefault(x => x.Codigo == id);
        }

        public List<CampeonatosModel> BuscarTodos()
        {
            return _bancoContext.Campeonatos.ToList();
        }

        public CampeonatosModel Adicionar(CampeonatosModel campeonato)
        {
            _bancoContext.Campeonatos.Add(campeonato);
            _bancoContext.SaveChanges();
            return campeonato;
        }

        public CampeonatosModel Atualizar(CampeonatosModel campeonato)
        {
            CampeonatosModel campeonatoDB = ListarPorId(campeonato.Codigo);
            if (campeonatoDB == null) throw new System.Exception("Houve um erro na atualização do Campeonato");
            campeonatoDB.Campeonato = campeonato.Campeonato;
            campeonatoDB.Estado = campeonato.Estado;
            campeonatoDB.Cidade = campeonato.Cidade;
            campeonatoDB.DataRealizacao = campeonato.DataRealizacao;
            campeonatoDB.Sobre = campeonato.Sobre;
            campeonatoDB.Ginasio = campeonato.Ginasio;
            campeonatoDB.InformacoesGerais = campeonato.InformacoesGerais;
            campeonatoDB.EntradaAoPublico = campeonato.EntradaAoPublico;
            campeonatoDB.Tipo = campeonato.Tipo;
            campeonatoDB.Fase = campeonato.Fase;
            campeonatoDB.Status = campeonato.Status;

            _bancoContext.Campeonatos.Update(campeonatoDB);
            _bancoContext.SaveChanges();

            return campeonatoDB;
        }

        public bool Apagar(int id)
        {
            CampeonatosModel campeonatoDB = ListarPorId(id);
            if (campeonatoDB == null) throw new System.Exception("Houve um erro na exclusão do Campeonato");
            _bancoContext.Campeonatos.Remove(campeonatoDB);
            _bancoContext.SaveChanges();
            return true;
        }
    }
}
