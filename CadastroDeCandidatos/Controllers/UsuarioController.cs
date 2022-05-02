using Microsoft.AspNetCore.Mvc;

namespace CadastroDeCandidatos.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
