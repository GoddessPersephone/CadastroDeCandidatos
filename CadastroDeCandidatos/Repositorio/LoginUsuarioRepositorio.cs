using System.ComponentModel.DataAnnotations;
using CadastroDeCandidatos.Data;
using CadastroDeCandidatos.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CadastroDeCandidatos.Repositorio
{
    public class LoginUsuarioRepositorio : ILoginUsuarioRepositorio
    {
        private readonly BancoContext _context;
      

        public LoginUsuarioRepositorio(BancoContext bancoContext)
        {
            _context = bancoContext;

        }
        
        public LoginModel Adicionar(LoginModel usuario)
        {
            //gravando no banco de dados
           
            _context.Login.Add(usuario);
            _context.SaveChanges();
            return usuario;
        }

       
    }
}
