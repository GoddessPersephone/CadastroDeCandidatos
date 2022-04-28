using CadastroDeCandidatos.Models;
using System.Collections.Generic;
using System.Linq;

namespace CadastroDeCandidatos.Repositorio
{
    public interface ICandidatoRepositorio
    {
        CandidatoModel ListarPorId(int id);
        List<CandidatoModel> BuscarTodos();
        CandidatoModel Adicionar(CandidatoModel candidato);
        CandidatoModel Atualizar(CandidatoModel candidato);
    }
}
