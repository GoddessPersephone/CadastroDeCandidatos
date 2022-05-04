using CadastroDeCandidatos.Models;
using CadastroDeCandidatos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CadastroDeCandidatos.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            List<UsuarioModel> usuario = _usuarioRepositorio.BuscarTodos();

            return View(usuario);
        }
        public IActionResult Editar(int id)
        {
            UsuarioModel usuario = _usuarioRepositorio.BuscarPorId(id);
            return View(usuario);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            UsuarioModel usuario = _usuarioRepositorio.BuscarPorId(id);

            return View(usuario);
        }
        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _usuarioRepositorio.Apgar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Usuário apagado com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Não foi possível excluir este usuário!";
                }

                return RedirectToAction("Index");
            }
            catch (System.Exception erro)
            {

                TempData["MensagemErro"] = $"Erro ao excluir usuário, tente novamente. Erro:{erro.Message}";
                return RedirectToAction("Index");
            }

        }
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost] //adicionando dados ao banco de dados
        public IActionResult Criar(UsuarioModel usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _usuarioRepositorio.Adicionar(usuario);
                    TempData["MensagemSucesso"] = "Usuário cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View("Editar", usuario);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao cadastrar usuário, tente novamente. Erro:{erro.Message}";
                return RedirectToAction("Index");
            }

        }
        public IActionResult Alterar(UsuarioSemSenhaModel usuarioSemSenhaModel)
        {
            try
            {
                UsuarioModel usuario = null;

                if (ModelState.IsValid)
                {
                    usuario = new UsuarioModel()
                    {
                        Id = usuarioSemSenhaModel.Id,
                        Nome = usuarioSemSenhaModel.Nome,
                        Login = usuarioSemSenhaModel.Login,
                        Email = usuarioSemSenhaModel.Email,
                        Perfil = usuarioSemSenhaModel.Perfil
                    };

                    usuario = _usuarioRepositorio.Atualizar(usuario);
                    TempData["MensagemSucesso"] = "Atualização de usuário efetuada com sucesso!";
                    return RedirectToAction("Index");
                }

                return View("Editar", usuario);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possivel atualuizar este usuário, tente novamente. Erro:  {erro.Message}";
                return RedirectToAction("Index");
            }
        }

    }
}
