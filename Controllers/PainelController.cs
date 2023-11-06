using KRB_tec_jr.Models;
using KRB_tec_jr.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace KRB_tec_jr.Controllers
{
    public class PainelController : Controller
    {
        private readonly ICampeonatoRepositorio _campeonatoRepositorio;
        public PainelController(ICampeonatoRepositorio campeonatoRepositorio)
        {
            _campeonatoRepositorio = campeonatoRepositorio;
        }

        public IActionResult IndexPainel()
        {
            return View();
        }
        // Banco de Dados Campeonatos

        public IActionResult Campeonatos()
        {
            List<CampeonatosModel> Campeonatos = _campeonatoRepositorio.BuscarTodos();

            return View(Campeonatos);
        }

        public IActionResult CadastroCampeonato()
        {
            return View();
        }

        public IActionResult EditarCampeonato(int id)
        {
            CampeonatosModel campeonato = _campeonatoRepositorio.ListarPorId(id);
            return View(campeonato);
        }

        public IActionResult ApagarCampeonatoConfirmacao(int id)
        {
            CampeonatosModel campeonato = _campeonatoRepositorio.ListarPorId(id);
            return View(campeonato);
        }

        [HttpPost]
        public IActionResult CadastroCampeonato(CampeonatosModel campeonatos)
        {
            _campeonatoRepositorio.Adicionar(campeonatos);
            return RedirectToAction("Campeonatos");
        }
        public IActionResult ApagarCampeonato(int id)
        {
            _campeonatoRepositorio.Apagar(id);
            return RedirectToAction("Campeonatos");
        }
        [HttpPost]
        public IActionResult EditarCampeonato(CampeonatosModel campeonatos)
        {
            _campeonatoRepositorio.Atualizar(campeonatos);
            return RedirectToAction("Campeonatos");
        }

        // Banco de Dados usuários

        public IActionResult Usuarios()
        {
            return View();
        }

        public IActionResult CadastroUsuario()
        {
            return View();
        }

        public IActionResult EditarUsuario()
        {
            return View();
        }

    }
}
