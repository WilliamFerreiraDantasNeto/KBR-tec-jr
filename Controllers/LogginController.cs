using Microsoft.AspNetCore.Mvc;

namespace KRB_tec_jr.Controllers
{
    public class LogginController : Controller
    {
        public IActionResult Loggin()
        {
            return View();
        }

        public IActionResult RecuperarSenha()
        {
            return View();
        }
    }
}
