using CadastroDeCandidatos.Enuns;
using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeCandidatos.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Nome do Usuario")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o Login do Usuario")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite o Email do Usuario")]
        [EmailAddress(ErrorMessage = "Informe um email válido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe o Perfil do usuario")]
        public PerfilEnum? Perfil { get; set; }
        
    }
}
