using CadastroDeCandidatos.Filters;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDeCandidatos.Controllers
{
    public class RestritaController : Controller
    {
        [PgUsuarioLogado]
        public IActionResult Index()
        {
            return View();
        }
    }
}
