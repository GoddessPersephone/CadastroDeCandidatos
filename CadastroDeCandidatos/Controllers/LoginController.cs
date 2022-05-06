using CadastroDeCandidatos.Helper;
using CadastroDeCandidatos.Models;
using CadastroDeCandidatos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;


namespace CadastroDeCandidatos.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginUsuarioRepositorio _loginRepositorio;

        public LoginController(ILoginUsuarioRepositorio loginRepositorio)
        {
            _loginRepositorio = loginRepositorio;
        }

        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly ISessao _sessao;

       public LoginController(IUsuarioRepositorio usuarioRepositorio, ISessao sessao)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            //se o usuario estiver logado, retornar para a home

            if (_sessao.BuscarSessaoDoUsuario() != null) return RedirectToAction("Index", "Home");

            return View();
        }
        
        public IActionResult Sair()
        {
            _sessao.RemoverSessaoDoUsuario();

            return RedirectToAction("Index", "Login");
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
                            _sessao.CriarSessaoDoUsuario(usuario);
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
        public IActionResult Criar()
        {
            return View(_loginRepositorio);

        }

        [HttpPost] //adicionando dados ao banco de dados
        public IActionResult Criar(LoginUsuarioRepositorio log, LoginUsuarioRepositorio loginUsuarioRepositorio)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    loginUsuarioRepositorio.Adicionar(log);
                    TempData["MensagemSucesso"] = "Usuário cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View("Login", log);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao cadastrar usuário, tente novamente. Erro:{erro.Message}";
                return RedirectToAction("Index");
            }

        }


    }








}