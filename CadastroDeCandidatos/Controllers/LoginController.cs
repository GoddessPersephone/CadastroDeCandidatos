using CadastroDeCandidatos.Models;
using CadastroDeCandidatos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CadastroDeCandidatos.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    UsuarioModel usuario = _usuarioRepositorio.BuscarPorLogin(loginModel.Login);

                    if(usuario != null)
                    {
                        if (usuario.SenhaValida(loginModel.Senha))
                        {
                            return RedirectToAction("Index","Home");      
                        }

                        TempData["MensagemErro"] = $"Senha incorreta, tente novamente.";

                    }

                    TempData["MensagemErro"] = $"Login ou senha incorretos, tente novamente.";

                }

                return View("Index");
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login, tente novamente. Erro:{erro.Message}";
                return RedirectToAction("Index");
            }
        }
      

    }








}