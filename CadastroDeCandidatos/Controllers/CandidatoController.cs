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
        public IActionResult Editar(int id)
        {
            CandidatoModel candidato = _candidatoRepositorio.ListarPorId(id);
            return View(candidato);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            CandidatoModel candidato = _candidatoRepositorio.ListarPorId(id);
            return View(candidato);
        }
        
        public IActionResult  Apagar(int id)
        {
            try
            {
               bool apagaado = _candidatoRepositorio.Apgar(id);

                if (apagaado)
                {
                    TempData["MensagemSucesso"] = "Cadastro apagado com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Não foi possível excluir esse cadastro!";
                }

               return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {

                TempData["MensagemErro"] = $"Erro ao excluir candidato, tente novamente. Erro:{erro.Message}";
                return RedirectToAction("Index");
            }
            
        }

        [HttpPost] //adicionando dados ao banco de dados
        public IActionResult Criar(CandidatoModel candidato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _candidatoRepositorio.Adicionar(candidato);
                    TempData["MensagemSucesso"] = "Candidato cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View("Editar", candidato);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao cadastrar candidato, tente novamente. Erro:{erro.Message}";
                return RedirectToAction("Index");
            }

        }
        [HttpPost]
        public IActionResult Alterar(CandidatoModel candidato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _candidatoRepositorio.Atualizar(candidato);
                    TempData["MensagemSucesso"] = "Atualização de cadastrado efetuada com sucesso!";
                    return RedirectToAction("Index");
                }

                return View("Editar", candidato);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possivel atualuizar este cadastro, tente novamente. Erro:  {erro.Message}";
                return RedirectToAction("Index");
            }
        }


    }
}