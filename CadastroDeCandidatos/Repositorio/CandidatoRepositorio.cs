using CadastroDeCandidatos.Data;
using CadastroDeCandidatos.Models;

namespace CadastroDeCandidatos.Repositorio
{
    public class CandidatoRepositorio : ICandidatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public CandidatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;

        }
        public CandidatoModel Adicionar(CandidatoModel candidato)
        {
            _bancoContext.Candidato.Add(candidato);
            _bancoContext.SaveChanges();
            return candidato;
        }
    }
}
