using CadastroDeCandidatos.Models;
using System.Collections.Generic;
using System.Linq;

namespace CadastroDeCandidatos.Repositorio
{
    public interface ILoginUsuarioRepositorio
    {
   
       
        LoginModel Adicionar(LoginModel usuario);
       
        
    }
}
