using CadastroDeCandidatos.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeCandidatos.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Nome do Usuario")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o Login do Usuario")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite o Email do Usuario")]
        [EmailAddress(ErrorMessage = "Informe um email válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe ao menos um Conhecimento para o Candidato")]
        public string Conhecimento { get; set; }

        [Required(ErrorMessage = "Digite a Senha do Usuario")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Informe o Perfil do usuario")]
        public PerfilEnum? Perfil { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public bool SenhaValida(string senha)
        {
            return Senha == senha;
        }
    }
}
