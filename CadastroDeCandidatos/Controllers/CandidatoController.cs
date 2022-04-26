using CadastroDeCandidatos.Models;
using CadastroDeCandidatos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CadastroDeCandidatos.Controllers
{
    public class CandidatoController : Controller
    {
        private readonly ICandidatoRepositorio _candidatoRepositorio;
        public CandidatoController(ICandidatoRepositorio candidatoRepositorio)
        {
            _candidatoRepositorio = candidatoRepositorio;
        }
        public IActionResult Index()
        {
            List<CandidatoModel> candidato = _candidatoRepositorio.BuscarTodos();
            return View(candidato);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
        [HttpPost] //adicionando dados ao banco de dados
        public IActionResult Criar(CandidatoModel candidato)
        {
            _candidatoRepositorio.Adicionar(candidato);
            return RedirectToAction("Index");
        }


    }
}