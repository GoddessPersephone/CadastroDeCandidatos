using CadastroDeCandidatos.Data;
using CadastroDeCandidatos.Models;
using System.Collections.Generic;
using System.Linq;

namespace CadastroDeCandidatos.Repositorio
{
    public class CandidatoRepositorio : ICandidatoRepositorio
    {
        private readonly BancoContext _context;
      

        public CandidatoRepositorio(BancoContext bancoContext)
        {
            _context = bancoContext;

        }
        public CandidatoModel ListarPorId(int id)
        {
            return _context.Candidato.FirstOrDefault(x => x.Id == id);
        }

        public List<CandidatoModel> BuscarTodos()
        {
            return _context.Candidato.ToList();
        }
      
        public CandidatoModel Adicionar(CandidatoModel candidato)
        {
            //gravando no banco de dados
            
            _context.Candidato.Add(candidato);
            _context.SaveChanges();
            return candidato;
        }

        public CandidatoModel Atualizar(CandidatoModel candidato)
        {
            CandidatoModel candidatoDB = ListarPorId(candidato.Id);
            if (candidatoDB == null) throw new System.Exception("Houve um erro na atualização do cadastro!");

            candidatoDB.Nome = candidato.Nome;
            candidatoDB.Nome = candidato.Email;
            candidatoDB.Nome = candidato.Conhecimento;
            candidatoDB.Nome = candidato.Celular;
            candidatoDB.Nome = candidato.Senha;

            _context.Candidato.Update(candidatoDB);

            _context.SaveChanges();

            return candidatoDB;
        }
    }
}
