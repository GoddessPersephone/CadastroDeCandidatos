using CadastroDeCandidatos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace CadastroDeCandidatos.Data
{
    public class BancoContext : DbContext
    {

        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<CandidatoModel> Candidato { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<LoginModel> Login { get; set; }

    }



}
