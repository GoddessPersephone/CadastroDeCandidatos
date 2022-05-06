using System.ComponentModel.DataAnnotations;
using CadastroDeCandidatos.Data;
using CadastroDeCandidatos.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CadastroDeCandidatos.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContext _context;
      

        public UsuarioRepositorio(BancoContext bancoContext)
        {
            _context = bancoContext;

        }

        public UsuarioModel BuscarPorLogin(string login)
        {
            return _context.Usuario.FirstOrDefault(x => x.Login.ToUpper() == login.ToUpper());
        }

        public UsuarioModel BuscarPorId(int id)
        {
            return _context.Usuario.FirstOrDefault(x => x.Id == id);
        }

      
        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            //gravando no banco de dados
            usuario.DataCadastro = DateTime.Now;
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
            return usuario;
        }

        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            UsuarioModel usuarioDB = ListarPorId(usuario.Id);
            if (usuarioDB == null) throw new System.Exception("Houve um erro na atualização do cadastro!");

            usuarioDB.Nome = usuario.Nome;
            usuarioDB.Login = usuario.Login;
            usuarioDB.Email = usuario.Email;
            usuarioDB.Perfil = usuario.Perfil;
            usuarioDB.DataAtualizacao = DateTime.Now;
            _context.Usuario.Update(usuarioDB);

            _context.SaveChanges();

            return usuarioDB;
        }

        public bool Apgar(int id)
        {
            UsuarioModel usuarioDB = ListarPorId(id);

            if (usuarioDB == null) throw new System.Exception("Houve um erro na exclusão do cadastro!");

            _context.Usuario.Remove(usuarioDB);
            _context.SaveChanges();

            return true;
        }

        List<UsuarioModel> IUsuarioRepositorio.BuscarTodos()
        {
            return _context.Usuario.ToList();
        }

        public UsuarioModel ListarPorId(int id) => _context.Usuario.ToList();

        return true;
    }
}
