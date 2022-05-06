using CadastroDeCandidatos.Models;
using System.Collections.Generic;
using System.Linq;

namespace CadastroDeCandidatos.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel BuscarPorLogin(string login);
        UsuarioModel BuscarPorId(int id);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel Atualizar(UsuarioModel usuario);
        bool Apgar(int id);
        
    }
}
