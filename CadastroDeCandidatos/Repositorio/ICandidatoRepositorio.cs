using CadastroDeCandidatos.Models;
using System.Collections.Generic;

namespace CadastroDeCandidatos.Repositorio
{
    public interface ICandidatoRepositorio
    {
        List<CandidatoModel> BuscarTodos();
        CandidatoModel Adicionar(CandidatoModel candidato);
        
    }
}
