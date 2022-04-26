using CadastroDeCandidatos.Data;
using CadastroDeCandidatos.Models;
using System.Collections.Generic;
using System.Linq;

namespace CadastroDeCandidatos.Repositorio
{
    public class CandidatoRepositorio : ICandidatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public CandidatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;

        }
        public List<CandidatoModel> BuscarTodos()
        {
            return _bancoContext.Candidato.ToList();
        }
        public CandidatoModel Adicionar(CandidatoModel candidato)
        {
            //gravando no banco de dados
            _bancoContext.Candidato.Add(candidato);
            _bancoContext.SaveChanges();

            return candidato;
        }

    }
}
