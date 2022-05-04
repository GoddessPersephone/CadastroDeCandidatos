using CadastroDeCandidatos.Models;
using System.Collections.Generic;
using System.Linq;

namespace CadastroDeCandidatos.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel ListarPorId(int id);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel Atualizar(UsuarioModel usuario);
        bool Apgar(int id);
    }
}
