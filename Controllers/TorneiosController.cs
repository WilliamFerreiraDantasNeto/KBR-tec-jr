using Microsoft.AspNetCore.Mvc;

namespace KRB_tec_jr.Controllers
{
    public class TorneiosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
